namespace SoG_SGreader
{
    public class Skill
    {
        public SogSkills SkillID { get; set; }
        public byte SkillLevel { get; set; }
        public Skill(SogSkills skillId, byte skillLevel)
        {
            this.SkillID = skillId;
            this.SkillLevel = skillLevel;
        }
    }
}