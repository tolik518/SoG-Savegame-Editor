using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class FishCaught : IBinarySerializable
    {
        public SogItem FishID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)FishID);
        }

        public void Deserialize(BinaryReader reader)
        {
            FishID = (SogItem)reader.ReadInt32();
        }
    }
}