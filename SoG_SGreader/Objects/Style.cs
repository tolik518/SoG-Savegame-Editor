namespace SoG_SGreader
{
    public class Style
    {
        [BinaryOrder(1)]
        public char Bodytype { get; set; }
        
        [BinaryOrder(2)]
        public int Hair { get; set; }
        
        [BinaryOrder(3)]
        public SogItem Hat { get; set; }
        
        [BinaryOrder(4)]
        public SogItem Facegear { get; set; }
        
        [BinaryOrder(5)]
        public SogItem Weapon { get; set; }
        
        [BinaryOrder(6)]
        public SogItem Shield { get; set; }
        
        [BinaryOrder(7)]
        public bool HatHidden { get; set; }
        
        [BinaryOrder(8)]
        public bool FacegearHidden { get; set; }
        
        [BinaryOrder(9)]
        public int HairColor { get; set; }
        
        [BinaryOrder(10)]
        public int SkinColor { get; set; }
        
        [BinaryOrder(11)]
        public int PonchoColor { get; set; }
        
        [BinaryOrder(12)]
        public int ShirtColor { get; set; }
        
        [BinaryOrder(13)]
        public int PantsColor { get; set; }
        
        [BinaryOrder(14)]
        public int Sex { get; set; }
    }
}