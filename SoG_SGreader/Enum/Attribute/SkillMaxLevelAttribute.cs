namespace SoG_SGreader.Enum.Attribute
{
    public class SkillMaxLevelAttribute : System.Attribute
    {
        public int MaxLevel { get; }

        public SkillMaxLevelAttribute(int maxLevel)
        {
            MaxLevel = maxLevel;
        }
    }
}
