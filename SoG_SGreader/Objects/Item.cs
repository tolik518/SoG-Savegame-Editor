using System;

namespace SoG_SGreader
{
    [System.Serializable]
    public class Item
    {
        public SogItems ItemID { get; set; }
        public int ItemCount { get; set; }
        public uint ItemPos { get; set; }
        
        public override bool Equals(object obj)
        {
            Item item = obj as Item;
            if (item == null)
            {
                return false;
            }

            return ItemID == item.ItemID && ItemCount == item.ItemCount && ItemPos == item.ItemPos;
        }
    }
}