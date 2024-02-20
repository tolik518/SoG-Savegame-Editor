using System;

namespace SoG_SGreader
{
    public class Pet
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
    }
}