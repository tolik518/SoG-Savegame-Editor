using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{   
    public class Flag : IBinarySerializable
    {
        public SogFlag FlagID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)FlagID);
        }

        public void Deserialize(BinaryReader reader)
        {
            FlagID = (SogFlag)reader.ReadInt32();
        }
    }
}