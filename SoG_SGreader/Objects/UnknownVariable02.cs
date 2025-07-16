using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class UnknownVariable02 : IBinarySerializable
    {
        public byte UnknownByte { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(UnknownByte);
        }

        public void Deserialize(BinaryReader reader)
        {
            UnknownByte = reader.ReadByte();
        }
    }
}