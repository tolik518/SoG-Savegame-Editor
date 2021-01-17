using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoG_SGreader
{
    public class Sog_Player
    {
        public Equip equip = new Equip();
        public Style style = new Style();
        public Inventory[] inventory;
        public List<Inventory> _inventory;

        public int magicByte;
        public class Equip
        {
            public int Hat { get; set; }
            public int Facegear { get; set; }
            public int Weapon { get; set; }
            public int Shield { get; set; }
            public int Armor { get; set; }
            public int Shoes { get; set; }
            public int Accessory1 { get; set; }
            public int Accessory2 { get; set; }
        }
        public class Style
        {
            public char Bodytype { get; set; }
            public int Hair { get; set; }
            public int Hat { get; set; }
            public int Facegear { get; set; }
            public int Weapon { get; set; }
            public int Shield { get; set; }
            public bool HatHidden { get; set; }
            public bool FacegearHidden { get; set; }
            public int HairColor { get; set; }
            public int SkinColor { get; set; }
            public int PonchoColor { get; set; }
            public int ShirtColor { get; set; }
            public int PantsColor { get; set; }
            public int Sex { get; set; }
        }
        public int LastTwoHander { get; set; }
        public int LastOneHander { get; set; }
        public int LastBow { get; set; }
        public List<object> quickslots = new List<object>();
        public int NicknameLength { get; set; }
        public string Nickname { get; set; }
        public int InventorySize { get; set; }
        public class Inventory
        {
            public Inventory(Sog_Items _ItemID, int _ItemCount, UInt32 _ItemPos)
            {
                this.ItemID = _ItemID;
                this.ItemCount = _ItemCount;
                this.ItemPos = _ItemPos;
            }
            public Sog_Items ItemID { get; set; }
            public int ItemCount { get; set; }
            public UInt32 ItemPos { get; set; }
        }
        public byte[] scrap;
    }
}
