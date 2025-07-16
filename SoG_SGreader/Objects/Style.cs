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
        public byte HairColor { get; set; }
        public byte SkinColor { get; set; }
        public byte PonchoColor { get; set; }
        public byte ShirtColor { get; set; }
        public byte PantsColor { get; set; }
        public byte Sex { get; set; }

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
            HairColor = reader.ReadByte();
            SkinColor = reader.ReadByte();
            PonchoColor = reader.ReadByte();
            ShirtColor = reader.ReadByte();
            PantsColor = reader.ReadByte();
            Sex = reader.ReadByte();
        }
    }
}