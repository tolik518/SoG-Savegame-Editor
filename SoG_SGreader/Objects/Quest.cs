using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Quest : IBinarySerializable
    {
        public SogQuest QuestID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((ushort)QuestID);
        }

        public void Deserialize(BinaryReader reader)
        {
            QuestID = (SogQuest)reader.ReadUInt16();
        }
    }
}