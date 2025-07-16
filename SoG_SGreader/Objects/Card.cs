using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Card : IBinarySerializable
    {
        public SogEnemy CardID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)CardID);
        }

        public void Deserialize(BinaryReader reader)
        {
            CardID = (SogEnemy)reader.ReadInt32();
        }
    }
}