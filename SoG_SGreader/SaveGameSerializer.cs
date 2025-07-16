using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoG_SGreader
{
    /// <summary>
    /// Unified serialization class that can handle both binary and JSON formats
    /// </summary>
    public static class SaveGameSerializer
    {
        public static Player LoadFromBinary(string filePath, ITextBoxWrapper txtConsole = null)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            using (var reader = new BinaryReader(fileStream))
            {
                txtConsole?.AppendText($"\r\nFilesize: {new FileInfo(filePath).Length}");
                
                var player = new Player();
                DeserializeObject(player, reader, txtConsole);
                return player;
            }
        }

        public static void SaveToBinary(Player player, string filePath)
        {
            using (var writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                SerializeObject(player, writer);
            }
        }

        public static Player LoadFromJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Player>(json, GetJsonSettings());
        }

        public static void SaveToJson(Player player, string filePath)
        {
            var json = JsonConvert.SerializeObject(player, GetJsonSettings());
            File.WriteAllText(filePath, json);
        }

        private static JsonSerializerSettings GetJsonSettings()
        {
            return new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include,
                Formatting = Formatting.Indented,
                Converters = { new StringEnumConverter() }
            };
        }

        private static void SerializeObject(object obj, BinaryWriter writer)
        {
            var type = obj.GetType();
            var properties = type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .OrderBy(p => p.GetCustomAttribute<BinaryOrderAttribute>()?.Order ?? int.MaxValue)
                .ToList();

            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                SerializeProperty(property, value, writer);
            }
        }

        private static void SerializeProperty(PropertyInfo property, object value, BinaryWriter writer)
        {
            var propertyType = property.PropertyType;

            if (value == null)
            {
                // Handle null values based on type
                if (propertyType == typeof(string))
                {
                    writer.Write((byte)0);
                    return;
                }
                throw new InvalidOperationException($"Cannot serialize null value for property {property.Name}");
            }

            // Handle primitive types
            if (propertyType == typeof(int))
                writer.Write((int)value);
            else if (propertyType == typeof(uint))
                writer.Write((uint)value);
            else if (propertyType == typeof(short))
                writer.Write((short)value);
            else if (propertyType == typeof(ushort))
                writer.Write((ushort)value);
            else if (propertyType == typeof(byte))
                writer.Write((byte)value);
            else if (propertyType == typeof(bool))
                writer.Write((bool)value);
            else if (propertyType == typeof(char))
                writer.Write((char)value);
            else if (propertyType == typeof(string))
            {
                var str = (string)value;
                writer.Write((byte)str.Length);
                writer.Write(str.ToCharArray());
            }
            // Handle enums
            else if (propertyType.IsEnum)
            {
                var enumValue = Convert.ToInt32(value);
                writer.Write(enumValue);
            }
            // Handle collections
            else if (typeof(System.Collections.IList).IsAssignableFrom(propertyType))
            {
                var list = (System.Collections.IList)value;
                SerializeCollection(list, writer);
            }
            // Handle custom objects
            else if (propertyType.IsClass)
            {
                SerializeObject(value, writer);
            }
            else
            {
                throw new NotSupportedException($"Unsupported property type: {propertyType}");
            }
        }

        private static void SerializeCollection(System.Collections.IList list, BinaryWriter writer)
        {
            if (list == null)
            {
                writer.Write(0);
                return;
            }

            writer.Write(list.Count);
            foreach (var item in list)
            {
                if (item == null)
                {
                    writer.Write((byte)0);
                    continue;
                }

                var itemType = item.GetType();
                
                // Handle special quickslot serialization
                if (itemType == typeof(SogItem))
                {
                    writer.Write((byte)1);
                    writer.Write((int)item);
                }
                else if (itemType == typeof(SogSkill))
                {
                    writer.Write((byte)2);
                    writer.Write((ushort)item);
                }
                else if (itemType.IsEnum)
                {
                    writer.Write((ushort)item);
                }
                else if (itemType.IsClass)
                {
                    SerializeObject(item, writer);
                }
                else
                {
                    throw new NotSupportedException($"Unsupported collection item type: {itemType}");
                }
            }
        }

        private static void DeserializeObject(object obj, BinaryReader reader, ITextBoxWrapper txtConsole)
        {
            var type = obj.GetType();
            var properties = type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite)
                .OrderBy(p => p.GetCustomAttribute<BinaryOrderAttribute>()?.Order ?? int.MaxValue)
                .ToList();

            foreach (var property in properties)
            {
                var value = DeserializeProperty(property, reader, txtConsole);
                property.SetValue(obj, value);
            }
        }

        private static object DeserializeProperty(PropertyInfo property, BinaryReader reader, ITextBoxWrapper txtConsole)
        {
            var propertyType = property.PropertyType;

            // Handle primitive types
            if (propertyType == typeof(int))
                return reader.ReadInt32();
            else if (propertyType == typeof(uint))
                return reader.ReadUInt32();
            else if (propertyType == typeof(short))
                return reader.ReadInt16();
            else if (propertyType == typeof(ushort))
                return reader.ReadUInt16();
            else if (propertyType == typeof(byte))
                return reader.ReadByte();
            else if (propertyType == typeof(bool))
                return reader.ReadBoolean();
            else if (propertyType == typeof(char))
                return reader.ReadChar();
            else if (propertyType == typeof(string))
            {
                var length = reader.ReadByte();
                if (length == 0) return string.Empty;
                return new string(reader.ReadChars(length));
            }
            // Handle enums
            else if (propertyType.IsEnum)
            {
                var enumValue = reader.ReadInt32();
                return Enum.ToObject(propertyType, enumValue);
            }
            // Handle collections
            else if (typeof(System.Collections.IList).IsAssignableFrom(propertyType))
            {
                return DeserializeCollection(propertyType, reader, txtConsole);
            }
            // Handle custom objects
            else if (propertyType.IsClass)
            {
                var instance = Activator.CreateInstance(propertyType);
                DeserializeObject(instance, reader, txtConsole);
                return instance;
            }
            else
            {
                throw new NotSupportedException($"Unsupported property type: {propertyType}");
            }
        }

        private static object DeserializeCollection(Type collectionType, BinaryReader reader, ITextBoxWrapper txtConsole)
        {
            var count = reader.ReadInt32();
            var elementType = collectionType.GetGenericArguments()[0];
            var listType = typeof(List<>).MakeGenericType(elementType);
            var list = (System.Collections.IList)Activator.CreateInstance(listType);

            for (int i = 0; i < count; i++)
            {
                object item;
                
                // Handle special quickslot deserialization
                if (elementType == typeof(object)) // Quickslots
                {
                    var quickSlotType = reader.ReadByte();
                    txtConsole?.AppendText($"\r\nquickSlotType: {quickSlotType}");
                    
                    switch (quickSlotType)
                    {
                        case 1:
                            item = (SogItem)reader.ReadInt32();
                            break;
                        case 2:
                            item = (SogSkill)reader.ReadUInt16();
                            break;
                        default:
                            item = 0;
                            break;
                    }
                }
                else if (elementType.IsEnum)
                {
                    var enumValue = reader.ReadUInt16();
                    item = Enum.ToObject(elementType, enumValue);
                }
                else if (elementType.IsClass)
                {
                    item = Activator.CreateInstance(elementType);
                    DeserializeObject(item, reader, txtConsole);
                }
                else
                {
                    throw new NotSupportedException($"Unsupported collection element type: {elementType}");
                }
                
                list.Add(item);
            }

            return list;
        }
    }

    /// <summary>
    /// Attribute to specify the order of properties during binary serialization
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class BinaryOrderAttribute : Attribute
    {
        public int Order { get; }

        public BinaryOrderAttribute(int order)
        {
            Order = order;
        }
    }
}