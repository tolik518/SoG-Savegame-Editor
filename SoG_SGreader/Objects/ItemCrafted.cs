namespace SoG_SGreader
{
    public class ItemCrafted
    {
        public SogItems ItemID { get; set; }

        public ItemCrafted(SogItems itemId)
        {
            this.ItemID = itemId;
        }
    }
}