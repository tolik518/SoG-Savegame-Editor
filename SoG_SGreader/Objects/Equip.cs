namespace SoG_SGreader
{
    public class Equip
    {
        [BinaryOrder(1)]
        public SogItem Hat { get; set; }
        
        [BinaryOrder(2)]
        public SogItem Facegear { get; set; }
        
        [BinaryOrder(3)]
        public SogItem Weapon { get; set; }
        
        [BinaryOrder(4)]
        public SogItem Shield { get; set; }
        
        [BinaryOrder(5)]
        public SogItem Armor { get; set; }
        
        [BinaryOrder(6)]
        public SogItem Shoes { get; set; }
        
        [BinaryOrder(7)]
        public SogItem Accessory1 { get; set; }
        
        [BinaryOrder(8)]
        public SogItem Accessory2 { get; set; }
    }
}