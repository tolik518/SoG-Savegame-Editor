namespace SoG_SGreader
{
    public class Item
    {
        public int ItemID { get; set; }
        public int ItemCount { get; set; }
        public uint ItemPos { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj is Item item)
            {
                return ItemID == item.ItemID && ItemCount == item.ItemCount && ItemPos == item.ItemPos;
            }

            return false;
        }
    }
}