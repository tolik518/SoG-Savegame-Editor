using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SoG_SGreader.Serialization;
using SoG_SGreader.Wrapper;

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
            writer.Write(MagicByte);
            
            // Equipment
            Equip.Serialize(writer);
            
            // Style (partial)
            writer.Write(Style.Bodytype);
            writer.Write(Style.Hair);
            writer.Write((int)Style.Weapon);
            writer.Write((int)Style.Shield);
            writer.Write((int)Style.Armor);
            writer.Write((int)Style.Shoes);
            writer.Write((int)Style.Accessory1);
            writer.Write((int)Style.Accessory2);
            writer.Write((int)Style.Hat);
            writer.Write((int)Style.Facegear);
            writer.Write((int)Style.Weapon);
            writer.Write((int)Style.Shield);
            writer.Write(Style.HatHidden);
            writer.Write(Style.FacegearHidden);
            
            // Last equipped items
            writer.Write(LastTwoHander);
            writer.Write(LastOneHander);
            writer.Write(LastBow);
            
            // Quickslots
            writer.Write(Quickslots.Count);
            foreach (var quickslot in Quickslots)
            {
                if (quickslot.GetType() == typeof(SogItem))
                {
                    writer.Write((byte)1);
                    writer.Write((int)quickslot);
                }
                else if (quickslot.GetType() == typeof(SogSkill))
                {
                    writer.Write((byte)2);
                    writer.Write((ushort)quickslot);
                }
                else
                {
                    writer.Write((byte)0);
                    writer.Write((int)0);
                }
            }
            
            // Nickname
            writer.Write(Nickname);
            
            // Inventory
            BinarySerializer.SerializeList(writer, Inventory, (w, item) => item.Serialize(w));
            writer.Write(PickupNumberPool);
            
            // Merchant items
            BinarySerializer.SerializeList(writer, MerchantItems, (w, item) => item.Serialize(w));
            
            // NG Plus and Pins
            writer.Write(NGPlus);
            BinarySerializer.SerializeList(writer, PinsEquipped, (w, pin) => w.Write((ushort)pin), (w, count) => w.Write((byte)count));
            BinarySerializer.SerializeList(writer, PinsOnShelf, (w, pin) => w.Write((ushort)pin), (w, count) => w.Write((byte)count));
            BinarySerializer.SerializeList(writer, PinsSeen, (w, pin) => w.Write((ushort)pin), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, PinsLatest, (w, pin) => w.Write((ushort)pin), (w, count) => w.Write((ushort)count));
            
            // Cards
            BinarySerializer.SerializeList(writer, Cards, (w, card) => {
                w.Write((int)card.Key.CardID);
                w.Write(card.Value);
            });
            
            // Treasure maps and found
            BinarySerializer.SerializeList(writer, TreasureMaps, (w, map) => map.Serialize(w));
            BinarySerializer.SerializeList(writer, TreasureFound, (w, found) => found.Serialize(w));
            
            // Skills
            BinarySerializer.SerializeList(writer, Skills, (w, skill) => skill.Serialize(w));
            BinarySerializer.SerializeList(writer, SkillsOverLeveling, (w, skill) => skill.Serialize(w));
            
            // Level and experience
            writer.Write(Level);
            writer.Write(ExpCurrent);
            writer.Write(ExpUnknown0);
            writer.Write(ExpUnknown1);
            writer.Write(SkillTalentPoints);
            writer.Write(SkillSilverPoints);
            writer.Write(SkillGoldPoints);
            writer.Write(Cash);
            
            // Pets
            BinarySerializer.SerializeList(writer, Pets, (w, pet) => pet.Serialize(w), (w, count) => w.Write((byte)count));
            writer.Write(PetsSelected);
            writer.Write(PetHidden);
            
            // Quests and enemies
            BinarySerializer.SerializeList(writer, Quests, (w, quest) => quest.Serialize(w), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, EnemiesSeen, (w, enemy) => enemy.Serialize(w), (w, count) => w.Write((ushort)count));
            
            // Unknown variables
            writer.Write((ushort)(UnknownVariables02.Count / 16));
            foreach (var unknownVar in UnknownVariables02)
            {
                unknownVar.Serialize(writer);
            }
            
            writer.Write(RobinBowHighscore);
            
            // Trophies and seen/crafted items
            BinarySerializer.SerializeList(writer, Trophies, (w, trophy) => trophy.Serialize(w), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, ItemsSeen, (w, item) => item.Serialize(w), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, ItemsCrafted, (w, item) => item.Serialize(w), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, FishCaught, (w, fish) => fish.Serialize(w), (w, count) => w.Write((ushort)count));
            BinarySerializer.SerializeList(writer, KilledEnemies, (w, enemy) => enemy.Serialize(w), (w, count) => w.Write((ushort)count));
            
            // Potions
            writer.Write(PotionsMax);
            writer.Write(PotionsEquipped);
            foreach (var potion in Potions)
            {
                potion.Serialize(writer);
            }
            
            // Birthday and other data
            writer.Write(BirthdayMonth);
            writer.Write(BirthdayDay);
            writer.Write(UniquePlayerId);
            writer.Write(LastAutosave);
            writer.Write(SaveUnknown);
            writer.Write(PlayTimeTotal);
            writer.Write(PhaseShiftStuff);
            
            // Character flags and flags
            BinarySerializer.SerializeList(writer, CharacterFlags, (w, flag) => flag.Serialize(w), (w, count) => w.Write((short)count));
            BinarySerializer.SerializeList(writer, Flags, (w, flag) => flag.Serialize(w), (w, count) => w.Write((short)count));
            
            // House styles
            BinarySerializer.SerializeList(writer, HouseStyles, (w, style) => style.Serialize(w), (w, count) => w.Write((byte)count));
            
            // Continue with remaining style properties
            writer.Write(Style.HairColor);
            writer.Write(Style.SkinColor);
            writer.Write(Style.PonchoColor);
            writer.Write(Style.ShirtColor);
            writer.Write(Style.PantsColor);
            writer.Write(Style.Sex);
        }

        public void Deserialize(BinaryReader reader)
        {
            MagicByte = reader.ReadInt32();
            
            // Check for old save game format
            if (MagicByte < 136)
            {
                throw new Exception("This appears to be a an old savegame. Please use the SoG Savegame Editor v0.8.2 for that savegame.");
            }
            
            // Equipment
            Equip.Deserialize(reader);
            
            // Style (partial)
            Style.Bodytype = reader.ReadChar();
            Style.Hair = reader.ReadInt32();
            Style.Weapon = (SogItem)reader.ReadInt32();
            Style.Shield = (SogItem)reader.ReadInt32();
            Style.Armor = (SogItem)reader.ReadInt32();
            Style.Shoes = (SogItem)reader.ReadInt32();
            Style.Accessory1 = (SogItem)reader.ReadInt32();
            Style.Accessory2 = (SogItem)reader.ReadInt32();
            Style.Hat = (SogItem)reader.ReadInt32();
            Style.Facegear = (SogItem)reader.ReadInt32();
            Style.Weapon = (SogItem)reader.ReadInt32();
            Style.Shield = (SogItem)reader.ReadInt32();
            Style.HatHidden = reader.ReadBoolean();
            Style.FacegearHidden = reader.ReadBoolean();
            
            // Last equipped items
            LastTwoHander = reader.ReadInt32();
            LastOneHander = reader.ReadInt32();
            LastBow = reader.ReadInt32();
            
            // Quickslots
            var quickslotCount = reader.ReadInt32();
            Quickslots = new List<object>(quickslotCount);
            for (int i = 0; i < quickslotCount; i++)
            {
                var quickslotType = reader.ReadByte();
                if (quickslotType == 1)
                {
                    Quickslots.Add((SogItem)reader.ReadInt32());
                }
                else if (quickslotType == 2)
                {
                    Quickslots.Add((SogSkill)reader.ReadUInt16());
                }
                else
                {
                    reader.ReadInt32(); // Skip unknown data
                    Quickslots.Add(null);
                }
            }
            
            // Nickname
            Nickname = reader.ReadString();
            
            // Inventory
            Inventory = BinarySerializer.DeserializeList(reader, r => { var item = new Item(); item.Deserialize(r); return item; });
            PickupNumberPool = reader.ReadUInt32();
            
            // Merchant items
            MerchantItems = BinarySerializer.DeserializeList(reader, r => { var item = new MerchantItem(); item.Deserialize(r); return item; });
            
            // NG Plus and Pins
            NGPlus = reader.ReadByte();
            PinsEquipped = BinarySerializer.DeserializeList(reader, r => (SogPin)r.ReadUInt16(), r => r.ReadByte());
            PinsOnShelf = BinarySerializer.DeserializeList(reader, r => (SogPin)r.ReadUInt16(), r => r.ReadByte());
            PinsSeen = BinarySerializer.DeserializeList(reader, r => (SogPin)r.ReadUInt16(), r => r.ReadUInt16());
            PinsLatest = BinarySerializer.DeserializeList(reader, r => (SogPin)r.ReadUInt16(), r => r.ReadUInt16());
            
            // Cards
            Cards = BinarySerializer.DeserializeList(reader, r => new KeyValuePair<Card, ushort>(
                new Card { CardID = (SogEnemy)r.ReadInt32() },
                r.ReadUInt16()
            ));
            
            // Treasure maps and found
            TreasureMaps = BinarySerializer.DeserializeList(reader, r => { var map = new TreasureMap(); map.Deserialize(r); return map; });
            TreasureFound = BinarySerializer.DeserializeList(reader, r => { var found = new TreasureFound(); found.Deserialize(r); return found; });
            
            // Skills
            Skills = BinarySerializer.DeserializeList(reader, r => { var skill = new Skill(); skill.Deserialize(r); return skill; });
            SkillsOverLeveling = BinarySerializer.DeserializeList(reader, r => { var skill = new Skill(); skill.Deserialize(r); return skill; });
            
            // Level and experience
            Level = reader.ReadInt16();
            ExpCurrent = reader.ReadInt32();
            ExpUnknown0 = reader.ReadInt32();
            ExpUnknown1 = reader.ReadInt32();
            SkillTalentPoints = reader.ReadInt16();
            SkillSilverPoints = reader.ReadInt16();
            SkillGoldPoints = reader.ReadInt16();
            Cash = reader.ReadInt32();
            
            // Pets
            Pets = BinarySerializer.DeserializeList(reader, r => { var pet = new Pet(); pet.Deserialize(r); return pet; }, r => r.ReadByte());
            PetsSelected = reader.ReadInt32();
            PetHidden = reader.ReadByte();
            
            // Quests and enemies
            Quests = BinarySerializer.DeserializeList(reader, r => { var quest = new Quest(); quest.Deserialize(r); return quest; }, r => r.ReadUInt16());
            EnemiesSeen = BinarySerializer.DeserializeList(reader, r => { var enemy = new Enemy(); enemy.Deserialize(r); return enemy; }, r => r.ReadUInt16());
            
            // Unknown variables
            var unknownCount = reader.ReadUInt16() * 16;
            UnknownVariables02 = new List<UnknownVariable02>(unknownCount);
            for (int i = 0; i < unknownCount; i++)
            {
                var unknownVar = new UnknownVariable02();
                unknownVar.Deserialize(reader);
                UnknownVariables02.Add(unknownVar);
            }
            
            RobinBowHighscore = reader.ReadInt32();
            
            // Trophies and seen/crafted items
            Trophies = BinarySerializer.DeserializeList(reader, r => { var trophy = new Trophy(); trophy.Deserialize(r); return trophy; }, r => r.ReadUInt16());
            ItemsSeen = BinarySerializer.DeserializeList(reader, r => { var item = new ItemSeen(); item.Deserialize(r); return item; }, r => r.ReadUInt16());
            ItemsCrafted = BinarySerializer.DeserializeList(reader, r => { var item = new ItemCrafted(); item.Deserialize(r); return item; }, r => r.ReadUInt16());
            FishCaught = BinarySerializer.DeserializeList(reader, r => { var fish = new FishCaught(); fish.Deserialize(r); return fish; }, r => r.ReadUInt16());
            KilledEnemies = BinarySerializer.DeserializeList(reader, r => { var enemy = new KilledEnemy(); enemy.Deserialize(r); return enemy; }, r => r.ReadUInt16());
            
            // Potions
            PotionsMax = reader.ReadByte();
            PotionsEquipped = reader.ReadByte();
            Potions = new List<Potion>(PotionsMax);
            for (int i = 0; i < PotionsMax; i++)
            {
                var potion = new Potion();
                potion.Deserialize(reader);
                Potions.Add(potion);
            }
            
            // Birthday and other data
            BirthdayMonth = reader.ReadInt32();
            BirthdayDay = reader.ReadInt32();
            UniquePlayerId = reader.ReadUInt32();
            LastAutosave = reader.ReadInt32();
            SaveUnknown = reader.ReadInt32();
            PlayTimeTotal = reader.ReadInt32();
            PhaseShiftStuff = reader.ReadByte();
            
            // Character flags and flags
            CharacterFlags = BinarySerializer.DeserializeList(reader, r => { var flag = new CharacterFlags(); flag.Deserialize(r); return flag; }, r => r.ReadInt16());
            Flags = BinarySerializer.DeserializeList(reader, r => { var flag = new Flag(); flag.Deserialize(r); return flag; }, r => r.ReadInt16());
            
            // House styles
            HouseStyles = BinarySerializer.DeserializeList(reader, r => { var style = new HouseStyle(); style.Deserialize(r); return style; }, r => r.ReadByte());
            
            // Continue with remaining style properties
            Style.HairColor = reader.ReadInt32();
            Style.SkinColor = reader.ReadInt32();
            Style.PonchoColor = reader.ReadInt32();
            Style.ShirtColor = reader.ReadInt32();
            Style.PantsColor = reader.ReadInt32();
            Style.Sex = reader.ReadInt32();
        }
    }
}
