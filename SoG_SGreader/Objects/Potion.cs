using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Potion : IBinarySerializable
    {
        public SogItem PotionID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)PotionID);
        }

        public void Deserialize(BinaryReader reader)
        {
            PotionID = (SogItem)reader.ReadInt32();
        }
    }
}