using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Style : IBinarySerializable
    {
        public char Bodytype { get; set; }
        public int Hair { get; set; }
        public SogItem Hat { get; set; }
        public SogItem Facegear { get; set; }
        public SogItem Weapon { get; set; }
        public SogItem Shield { get; set; }
        public SogItem Armor { get; set; }
        public SogItem Shoes { get; set; }
        public SogItem Accessory1 { get; set; }
        public SogItem Accessory2 { get; set; }
        public bool HatHidden { get; set; }
        public bool FacegearHidden { get; set; }
        public int HairColor { get; set; }
        public int SkinColor { get; set; }
        public int PonchoColor { get; set; }
        public int ShirtColor { get; set; }
        public int PantsColor { get; set; }
        public int Sex { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Bodytype);
            writer.Write(Hair);
            writer.Write((int)Hat);
            writer.Write((int)Facegear);
            writer.Write((int)Weapon);
            writer.Write((int)Shield);
            writer.Write(HatHidden);
            writer.Write(FacegearHidden);
            writer.Write(HairColor);
            writer.Write(SkinColor);
            writer.Write(PonchoColor);
            writer.Write(ShirtColor);
            writer.Write(PantsColor);
            writer.Write(Sex);
        }

        public void Deserialize(BinaryReader reader)
        {
            Bodytype = reader.ReadChar();
            Hair = reader.ReadInt32();
            Hat = (SogItem)reader.ReadInt32();
            Facegear = (SogItem)reader.ReadInt32();
            Weapon = (SogItem)reader.ReadInt32();
            Shield = (SogItem)reader.ReadInt32();
            HatHidden = reader.ReadBoolean();
            FacegearHidden = reader.ReadBoolean();
            HairColor = reader.ReadInt32();
            SkinColor = reader.ReadInt32();
            PonchoColor = reader.ReadInt32();
            ShirtColor = reader.ReadInt32();
            PantsColor = reader.ReadInt32();
            Sex = reader.ReadInt32();
        }
    }
}