using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader.Serialization
{
    /// <summary>
    /// Generic binary serializer that can handle various data types and collections
    /// </summary>
    public static class BinarySerializer
    {
        /// <summary>
        /// Deserialize a Player object from a binary file
        /// </summary>
        /// <param name="fileName">Path to the binary file</param>
        /// <param name="textConsole">Text console for logging</param>
        /// <returns>Deserialized Player object</returns>
        public static Player DeserializePlayer(string fileName, ITextBoxWrapper textConsole)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                var player = new Player();
                player.Deserialize(reader);
                return player;
            }
        }

        /// <summary>
        /// Serialize a Player object to a binary file
        /// </summary>
        /// <param name="player">Player object to serialize</param>
        /// <param name="fileName">Path to the binary file</param>
        public static void SerializePlayer(Player player, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                player.Serialize(writer);
            }
        }

        /// <summary>
        /// Serialize a list of items with a count prefix
        /// </summary>
        /// <typeparam name="T">Type of items in the list</typeparam>
        /// <param name="writer">Binary writer</param>
        /// <param name="list">List to serialize</param>
        /// <param name="serializeItem">Function to serialize each item</param>
        public static void SerializeList<T>(BinaryWriter writer, IList<T> list, Action<BinaryWriter, T> serializeItem)
        {
            writer.Write(list.Count);
            foreach (var item in list)
            {
                serializeItem(writer, item);
            }
        }

        /// <summary>
        /// Serialize a list of items with a count prefix using a specific count type
        /// </summary>
        /// <typeparam name="T">Type of items in the list</typeparam>
        /// <param name="writer">Binary writer</param>
        /// <param name="list">List to serialize</param>
        /// <param name="serializeItem">Function to serialize each item</param>
        /// <param name="writeCount">Function to write the count</param>
        public static void SerializeList<T>(BinaryWriter writer, IList<T> list, Action<BinaryWriter, T> serializeItem, Action<BinaryWriter, int> writeCount)
        {
            writeCount(writer, list.Count);
            foreach (var item in list)
            {
                serializeItem(writer, item);
            }
        }

        /// <summary>
        /// Deserialize a list of items with a count prefix
        /// </summary>
        /// <typeparam name="T">Type of items in the list</typeparam>
        /// <param name="reader">Binary reader</param>
        /// <param name="deserializeItem">Function to deserialize each item</param>
        /// <returns>Deserialized list</returns>
        public static List<T> DeserializeList<T>(BinaryReader reader, Func<BinaryReader, T> deserializeItem)
        {
            var count = reader.ReadInt32();
            var list = new List<T>(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(deserializeItem(reader));
            }
            return list;
        }

        /// <summary>
        /// Deserialize a list of items with a count prefix using a specific count type
        /// </summary>
        /// <typeparam name="T">Type of items in the list</typeparam>
        /// <param name="reader">Binary reader</param>
        /// <param name="deserializeItem">Function to deserialize each item</param>
        /// <param name="readCount">Function to read the count</param>
        /// <returns>Deserialized list</returns>
        public static List<T> DeserializeList<T>(BinaryReader reader, Func<BinaryReader, T> deserializeItem, Func<BinaryReader, int> readCount)
        {
            var count = readCount(reader);
            var list = new List<T>(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(deserializeItem(reader));
            }
            return list;
        }
    }
}