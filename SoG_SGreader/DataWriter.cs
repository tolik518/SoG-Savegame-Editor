using System.Drawing;
using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class DataWriter
    {
        private readonly Player playerObject;

        public DataWriter(Player playerObject)
        {
            this.playerObject = playerObject;
        }

        public void WriteToFile(string fileName)
        {
            BinarySerializer.SerializePlayer(playerObject, fileName);
        }
    }
}