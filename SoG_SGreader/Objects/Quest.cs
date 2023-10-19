using System;

namespace SoG_SGreader
{
    public class Quest
    {
        public UInt16 QuestID { get; set; }

        public Quest(UInt16 questId)
        {
            this.QuestID = questId;
        }
    }
}