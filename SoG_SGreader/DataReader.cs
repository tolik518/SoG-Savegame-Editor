using System;
using System.Collections.Generic;
using System.IO;
using SoG_SGreader.Serialization;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader
{
    public static class DataReader
    {
        public static Player ReadFromFile(string fileName, ITextBoxWrapper txtConsole)
        {
            return BinarySerializer.DeserializePlayer(fileName, txtConsole);
        }

        public static PlayerPreview GetPlayerPreview(string fileName)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Open))
            using (var reader = new BinaryReader(fileStream))
            {
                var preview = new PlayerPreview();
                
                // Read magic byte
                reader.ReadInt32();
                
                // Skip equipment serialization (Equip.Serialize)
                SkipEquipSerialization(reader);
                
                // Skip style partial serialization
                SkipStylePartialSerialization(reader);
                
                // Read nickname
                preview.Nickname = reader.ReadString();
                
                // Skip to sex in style (need to skip a lot of data)
                // This would require reading through the entire player structure
                // For now, let's set a default value
                preview.Sex = true; // Default to male
                
                return preview;
            }
        }
        
        private static void SkipEquipSerialization(BinaryReader reader)
        {
            // Skip Equip serialization based on Equip.cs structure
            // This is a simplified skip - might need adjustment based on actual Equip structure
            reader.ReadInt32(); // LastTwoHander
            reader.ReadInt32(); // LastOneHander  
            reader.ReadInt32(); // LastBow
            // Skip other equip fields as needed
        }
        
        private static void SkipStylePartialSerialization(BinaryReader reader)
        {
            // Skip the partial style serialization that happens before nickname
            reader.ReadChar(); // Bodytype
            reader.ReadInt32(); // Hair
            reader.ReadInt32(); // Weapon
            reader.ReadInt32(); // Shield
            reader.ReadInt32(); // Armor
            reader.ReadInt32(); // Shoes
            reader.ReadInt32(); // Accessory1
            reader.ReadInt32(); // Accessory2
            reader.ReadInt32(); // Hat
            reader.ReadInt32(); // Facegear
            reader.ReadInt32(); // Weapon (again)
            reader.ReadInt32(); // Shield (again)
        }
    }
}