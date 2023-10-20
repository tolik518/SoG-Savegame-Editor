namespace SoG_SGreader
{
    public class FishCaught
    {
        public SogItems FishID { get; set; }

        public FishCaught(SogItems fishId)
        {
            this.FishID = fishId;
        }
    }
}