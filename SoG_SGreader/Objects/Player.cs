using System;
using System.Collections.Generic;
using System.Linq;
using SoG_SGreader.Serialization;
using System.IO;

namespace SoG_SGreader
{
    public class Player : IBinarySerializable
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
        public uint PickupNumberPool { get; set; }
        public int MerchantItemsCount { get; set; }
        public List<MerchantItem> MerchantItems;

        public byte NGPlus { get; set; }
        public byte PinsEquippedCount { get; set; }
        public List<SogPin> PinsEquipped;
        public byte PinsOnShelfCount { get; set; }
        public List<SogPin> PinsOnShelf;
        public ushort PinsSeenCount { get; set; }
        public List<SogPin> PinsSeen;
        public ushort PinsLatestCount { get; set; }
        public List<SogPin> PinsLatest;

        public int CardsCount { get; set; }
        public List<KeyValuePair<Card, ushort>> Cards;
        public int TreasureMapsCount { get; set; }
        public List<TreasureMap> TreasureMaps;
        public int TreasureFoundCount { get; set; }
        public List<TreasureFound> TreasureFound;
        public int SkillsCount { get; set; }
        public List<Skill> Skills;
        public int SkillsOverLevelingCount { get; set; }
        public List<Skill> SkillsOverLeveling;
        public short Level { get; set; }
        public int ExpCurrent { get; set; }
        public int ExpUnknown0 { get; set; }
        public int ExpUnknown1 { get; set; }
        public short SkillTalentPoints { get; set; }
        public short SkillSilverPoints { get; set; }
        public short SkillGoldPoints { get; set; }
        public int Cash { get; set; }
        public byte PetsCount { get; set; }
        public List<Pet> Pets;
        public int PetsSelected { get; set; }
        public byte PetHidden { get; set; }
        public ushort QuestsCount { get; set; }
        public List<Quest> Quests;
        public ushort EnemiesSeenCount { get; set; }
        public List<Enemy> EnemiesSeen;
        public ushort UnknownVariable02Count { get; set; }     //something to do with challenges?
        public List<UnknownVariable02> UnknownVariables02;
        public int RobinBowHighscore { get; set; }
        public ushort TrophiesCount { get; set; }

        public List<Trophy> Trophies;
        public ushort ItemsSeenCount { get; set; }
        public List<ItemSeen> ItemsSeen;
        public ushort ItemsCraftedCount { get; set; }
        public List<ItemCrafted> ItemsCrafted;
        public ushort FishiesCaughtCount { get; set; }
        public List<FishCaught> FishCaught;
        public ushort KilledEnemiesCount { get; set; }
        public List<KilledEnemy> KilledEnemies;
        public byte PotionsMax { get; set; }
        public byte PotionsEquipped { get; set; }
        public List<Potion> Potions;
        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; set; }
        public uint UniquePlayerId { get; set; }
        public int LastAutosave { get; set; }
        public int SaveUnknown { get; set; } // saving mechanism related
        public int PlayTimeTotal { get; set; } // saved in frames
        public byte PhaseShiftStuff { get; set; } //??
        public short CharacterFlagCount { get; set; }
        public List<CharacterFlags> CharacterFlags;
        public short FlagsCount { get; set; }
        public List<Flag> Flags;
        public byte HouseStylesCount { get; set; }
        public List<HouseStyle> HouseStyles;
        
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

        public void Serialize(BinaryWriter writer)
        {
            // TODO: Implement serialization logic matching the original DataWriter/DataReader order
            // For now, throw to indicate not implemented
            throw new NotImplementedException();
        }

        public void Deserialize(BinaryReader reader)
        {
            // TODO: Implement deserialization logic matching the original DataReader order
            // For now, throw to indicate not implemented
            throw new NotImplementedException();
        }
    }
}
