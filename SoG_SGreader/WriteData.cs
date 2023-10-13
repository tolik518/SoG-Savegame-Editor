using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sog_SGreader
{
    public partial class FrmMain
    {
        private void WriteData(string fileName)
        {

            using (BinaryWriter writeBinary = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                GetDataFromFields();
                writeBinary.Write((int)playerObject.MagicByte);
                writeBinary.Write((int)playerObject.equip.Hat);
                writeBinary.Write((int)playerObject.equip.Facegear);
                writeBinary.Write((char)playerObject.style.Bodytype);
                writeBinary.Write((int)playerObject.style.Hair);
                writeBinary.Write((int)playerObject.equip.Weapon);
                writeBinary.Write((int)playerObject.equip.Shield);
                writeBinary.Write((int)playerObject.equip.Armor);
                writeBinary.Write((int)playerObject.equip.Shoes);
                writeBinary.Write((int)playerObject.equip.Accessory1);
                writeBinary.Write((int)playerObject.equip.Accessory2);
                writeBinary.Write((int)playerObject.style.Hat);
                writeBinary.Write((int)playerObject.style.Facegear);
                writeBinary.Write((int)playerObject.style.Weapon);
                writeBinary.Write((int)playerObject.style.Shield);
                writeBinary.Write((bool)playerObject.style.HatHidden);
                writeBinary.Write((bool)playerObject.style.FacegearHidden);
                writeBinary.Write((int)playerObject.LastTwoHander);
                writeBinary.Write((int)playerObject.LastOneHander);
                writeBinary.Write((int)playerObject.LastBow);

                foreach (object quickslot in playerObject.quickslots)
                {
                    if (quickslot.GetType() == typeof(Sog_Items))
                    {
                        writeBinary.Write((byte)1);
                        writeBinary.Write((Int32)quickslot);
                    }
                    else if (quickslot.GetType() == typeof(Sog_Skills))
                    {
                        writeBinary.Write((byte)2);
                        writeBinary.Write((UInt16)quickslot);
                    }
                    else
                    {
                        writeBinary.Write((byte)0);
                    }
                }

                writeBinary.Write((byte)playerObject.style.HairColor);
                writeBinary.Write((byte)playerObject.style.SkinColor);
                writeBinary.Write((byte)playerObject.style.PonchoColor);
                writeBinary.Write((byte)playerObject.style.ShirtColor);
                writeBinary.Write((byte)playerObject.style.PantsColor);
                writeBinary.Write((byte)playerObject.style.Sex);
                writeBinary.Write((string)playerObject.Nickname);

                writeBinary.Write((int)playerObject.ItemsCount);
                for (int i = 0; i != playerObject.ItemsCount; i++)
                {
                    writeBinary.Write((Int32)playerObject.Inventory[i].ItemID);
                    writeBinary.Write((Int32)playerObject.Inventory[i].ItemCount);
                    writeBinary.Write((Int32)playerObject.Inventory[i].ItemPos);
                }

                writeBinary.Write((int)playerObject.UnknownVariable0);

                writeBinary.Write((int)playerObject.MerchantItemsCount);
                for (int i = 0; i != playerObject.MerchantItemsCount; i++)
                {
                    writeBinary.Write((int)playerObject.MerchantItems[i].ItemID);
                    writeBinary.Write((int)playerObject.MerchantItems[i].ItemCount);
                }

                writeBinary.Write((int)playerObject.CardsCount);
                for (int i = 0; i != playerObject.CardsCount; i++)
                {
                    writeBinary.Write((int)playerObject.Cards[i].CardID);
                }

                writeBinary.Write((int)playerObject.TreasureMapsCount);
                for (int i = 0; i != playerObject.TreasureMapsCount; i++)
                {
                    writeBinary.Write((Int16)playerObject.TreasureMaps[i].TreasureMapID);
                }

                writeBinary.Write((int)playerObject.UnknownVariable01Count);
                for (int i = 0; i != playerObject.UnknownVariable01Count; i++)
                {
                    writeBinary.Write((Int16)playerObject.UnknownVariables01[i].UnknownVariable01ID);
                }

                writeBinary.Write((int)playerObject.SkillsCount);
                for (int i = 0; i != playerObject.SkillsCount; i++)
                {
                    writeBinary.Write((Int16)playerObject.Skills[i].SkillID);
                    writeBinary.Write((byte)playerObject.Skills[i].SkillLevel);
                }

                writeBinary.Write((Int16)playerObject.Level);
                writeBinary.Write((int)playerObject.EXPCurrent);
                writeBinary.Write((int)playerObject.EXPUnknown0);
                writeBinary.Write((int)playerObject.EXPUnknown1);
                writeBinary.Write((Int16)playerObject.SkillTalentPoints);
                writeBinary.Write((Int16)playerObject.SkillSilverPoints);
                writeBinary.Write((Int16)playerObject.SkillGoldPoints);
                writeBinary.Write((int)playerObject.Cash);

                writeBinary.Write((byte)playerObject.PetsCount);
                for (int i = 0; i != playerObject.PetsCount; i++)
                {
                    writeBinary.Write((int)playerObject.Pets[i].Type1);
                    writeBinary.Write((int)playerObject.Pets[i].Type2);
                    writeBinary.Write((string)playerObject.Pets[i].Nickname);
                    writeBinary.Write((byte)playerObject.Pets[i].Level);
                    writeBinary.Write((byte)playerObject.Pets[i].Skin);

                    writeBinary.Write((UInt16)playerObject.Pets[i].StatHealth);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatEnergy);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatDamage);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatCrit);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatSpeed);

                    writeBinary.Write((UInt16)playerObject.Pets[i].StatProgressHealth);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatProgressEnergy);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatProgressDamage);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatProgressCrit);
                    writeBinary.Write((UInt16)playerObject.Pets[i].StatProgressSpeed);
                }

                writeBinary.Write((int)playerObject.PetsSelected);
                writeBinary.Write((byte)playerObject.PetHidden);

                writeBinary.Write((UInt16)playerObject.QuestsCount);
                for (int i = 0; i != playerObject.QuestsCount; i++)
                {
                    writeBinary.Write((UInt16)playerObject.Quests[i].QuestID);
                }

                writeBinary.Write((UInt16)playerObject.EnemiesMetCount);
                for (int i = 0; i != playerObject.EnemiesMetCount; i++)
                {
                    writeBinary.Write((UInt32)playerObject.Enemies[i].EnemyID);
                }

                writeBinary.Write((UInt16)(playerObject.UnknownVariable02Count / 16));
                for (int i = 0; i != playerObject.UnknownVariable02Count; i++)
                {
                    writeBinary.Write((byte)playerObject.UnknownVariables02[i].UnknownByte);
                }

                writeBinary.Write((int)playerObject.RobinBowHighscore);

                writeBinary.Write((UInt16)playerObject.UnknownVariable03Count);
                for (int i = 0; i != playerObject.UnknownVariable03Count; i++)
                {
                    writeBinary.Write((UInt16)playerObject.UnknownVariables03[i].UnknownVariable);
                }

                writeBinary.Write((UInt16)playerObject.ItemsMetCount);
                for (int i = 0; i != playerObject.ItemsMetCount; i++)
                {
                    writeBinary.Write((int)playerObject.ItemsMet[i].ItemID);
                }

                writeBinary.Write((UInt16)playerObject.ItemsCraftedCount);
                for (int i = 0; i != playerObject.ItemsCraftedCount; i++)
                {
                    writeBinary.Write((int)playerObject.ItemsCrafted[i].ItemID);
                }

                writeBinary.Write((UInt16)playerObject.FishiesCaughtCount);
                for (int i = 0; i != playerObject.FishiesCaughtCount; i++)
                {
                    writeBinary.Write((int)playerObject.FishiesCaught[i].FishID);
                }

                writeBinary.Write((UInt16)playerObject.EnemiesSlaughteredCount);
                for (int i = 0; i != playerObject.EnemiesSlaughteredCount; i++)
                {
                    writeBinary.Write((int)playerObject.EnemiesSlaughtered[i].EnemyID);
                    writeBinary.Write((int)playerObject.EnemiesSlaughtered[i].KillCount);
                }

                writeBinary.Write((byte)playerObject.PotionsMax);
                writeBinary.Write((byte)playerObject.PotionsEquipped);

                for (int i = 0; i != playerObject.PotionsEquipped; i++)
                {
                    writeBinary.Write((int)playerObject.Potions[i].PotionID);
                }
                writeBinary.Write((int)playerObject.BirthdayMonth);
                writeBinary.Write((int)playerObject.BirthdayDay);
                writeBinary.Write((int)playerObject.UniquePlayerID);
                writeBinary.Write((int)playerObject.UnknownVariable04);
                writeBinary.Write((int)playerObject.UnknownVariable05);
                writeBinary.Write((int)playerObject.PlayTimeTotal);

                writeBinary.Write((byte)playerObject.UnknownVariable06);

                writeBinary.Write((UInt16)playerObject.UnknownVariable07Count);
                for (int i = 0; i != playerObject.UnknownVariable07Count; i++)
                {
                    writeBinary.Write((string)playerObject.UnknownVariables07[i].UnknownString);
                    writeBinary.Write((float)playerObject.UnknownVariables07[i].UnknownFloat);
                }

                writeBinary.Write((UInt16)playerObject.FlagsCount);
                for (int i = 0; i != playerObject.FlagsCount; i++)
                {
                    writeBinary.Write((UInt16)playerObject.Flags[i].FlagID);
                }

                writeBinary.Write((byte)playerObject.HouseStylesCount);
                for (int i = 0; i != playerObject.HouseStylesCount; i++)
                {
                    writeBinary.Write((byte)playerObject.Houses[i].HouseStyleNumber);
                    writeBinary.Write((int)playerObject.Houses[i].HouseStyleLength);
                    writeBinary.Write((byte[])playerObject.Houses[i].HouseStyleBytes);
                }
                writeBinary.Close();
            }
        }

    }
}
