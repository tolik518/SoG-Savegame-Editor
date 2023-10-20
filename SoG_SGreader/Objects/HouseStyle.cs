namespace SoG_SGreader
{
    public class HouseStyle
    {
        public byte HouseStyleNumber { get; set; } //style 0, 1, 2 etc 
        public int HouseStyleLength { get; set; }
        public byte[] HouseStyleBytes { get; set; }
        
        public HouseStyle(byte houseStyleNumber, int houseStyleLength, byte[] houseStyleBytes)
        {
            this.HouseStyleNumber = houseStyleNumber;
            this.HouseStyleLength = houseStyleLength;
            this.HouseStyleBytes = houseStyleBytes;
        }
    }
}