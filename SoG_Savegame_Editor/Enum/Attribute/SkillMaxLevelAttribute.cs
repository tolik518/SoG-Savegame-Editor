using System;

namespace SoG_Savegame_Editor.Enum.Attribute
{
    internal class SkillMaxLevelAttribute : System.Attribute
    {
        public int MaxLevel { get; }

        internal SkillMaxLevelAttribute(int maxLevel)
        {
            MaxLevel = maxLevel;
        }
    }
}
