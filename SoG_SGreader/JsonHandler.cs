using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoG_SGreader
{
    public static class JsonHandler
    {
        private static bool IsDirectory(string jsonFilePath)
        {
            try
            {
                return File.GetAttributes(jsonFilePath).HasFlag(FileAttributes.Directory);
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public static string SaveGameToJson(Player player, string jsonFilePath)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.Formatting = Formatting.Indented;
            serializer.Converters.Add(new StringEnumConverter());
            
            string jsonPath = jsonFilePath;
            
            if (IsDirectory(jsonFilePath))
            {
                jsonPath = jsonFilePath + Path.DirectorySeparatorChar + player.UniquePlayerId + "_" + player.Nickname + ".json";
            } 
            else if (!File.Exists(jsonFilePath))
            {
                File.Create(jsonFilePath).Close();
            }
            else
            {
                throw new Exception("File already exists");
            }
            
            using (StreamWriter sw = new StreamWriter(jsonPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, player);
            }

            return jsonPath;
        }
        
        public static string GetJson(Player player)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.Formatting = Formatting.Indented;
            serializer.Converters.Add(new StringEnumConverter()); // TODO: make this optional
            try
            {
                StringWriter sw = new StringWriter();
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, player);
                }
                return sw.ToString();

            }
            catch (Exception e)
            {
                StringWriter sw = new StringWriter();
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, e);
                }
                return sw.ToString();
            }
        }
    }
}