using System;
using System.Collections.Generic;
using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public static class DataReader
    {
        public static Player ReadFromFile(string fileName, ITextBoxWrapper txtConsole)
        {
            return BinarySerializer.DeserializePlayer(fileName, txtConsole);
        }
    }
}