namespace SoG_SGreader
{
    [System.Serializable]
    public class HouseStyle
    {
        public byte HouseStyleNumber { get; set; } //style 0, 1, 2 etc 
        public int HouseStyleLength { get; set; }
        public byte[] HouseStyleBytes { get; set; }
    }
}