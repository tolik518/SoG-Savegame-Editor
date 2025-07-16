using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class HouseStyle : IBinarySerializable
    {
        public byte Number { get; set; } //style 0, 1, 2 etc 
        public uint Length { get; set; }
        public byte[] Bytes { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Number);
            writer.Write(Length);
            writer.Write(Bytes);
        }

        public void Deserialize(BinaryReader reader)
        {
            Number = reader.ReadByte();
            Length = reader.ReadUInt32();
            Bytes = reader.ReadBytes((int)Length);
        }
    }
}