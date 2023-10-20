using System;

namespace SoG_SGreader
{
    public class Item
    {
        public Item(SogItems _ItemID, int _ItemCount, UInt32 _ItemPos)
        {
            this.ItemID = _ItemID;
            this.ItemCount = _ItemCount;
            this.ItemPos = _ItemPos;
        }
        public SogItems ItemID { get; set; }
        public int ItemCount { get; set; }
        public UInt32 ItemPos { get; set; }

    }
}