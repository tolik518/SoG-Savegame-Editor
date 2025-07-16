using System;
using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Pet : IBinarySerializable
    {
        public int Type1 { get; set; }
        public int Type2 { get; set; }
        public string Nickname { get; set; }
        public byte Level { get; set; }
        public byte Skin { get; set; }

        public UInt16 StatHealth { get; set; }
        public UInt16 StatEnergy { get; set; }
        public UInt16 StatDamage { get; set; }
        public UInt16 StatCrit { get; set; }
        public UInt16 StatSpeed { get; set; }

        public UInt16 StatProgressHealth { get; set; }
        public UInt16 StatProgressEnergy { get; set; }
        public UInt16 StatProgressDamage { get; set; }
        public UInt16 StatProgressCrit { get; set; }
        public UInt16 StatProgressSpeed { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Type1);
            writer.Write(Type2);
            writer.Write(Nickname);
            writer.Write(Level);
            writer.Write(Skin);
            writer.Write(StatHealth);
            writer.Write(StatEnergy);
            writer.Write(StatDamage);
            writer.Write(StatCrit);
            writer.Write(StatSpeed);
            writer.Write(StatProgressHealth);
            writer.Write(StatProgressEnergy);
            writer.Write(StatProgressDamage);
            writer.Write(StatProgressCrit);
            writer.Write(StatProgressSpeed);
        }

        public void Deserialize(BinaryReader reader)
        {
            Type1 = reader.ReadInt32();
            Type2 = reader.ReadInt32();
            Nickname = reader.ReadString();
            Level = reader.ReadByte();
            Skin = reader.ReadByte();
            StatHealth = reader.ReadUInt16();
            StatEnergy = reader.ReadUInt16();
            StatDamage = reader.ReadUInt16();
            StatCrit = reader.ReadUInt16();
            StatSpeed = reader.ReadUInt16();
            StatProgressHealth = reader.ReadUInt16();
            StatProgressEnergy = reader.ReadUInt16();
            StatProgressDamage = reader.ReadUInt16();
            StatProgressCrit = reader.ReadUInt16();
            StatProgressSpeed = reader.ReadUInt16();
        }
    }
}