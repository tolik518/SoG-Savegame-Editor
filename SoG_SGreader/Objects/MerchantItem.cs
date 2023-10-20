namespace SoG_SGreader
{
    public class MerchantItem
    {
        public MerchantItem(SogItems _ItemID, int _ItemCount)
        {
            this.ItemID = _ItemID;
            this.ItemCount = _ItemCount;
        }
        public SogItems ItemID { get; set; }
        public int ItemCount { get; set; }
    }
}