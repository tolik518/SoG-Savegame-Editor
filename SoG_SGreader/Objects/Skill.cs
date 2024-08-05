using SoG_SGreader.Enum.Attribute;

namespace SoG_SGreader
{
    public class Skill
    {
        public SogSkill SkillID { get; set; }
        public byte SkillLevel { get; set; }

        public static int GetMaxLevel(SogSkill skill)
        {
            var type = skill.GetType();
            var memInfo = type.GetMember(skill.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(SkillMaxLevelAttribute), false);
            return (attributes.Length > 0) ? ((SkillMaxLevelAttribute)attributes[0]).MaxLevel : 255;
        }
    }
}