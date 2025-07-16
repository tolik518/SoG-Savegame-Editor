using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SoG_SGreader
{
    /// <summary>
    /// Legacy JsonHandler - now uses the unified SaveGameSerializer
    /// </summary>
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
        
        /// <summary>
        /// Saves player data to JSON format using the unified serializer
        /// </summary>
        public static string SaveGameToJson(Player player, string jsonFilePath)
        {
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
            
            SaveGameSerializer.SaveToJson(player, jsonPath);
            return jsonPath;
        }
        
        /// <summary>
        /// Gets JSON string representation of player data
        /// </summary>
        public static string GetJson(Player player)
        {
            try
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Include;
                serializer.Formatting = Formatting.Indented;
                serializer.Converters.Add(new StringEnumConverter());
                
                StringWriter sw = new StringWriter();
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, player);
                }
                return sw.ToString();
            }
            catch (Exception e)
            {
                JsonSerializer serializer = new JsonSerializer();
                StringWriter sw = new StringWriter();
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, e);
                }
                return sw.ToString();
            }
        }
        
        /// <summary>
        /// Loads player data from JSON format using the unified serializer
        /// </summary>
        public static Player LoadGameFromJson(string jsonFilePath)
        {
            return SaveGameSerializer.LoadFromJson(jsonFilePath);
        }
    }
}