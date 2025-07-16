using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class ItemSeen : IBinarySerializable
    {
        public SogItem ItemID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)ItemID);
        }

        public void Deserialize(BinaryReader reader)
        {
            ItemID = (SogItem)reader.ReadInt32();
        }
    }
}