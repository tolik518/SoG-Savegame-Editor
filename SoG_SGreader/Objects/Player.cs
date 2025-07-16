using System;
using System.Collections.Generic;
using System.Linq;

namespace SoG_SGreader
{
    public class Player
    {
        [BinaryOrder(1)]
        public int MagicByte { get; set; }
        
        [BinaryOrder(2)]
        public Equip Equip { get; set; } = new Equip();
        
        [BinaryOrder(3)]
        public Style Style { get; set; } = new Style();
        
        [BinaryOrder(4)]
        public int LastTwoHander { get; set; }
        
        [BinaryOrder(5)]
        public int LastOneHander { get; set; }
        
        [BinaryOrder(6)]
        public int LastBow { get; set; }
        
        [BinaryOrder(7)]
        public List<object> Quickslots { get; set; } = new List<object>();
        
        [BinaryOrder(8)]
        public byte NicknameLength { get; set; }
        
        [BinaryOrder(9)]
        public string Nickname { get; set; }
        
        [BinaryOrder(10)]
        public int ItemsCount { get; set; }
        
        [BinaryOrder(11)]
        public List<Item> Inventory { get; set; }
        
        [BinaryOrder(12)]
        public uint PickupNumberPool { get; set; }
        
        [BinaryOrder(13)]
        public int MerchantItemsCount { get; set; }
        
        [BinaryOrder(14)]
        public List<MerchantItem> MerchantItems { get; set; }

        [BinaryOrder(15)]
        public byte NGPlus { get; set; }
        
        [BinaryOrder(16)]
        public byte PinsEquippedCount { get; set; }
        
        [BinaryOrder(17)]
        public List<SogPin> PinsEquipped { get; set; }
        
        [BinaryOrder(18)]
        public byte PinsOnShelfCount { get; set; }
        
        [BinaryOrder(19)]
        public List<SogPin> PinsOnShelf { get; set; }
        
        [BinaryOrder(20)]
        public ushort PinsSeenCount { get; set; }
        
        [BinaryOrder(21)]
        public List<SogPin> PinsSeen { get; set; }
        
        [BinaryOrder(22)]
        public ushort PinsLatestCount { get; set; }
        
        [BinaryOrder(23)]
        public List<SogPin> PinsLatest { get; set; }

        [BinaryOrder(24)]
        public int CardsCount { get; set; }
        
        [BinaryOrder(25)]
        public List<KeyValuePair<Card, ushort>> Cards { get; set; }
        
        [BinaryOrder(26)]
        public int TreasureMapsCount { get; set; }
        
        [BinaryOrder(27)]
        public List<TreasureMap> TreasureMaps { get; set; }
        
        [BinaryOrder(28)]
        public int TreasureFoundCount { get; set; }
        
        [BinaryOrder(29)]
        public List<TreasureFound> TreasureFound { get; set; }
        
        [BinaryOrder(30)]
        public int SkillsCount { get; set; }
        
        [BinaryOrder(31)]
        public List<Skill> Skills { get; set; }
        
        [BinaryOrder(32)]
        public int SkillsOverLevelingCount { get; set; }
        
        [BinaryOrder(33)]
        public List<Skill> SkillsOverLeveling { get; set; }
        
        [BinaryOrder(34)]
        public short Level { get; set; }
        
        [BinaryOrder(35)]
        public int ExpCurrent { get; set; }
        
        [BinaryOrder(36)]
        public int ExpUnknown0 { get; set; }
        
        [BinaryOrder(37)]
        public int ExpUnknown1 { get; set; }
        
        [BinaryOrder(38)]
        public short SkillTalentPoints { get; set; }
        
        [BinaryOrder(39)]
        public short SkillSilverPoints { get; set; }
        
        [BinaryOrder(40)]
        public short SkillGoldPoints { get; set; }
        
        [BinaryOrder(41)]
        public int Cash { get; set; }
        
        [BinaryOrder(42)]
        public byte PetsCount { get; set; }
        
        [BinaryOrder(43)]
        public List<Pet> Pets { get; set; }
        
        [BinaryOrder(44)]
        public int PetsSelected { get; set; }
        
        [BinaryOrder(45)]
        public byte PetHidden { get; set; }
        
        [BinaryOrder(46)]
        public ushort QuestsCount { get; set; }
        
        [BinaryOrder(47)]
        public List<Quest> Quests { get; set; }
        
        [BinaryOrder(48)]
        public ushort EnemiesSeenCount { get; set; }
        
        [BinaryOrder(49)]
        public List<Enemy> EnemiesSeen { get; set; }
        
        [BinaryOrder(50)]
        public ushort UnknownVariable02Count { get; set; }     //something to do with challenges?
        
