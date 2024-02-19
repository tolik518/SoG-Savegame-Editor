namespace SoG_SGreader
{
    [System.Serializable]
    public class Enemy
    {
        public int EnemyID { get; set; }

        public Enemy(int enemyId)
        {
            this.EnemyID = enemyId;
        }
    }
}