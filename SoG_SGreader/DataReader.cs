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
            try
            {
                // Use the full deserialization approach since parsing the binary format manually is complex
                var fakeTextBox = new FakeTextBox();
                var fullPlayer = BinarySerializer.DeserializePlayer(fileName, fakeTextBox);
                
                var preview = new PlayerPreview();
                preview.Nickname = fullPlayer.Nickname;
                preview.Sex = fullPlayer.Style.Sex == 1; // Assuming 1 = male, 0 = female
                
                return preview;
            }
            catch (Exception)
            {
                // If deserialization fails, return a default preview
                return new PlayerPreview 
                { 
                    Nickname = "Unknown", 
                    Sex = true 
                };
            }
        }
        

    }
}