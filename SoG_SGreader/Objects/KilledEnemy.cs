using System.IO;
using SoG_SGreader.Serialization;

namespace SoG_SGreader
{
    public class KilledEnemy : IBinarySerializable
    {
        public SogEnemy EnemyID { get; set; }
        public int KillCount { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)EnemyID);
            writer.Write(KillCount);
        }

        public void Deserialize(BinaryReader reader)
        {
            EnemyID = (SogEnemy)reader.ReadInt32();
            KillCount = reader.ReadInt32();
        }
    }
}