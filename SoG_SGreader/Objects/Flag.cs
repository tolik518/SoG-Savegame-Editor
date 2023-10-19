using System;

namespace SoG_SGreader
{
    public class Flag
    {
        public UInt16 FlagID { get; set; }

        public Flag(UInt16 flagId) 
        {
            this.FlagID = flagId;
        }
    }
}