        [BinaryOrder(51)]
        public List<UnknownVariable02> UnknownVariables02 { get; set; }
        
        [BinaryOrder(52)]
        public int RobinBowHighscore { get; set; }
        
        [BinaryOrder(53)]
        public ushort TrophiesCount { get; set; }

        [BinaryOrder(54)]
        public List<Trophy> Trophies { get; set; }
        
        [BinaryOrder(55)]
        public ushort ItemsSeenCount { get; set; }
        
        [BinaryOrder(56)]
        public List<ItemSeen> ItemsSeen { get; set; }
        
        [BinaryOrder(57)]
        public ushort ItemsCraftedCount { get; set; }
        
        [BinaryOrder(58)]
        public List<ItemCrafted> ItemsCrafted { get; set; }
        
        [BinaryOrder(59)]
        public ushort FishiesCaughtCount { get; set; }
        
        [BinaryOrder(60)]
        public List<FishCaught> FishCaught { get; set; }
        
        [BinaryOrder(61)]
        public ushort KilledEnemiesCount { get; set; }
        
        [BinaryOrder(62)]
        public List<KilledEnemy> KilledEnemies { get; set; }
        
        [BinaryOrder(63)]
        public byte PotionsMax { get; set; }
        
        [BinaryOrder(64)]
        public byte PotionsEquipped { get; set; }
        
        [BinaryOrder(65)]
        public List<Potion> Potions { get; set; }
        
        [BinaryOrder(66)]
        public int BirthdayMonth { get; set; }
        
        [BinaryOrder(67)]
        public int BirthdayDay { get; set; }
        
        [BinaryOrder(68)]
        public uint UniquePlayerId { get; set; }
        
        [BinaryOrder(69)]
        public int LastAutosave { get; set; }
        
        [BinaryOrder(70)]
        public int SaveUnknown { get; set; } // saving mechanism related
        
        [BinaryOrder(71)]
        public int PlayTimeTotal { get; set; } // saved in frames
        
        [BinaryOrder(72)]
        public byte PhaseShiftStuff { get; set; } //??
        
        [BinaryOrder(73)]
        public short CharacterFlagCount { get; set; }
        
        [BinaryOrder(74)]
        public List<CharacterFlags> CharacterFlags { get; set; }
        
        [BinaryOrder(75)]
        public short FlagsCount { get; set; }
        
        [BinaryOrder(76)]
        public List<Flag> Flags { get; set; }
        
        [BinaryOrder(77)]
        public byte HouseStylesCount { get; set; }
        
        [BinaryOrder(78)]
        public List<HouseStyle> HouseStyles { get; set; }
        
        internal byte GetSkillLevel(SogSkill skillId)
        {
            return Skills.FirstOrDefault(skill => skill.SkillID == skillId)?.SkillLevel ?? 0;
        }
        
        internal byte GetSkillLevel(Skill skill)
        {
            return Skills.FirstOrDefault(s => s.SkillID == skill.SkillID)?.SkillLevel ?? 0;
        }

        internal bool HasCard(SogEnemy sogEnemies)
        {
            return Cards.Any(pair => pair.Key.CardID == sogEnemies);
        }

        internal ushort GetCardCount(SogEnemy sogEnemies)
        {
            return Cards.FirstOrDefault(pair => pair.Key.CardID == sogEnemies).Value;
        }

        internal void RemoveCard(SogEnemy sogEnemies)
        {
            Cards.RemoveAll(pair => pair.Key.CardID == sogEnemies);
        }

        internal bool HasQuest(SogQuest sogQuests)
        {
            return Quests.Any(quest => quest.QuestID == sogQuests);
        }

        internal bool HasSeenEnemy(SogEnemy sogEnemies)
        {
            return EnemiesSeen.Any(enemy => enemy.EnemyID == sogEnemies);
        }

        internal bool HasFlag(SogFlag sogFlag)
        {
            return Flags.Any(flag => flag.FlagID == sogFlag);
        }

        internal bool HasMap(SogTreasureMap sogMap)
        {
            return TreasureMaps.Any(map => map.TreasureMapID == sogMap);
        }

        internal bool HasTrophy(SogTrophy sogTrophy)
        {
            return Trophies.Any(trophy => trophy.TrophyID == sogTrophy);
        }

        internal bool HasSeenItem(SogItem sogItem)
        {
            return ItemsSeen.Any(item => item.ItemID == sogItem);
        }

        internal bool HasCraftedItem(SogItem sogItem)
        {
            return ItemsCrafted.Any(item => item.ItemID == sogItem);
        }

        internal bool HasCaughtFish(SogItem sogItem)
        {
            return FishCaught.Any(fish => fish.FishID == sogItem);
        }
    }
}
