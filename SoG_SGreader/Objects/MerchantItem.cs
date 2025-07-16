using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class MerchantItem : IBinarySerializable
    {
        public SogItem ItemID { get; set; }
        public int ItemCount { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)ItemID);
            writer.Write(ItemCount);
        }

        public void Deserialize(BinaryReader reader)
        {
            ItemID = (SogItem)reader.ReadInt32();
            ItemCount = reader.ReadInt32();
        }
    }
}