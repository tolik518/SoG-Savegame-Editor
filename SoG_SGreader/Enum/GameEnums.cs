using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoG_SGreader.Enum
{
    public static class GameEnums
    {
        public static DynamicEnum SogItem;

        public static void InitializeEnums()
        {
            SogItem = new DynamicEnum("ItemTypes.json", "ItemTypes");
        }
    }
}
