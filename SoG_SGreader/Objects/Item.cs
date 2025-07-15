using System;

namespace SoG_SGreader
{
    public class Item
    {
        public SogItem ID { get; set; }
        public int Count { get; set; }
        public uint Position { get; set; }
        public uint Plusses
        {
            get
            {
                // for every 1000000 added to the ID, it is a plus, so 2350000 would return 2
                // pay attention to overflows
                return (uint) ((int) ID / PlusItemStart);

            }
            set
            {
                Plusses = value;
            }
        }
        private bool isPlusItem;
        public const int PlusItemStart = 1000000;
        
        public override bool Equals(object obj)
        {
            if (obj is Item item)
            {
                return ID == item.ID && 
                    Count == item.Count && 
                    Position == item.Position && 
                    Plusses == item.Plusses;
            }

            return false;
        }

        public static bool IsPlusItem(SogItem ItemID)
        {
            return (int) ItemID > PlusItemStart;
        }

        public static SogItem GetIdWithoutPlusses(SogItem ItemID)
        {
            int id = (int)ItemID;
            while (id >= PlusItemStart)
            {
                id -= PlusItemStart;
            }

            return (SogItem) id;
        }

        public static string GetNameById(SogItem itemId, bool withoutPlusses = false)
        {
            string baseName = GetIdWithoutPlusses(itemId).ToString();
            if (withoutPlusses) return baseName;

            uint plusses = (uint)((int)itemId / PlusItemStart);

            return plusses switch
            {
                0 => baseName,
                1 => $"{baseName} +",     // ONE plus → drop the numeric suffix
                _ => $"{baseName} +{plusses}"
            };
        }

        public static SogItem GetItemByName(string name)
        {
            // parse the SogItem enum by name
            if (SogItem.TryParse<SogItem>(name, true, out SogItem item))
            {
                return item;
            }
            else
            {
                throw new ArgumentException($"Invalid item name: {name}");
            }
        }

        public bool IsPlusItem()
        {
            return IsPlusItem(ID);
        }

        public string GetItemName(bool withoutPlusses = false)
        {
            return GetNameById(ID, withoutPlusses);
        }
    }
}