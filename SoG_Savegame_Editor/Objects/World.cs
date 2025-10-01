using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoG_Savegame_Editor
{
    public class World
    {
        public int MagicByte { get; set; }
        public int SavePointId { get; set; }
        public int QuestsCount { get; set; }
        public List<Quest> Quests;

    }
}