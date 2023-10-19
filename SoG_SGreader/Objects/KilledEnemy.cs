namespace SoG_SGreader
{
    public class KilledEnemy
    {
        public int EnemyID { get; set; }
        public int KillCount { get; set; }
        public KilledEnemy(int enemyId, int killCount)
        {
            this.EnemyID = enemyId;
            this.KillCount = killCount;
        }

    }
}