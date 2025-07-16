using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Equip : IBinarySerializable
    {
        public SogItem Hat { get; set; }
        public SogItem Facegear { get; set; }
        public SogItem Weapon { get; set; }
        public SogItem Shield { get; set; }
        public SogItem Armor { get; set; }
        public SogItem Shoes { get; set; }
        public SogItem Accessory1 { get; set; }
        public SogItem Accessory2 { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)Hat);
            writer.Write((int)Facegear);
            writer.Write((int)Weapon);
            writer.Write((int)Shield);
            writer.Write((int)Armor);
            writer.Write((int)Shoes);
            writer.Write((int)Accessory1);
            writer.Write((int)Accessory2);
        }

        public void Deserialize(BinaryReader reader)
        {
            Hat = (SogItem)reader.ReadInt32();
            Facegear = (SogItem)reader.ReadInt32();
            Weapon = (SogItem)reader.ReadInt32();
            Shield = (SogItem)reader.ReadInt32();
            Armor = (SogItem)reader.ReadInt32();
            Shoes = (SogItem)reader.ReadInt32();
            Accessory1 = (SogItem)reader.ReadInt32();
            Accessory2 = (SogItem)reader.ReadInt32();
        }
    }
}