using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class TreasureFound : IBinarySerializable
    {
        public SogTreasureMap TreasureMapID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((ushort)TreasureMapID);
        }

        public void Deserialize(BinaryReader reader)
        {
            TreasureMapID = (SogTreasureMap)reader.ReadUInt16();
        }
    }
}