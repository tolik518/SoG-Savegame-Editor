using System;
using System.Collections.Generic;
using System.Linq;

namespace SoG_SGreader
{
    public class Sog_Player
    {
        public Equip equip = new Equip();
        public Style style = new Style();

        public List<Item> inventory;

        public List<MerchantItems> merchantItems;
        public List<Card> cards;
        public List<TreasureMap> TreasureMaps;
        public List<UnknownVariable01> UnknownVariables01;
        public List<Skill> Skills;
        public List<Pet> Pets;


        public int magicByte;
        public class Equip
        {
            public int Hat { get; set; }
            public int Facegear { get; set; }
            public int Weapon { get; set; }
            public int Shield { get; set; }
            public int Armor { get; set; }
            public int Shoes { get; set; }
            public int Accessory1 { get; set; }
            public int Accessory2 { get; set; }
        }
        public class Style
        {
            public char Bodytype { get; set; }
            public int Hair { get; set; }
            public int Hat { get; set; }
            public int Facegear { get; set; }
            public int Weapon { get; set; }
            public int Shield { get; set; }
            public bool HatHidden { get; set; }
            public bool FacegearHidden { get; set; }
            public int HairColor { get; set; }
            public int SkinColor { get; set; }
            public int PonchoColor { get; set; }
            public int ShirtColor { get; set; }
            public int PantsColor { get; set; }
            public int Sex { get; set; }
        }
        public int LastTwoHander { get; set; }
        public int LastOneHander { get; set; }
        public int LastBow { get; set; }
        public List<object> quickslots = new List<object>();
        public int NicknameLength { get; set; }
        public string Nickname { get; set; }
        public int InventorySize { get; set; }
        public class Item
        {
            public Item(Sog_Items _ItemID, int _ItemCount, UInt32 _ItemPos)
            {
                this.ItemID = _ItemID;
                this.ItemCount = _ItemCount;
                this.ItemPos = _ItemPos;
            }
            public Sog_Items ItemID { get; set; }
            public int ItemCount { get; set; }
            public UInt32 ItemPos { get; set; }

        }

        public int UnknownVariable0 { get; set; }
        public int MerchantItemsCount { get; set; }
        public class MerchantItems
        {
            public MerchantItems(Sog_Items _ItemID, int _ItemCount)
            {
                this.ItemID = _ItemID;
                this.ItemCount = _ItemCount;
            }
            public Sog_Items ItemID { get; set; }
            public int ItemCount { get; set; }
        }

        public int CardsCount { get; set; }
        public class Card
        {
            public Card(int _CardId)
            {
                this.CardID = _CardId;
            }
            public int CardID { get; set; }
        }

        public int TreasureMapsCount { get; set; }
        public class TreasureMap
        {
            public TreasureMap(Int16 _TreasureMapID)
            {
                this.TreasureMapID = _TreasureMapID;
            }
            public Int16 TreasureMapID { get; set; }
        }

        public int UnknownVariable01Count { get; set; }
        public class UnknownVariable01
        {
            public UnknownVariable01(Int16 _UnknownVariable01ID)
            {
                this.UnknownVariable01ID = _UnknownVariable01ID;
            }
            public Int16 UnknownVariable01ID { get; set; }
        }

        public int SkillsCount { get; set; }
        public class Skill
        {
            public Skill(Sog_Spells _SkillID, byte _SkillLevel)
            {
                this.SkillID = _SkillID;
                this.SkillLevel = _SkillLevel;
            }
            public Sog_Spells SkillID { get; set; }
            public byte SkillLevel { get; set; }
        }

        public Int16 Level { get; set; }
        public int EXPCurrent { get; set; }
        public int EXPUnknown0 { get; set; }
        public int EXPUnknown1 { get; set; }

        public Int16 SkillTalentPoints { get; set; }
        public Int16 SkillSilverPoints { get; set; }
        public Int16 SkillGoldPoints { get; set; }
        public int Cash { get; set; }

        public byte PetsCount { get; set; }
        public class Pet
        {

            public int Type1 { get; set; }
            public int Type2 { get; set; }
            public string Nickname { get; set; }
            public byte Level { get; set; }
            public byte Skin { get; set; }

            public UInt16 StatHealth { get; set; }
            public UInt16 StatEnergy { get; set; }
            public UInt16 StatDamage { get; set; }
            public UInt16 StatCrit { get; set; }
            public UInt16 StatSpeed { get; set; }

