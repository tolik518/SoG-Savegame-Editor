namespace SoG_SGreader
{
    public class Item
    {
        public SogItem ItemID { get; set; }
        public int ItemCount { get; set; }
        public uint ItemPos { get; set; }

        private bool isPlusItem;
        public const int PlusItemStart = 1000000;
        
        public override bool Equals(object obj)
        {
            if (obj is Item item)
            {
                return ItemID == item.ItemID && ItemCount == item.ItemCount && ItemPos == item.ItemPos;
            }

            return false;
        }

        public static bool IsPlusItem(SogItem ItemID)
        {
            return (int) ItemID > PlusItemStart;
        }

        public bool IsPlusItem()
        {
            return IsPlusItem(ItemID);
        }

        public string GetItemName()
        {
            // add a plus sign if it's a plus item and get the item ID (minus PlusItemStart) as a string
            if (IsPlusItem())
            {
                return ((SogItem)((int) ItemID - PlusItemStart)).ToString() + "+";
            }

            return ItemID.ToString();
        }
    }
}