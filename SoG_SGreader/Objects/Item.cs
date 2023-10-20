using System;

namespace SoG_SGreader
{
    public class Item
    {
        public SogItems ItemID { get; set; }
        public int ItemCount { get; set; }
        public UInt32 ItemPos { get; set; }
        public Item(SogItems _ItemID, int _ItemCount, UInt32 _ItemPos)
        {
            this.ItemID = _ItemID;
            this.ItemCount = _ItemCount;
            this.ItemPos = _ItemPos;
        }
        
        public override bool Equals(object obj)
        {
            Item item = obj as Item;
            if (item == null)
            {
                return false;
            }

            return this.ItemID == item.ItemID && this.ItemCount == item.ItemCount && this.ItemPos == item.ItemPos;
        }
    }
}