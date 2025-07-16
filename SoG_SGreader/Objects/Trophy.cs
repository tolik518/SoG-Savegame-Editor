using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Trophy : IBinarySerializable
    {
        public SogTrophy TrophyID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((ushort)TrophyID);
        }

        public void Deserialize(BinaryReader reader)
        {
            TrophyID = (SogTrophy)reader.ReadUInt16();
        }
    }
}