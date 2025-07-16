using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class Enemy : IBinarySerializable
    {
        public SogEnemy EnemyID { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)EnemyID);
        }

        public void Deserialize(BinaryReader reader)
        {
            EnemyID = (SogEnemy)reader.ReadInt32();
        }
    }
}