using System.IO;
using SoG_SGreader.Enum.Attribute;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Skill : IBinarySerializable
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

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((ushort)SkillID);
            writer.Write(SkillLevel);
        }

        public void Deserialize(BinaryReader reader)
        {
            SkillID = (SogSkill)reader.ReadUInt16();
            SkillLevel = reader.ReadByte();
        }
    }
}