using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SoG_SGreader
{
    public partial class Player
    {
        public int MagicByte { get; set; }
        public int LastTwoHander { get; set; }
        public int LastOneHander { get; set; }
        public int LastBow { get; set; }
        
        public List<object> Quickslots = new List<object>();
        public int NicknameLength { get; set; }
        public string Nickname { get; set; }
        
        public Equip Equip = new Equip();
        public Style Style = new Style();
        public int ItemsCount { get; set; }
        public List<Item> Inventory;
        public int UnknownVariable0 { get; set; }
        public int MerchantItemsCount { get; set; }
        public List<MerchantItem> MerchantItems;
        public int CardsCount { get; set; }
        public List<Card> Cards;
        public int TreasureMapsCount { get; set; }
        public List<TreasureMap> TreasureMaps;
        public int UnknownVariable01Count { get; set; }
        public List<UnknownVariable01> UnknownVariables01;
        public int SkillsCount { get; set; }
        public List<Skill> Skills;
        public Int16 Level { get; set; }
        public int ExpCurrent { get; set; }
        public int ExpUnknown0 { get; set; }
        public int ExpUnknown1 { get; set; }
        public Int16 SkillTalentPoints { get; set; }
        public Int16 SkillSilverPoints { get; set; }
        public Int16 SkillGoldPoints { get; set; }
        public int Cash { get; set; }
        public byte PetsCount { get; set; }
        public List<Pet> Pets;
        public int PetsSelected { get; set; }
        public byte PetHidden { get; set; }
        public UInt16 QuestsCount { get; set; }
        public List<Quest> Quests;
        public UInt16 EnemiesMetCount { get; set; }
        public List<Enemy> Enemies;
        public UInt16 UnknownVariable02Count { get; set; }     //something to do with challenges?
        public List<UnknownVariable02> UnknownVariables02;
        public int RobinBowHighscore { get; set; }
        public UInt16 UnknownVariable03Count { get; set; }    //trophies?

        public List<UnknownVariable03> UnknownVariables03;
        public UInt16 ItemsMetCount { get; set; }
        public List<ItemsSeen> ItemsMet;
        public UInt16 ItemsCraftedCount { get; set; }
        public List<ItemCrafted> ItemsCrafted;
        public UInt16 FishiesCaughtCount { get; set; }
        public List<FishCaught> FishiesCaught;
        public UInt16 KilledEnemiesCount { get; set; }
        public List<KilledEnemy> KilledEnemies;
        public byte PotionsMax { get; set; }
        public byte PotionsEquipped { get; set; }
        public List<Potion> Potions;
        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; set; }
        public uint UniquePlayerId { get; set; }
        public int UnknownVariable04 { get; set; } // saving mechanism related
        public int UnknownVariable05 { get; set; } // saving mechanism related
        public int PlayTimeTotal { get; set; } // saved in frames
        public byte UnknownVariable06 { get; set; } //??
        public Int16 UnknownVariable07Count { get; set; }
        public List<UnknownVariable07> UnknownVariables07;
        public Int16 FlagsCount { get; set; }
        public List<Flag> Flags;
        public byte HouseStylesCount { get; set; }
        public List<HouseStyle> Houses;
        
        public byte GetSkillLevel(SogSkills skillId)
        {
            return Skills.FirstOrDefault(skill => skill.SkillID == skillId)?.SkillLevel ?? 0;
        }
        
        public byte GetSkillLevel(Skill skill)
        {
            return Skills.FirstOrDefault(s => s.SkillID == skill.SkillID)?.SkillLevel ?? 0;
        }

        internal bool HasCard(SogEnemies sogEnemies)
        {
            return Cards.Any(card => card.CardID == sogEnemies);
        }

        internal void AddCard(SogEnemies sogEnemies)
        {
            // add card to player, dont add duplicates
            if (!HasCard(sogEnemies))
            {
                Cards.Add(new Card(sogEnemies));
            }
        }

        internal void RemoveCard(SogEnemies sogEnemies)
        {
            // remove card from player, if it exists
            if (HasCard(sogEnemies))
            {
                Cards.RemoveAll(card => card.CardID == sogEnemies);
            }
        }
    }
}
