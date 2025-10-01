namespace SoG_Savegame_Editor
{
    public class HouseStyle
    {
        public byte Number { get; set; } //style 0, 1, 2 etc 
        public uint Length { get; set; }
        public byte[] Bytes { get; set; }
    }
}