            public UInt16 StatProgressHealth { get; set; }
            public UInt16 StatProgressEnergy { get; set; }
            public UInt16 StatProgressDamage { get; set; }
            public UInt16 StatProgressCrit { get; set; }
            public UInt16 StatProgressSpeed { get; set; }

        }
        public int PetsSelected { get; set; }

        public byte PetHidden { get; set; }

        //                             //
        //                             //
        //     Not implemented yet     //
        //                             //
        //                             //
        //                             //

        /// <summary>
        /// Probably Quest, not known exactly
        /// </summary>
        public UInt16 QuestsCount { get; set; }
        public class Quest
        {
            public Quest(Int16 _QuestID)
            {
                this.QuestID = _QuestID;
            }
            public Int16 QuestID { get; set; }
        }

        public UInt16 EnemiesMetCount { get; set; }
        public class Enemy
        {
            public Enemy(Int16 _EnemyID)
            {
                this.EnemyID = _EnemyID;
            }
            public int EnemyID { get; set; }
        }

        public UInt16 UnknownVariable02Count { get; set; }     //something to do with challenges?
        public class UnknownVariable02
        {
            public UnknownVariable02(byte[] _UnknownBytearray)
            {
                this.UnknownBytearray = _UnknownBytearray;
            }
            public byte[] UnknownBytearray { get; set; }
        }

        public int RobinBowHighscore { get; set; }

        public UInt16 UnknownVariable03Count { get; set; }    //trophies?
        public class UnknownVariable03
        {
            public UnknownVariable03(ushort _UnknownVariable)
            {
                this.UnknownVariable = _UnknownVariable;
            }
            public ushort UnknownVariable { get; set; }
        }

        public UInt16 ItemsMetCount { get; set; }
        public class ItemMet
        {
            public ItemMet(Sog_Player.Item _ItemID)
            {
                this.ItemID = _ItemID;
            }
            public Sog_Player.Item ItemID { get; set; }
        }

        public UInt16 CraftedItemsCount { get; set; }
        public class CraftedItem
        {
            public CraftedItem(Sog_Player.Item _ItemID)
            {
                this.ItemID = _ItemID;
            }
            public Sog_Player.Item ItemID { get; set; }
        }

        public UInt16 FishCaughtCount { get; set; }
        public class FishCaught
        {
            public FishCaught(Sog_Player.Item _FishID)
            {
                this.FishID = _FishID;
            }
            public Sog_Player.Item FishID { get; set; }
        }

        public UInt16 EnemiesSlaughteredCount { get; set; }
        public class EnemieSlaughtered
        {
            public EnemieSlaughtered(int _EnemyID)
            {
                this.EnemyID = _EnemyID;
            }
            public int EnemyID { get; set; }
            public int KillCount { get; set; }
        }

        public byte PotionsMax { get; set; }
        public byte PotionsEquipped { get; set; }
        public class Potion
        {
            public Potion(int _PotionID)
            {
                this.PotionID = _PotionID;
            }
            public int PotionID { get; set; }
        }

        public int BirthdayMonth { get; set; }
        public int BirthdayDay { get; set; }
        public int UniquePlayerID { get; set; }
        public int UnknownVariable04 { get; set; } // saving mechanism related
        public int UnknownVariable05 { get; set; } // saving mechanism related
        public int PlayTimeTotal { get; set; } // saved in frames
        public byte UnknownVariable06 { get; set; } //??

        public Int16 UnknownVariable07length { get; set; }
        public class UnknownVariable07
        {
            public UnknownVariable07(string _UnknownString, float _UnknownFloat)
            {
                this.UnknownString = _UnknownString;
                this.UnknownFloat = _UnknownFloat;
            }
            public string UnknownString { get; set; }
            public float UnknownFloat { get; set; }
        }

        public Int16 FlagsCount { get; set; }
        public class Flag
        {
            public Flag(UInt16 _FlagID) 
            {
                this.FlagID = _FlagID;
            }
            public UInt16 FlagID { get; set; }
        }

        public byte HouseStylesCount { get; set; }
        public byte HouseStlesUNKNOWN { get; set; }
        public class HouseStyle
        {
            public HouseStyle(byte _HouseStyleNumber, int _HouseStyleLength, byte[] _HouseStyleBytes)
            {
                this.HouseStyleNumber = _HouseStyleNumber;
                this.HouseStyleLength = _HouseStyleLength;
                this.HouseStyleBytes = _HouseStyleBytes;
            }
            public byte HouseStyleNumber { get; set; } //style 0, 1, 2 etc 
            public int HouseStyleLength { get; set; }
            public byte[] HouseStyleBytes { get; set; }
        }


        public byte[] scrap;
    }
}
