using System;

namespace SoG_SGreader.Enum.Attribute
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
