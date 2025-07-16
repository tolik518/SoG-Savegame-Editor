using System;
using System.IO;

namespace SoG_SGreader
{
    /// <summary>
    /// Example showing how the unified SaveGameSerializer replaces DataReader and DataWriter
    /// </summary>
    public static class SerializationMigrationExample
    {
        /// <summary>
        /// Old approach using separate DataReader and DataWriter classes
        /// </summary>
        public static void OldApproach(string filePath, ITextBoxWrapper console)
        {
            // OLD WAY - Manual reading with DataReader
            Player player = DataReader.ReadFromFile(filePath, console);
            
            // OLD WAY - Manual writing with DataWriter
            var writer = new DataWriter(player);
            writer.WriteToFile(filePath + ".backup");
            
            // JSON was handled separately
            JsonHandler.SaveGameToJson(player, filePath + ".json");
        }
        
        /// <summary>
        /// New approach using unified SaveGameSerializer
        /// </summary>
        public static void NewApproach(string filePath, ITextBoxWrapper console)
        {
            // NEW WAY - Unified serializer handles both binary and JSON
            Player player = SaveGameSerializer.LoadFromBinary(filePath, console);
            
            // Save in multiple formats with the same API
            SaveGameSerializer.SaveToBinary(player, filePath + ".backup");
            SaveGameSerializer.SaveToJson(player, filePath + ".json");
            
            // Can also load from JSON
            Player playerFromJson = SaveGameSerializer.LoadFromJson(filePath + ".json");
        }
        
        /// <summary>
        /// Example of format conversion using the unified serializer
        /// </summary>
        public static void ConvertBinaryToJson(string binaryFilePath, string jsonFilePath, ITextBoxWrapper console)
        {
            // Load from binary format
            Player player = SaveGameSerializer.LoadFromBinary(binaryFilePath, console);
            
            // Save as JSON
            SaveGameSerializer.SaveToJson(player, jsonFilePath);
            
            console?.AppendText($"\r\nConverted {binaryFilePath} to {jsonFilePath}");
        }
        
        /// <summary>
        /// Example of format conversion from JSON back to binary
        /// </summary>
        public static void ConvertJsonToBinary(string jsonFilePath, string binaryFilePath, ITextBoxWrapper console)
        {
            // Load from JSON format
            Player player = SaveGameSerializer.LoadFromJson(jsonFilePath);
            
            // Save as binary
            SaveGameSerializer.SaveToBinary(player, binaryFilePath);
            
            console?.AppendText($"\r\nConverted {jsonFilePath} to {binaryFilePath}");
        }
        
        /// <summary>
        /// Example showing all the benefits of the unified approach
        /// </summary>
        public static void DemonstrateUnifiedApproach(string filePath, ITextBoxWrapper console)
        {
            try
            {
                // Single API for all operations
                console?.AppendText("\r\n=== Unified Serialization Demo ===");
                
                // Load from binary
                Player player = SaveGameSerializer.LoadFromBinary(filePath, console);
                console?.AppendText($"\r\nLoaded player: {player.Nickname} (Level {player.Level})");
                
                // Save to multiple formats
                SaveGameSerializer.SaveToBinary(player, filePath + ".backup");
                SaveGameSerializer.SaveToJson(player, filePath + ".json");
                
                // Verify by loading from JSON
                Player playerFromJson = SaveGameSerializer.LoadFromJson(filePath + ".json");
                console?.AppendText($"\r\nVerified JSON: {playerFromJson.Nickname} (Level {playerFromJson.Level})");
                
                // No need for separate DataReader/DataWriter classes!
                console?.AppendText("\r\nBenefits:");
                console?.AppendText("\r\n✓ Single API for all formats");
                console?.AppendText("\r\n✓ Automatic serialization using attributes");
                console?.AppendText("\r\n✓ Less code duplication");
                console?.AppendText("\r\n✓ Easier to maintain");
                console?.AppendText("\r\n✓ Type-safe with reflection");
            }
            catch (Exception ex)
            {
                console?.AppendText($"\r\nError: {ex.Message}");
            }
        }
    }
}