namespace SoG_SGreader
{
    public class Card
    {
        public SogEnemies CardID { get; set; }

        public Card(SogEnemies cardId)
        {
            this.CardID = cardId;
        }
    }
}