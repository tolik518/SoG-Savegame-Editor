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
                writeBinary.Write((int)pPlayer.MagicByte);
                writeBinary.Write((int)pPlayer.equip.Hat);
                writeBinary.Write((int)pPlayer.equip.Facegear);
                writeBinary.Write((char)pPlayer.style.Bodytype);
                writeBinary.Write((int)pPlayer.style.Hair);
                writeBinary.Write((int)pPlayer.equip.Weapon);
                writeBinary.Write((int)pPlayer.equip.Shield);
                writeBinary.Write((int)pPlayer.equip.Armor);
                writeBinary.Write((int)pPlayer.equip.Shoes);
                writeBinary.Write((int)pPlayer.equip.Accessory1);
                writeBinary.Write((int)pPlayer.equip.Accessory2);
                writeBinary.Write((int)pPlayer.style.Hat);
                writeBinary.Write((int)pPlayer.style.Facegear);
                writeBinary.Write((int)pPlayer.style.Weapon);
                writeBinary.Write((int)pPlayer.style.Shield);
                writeBinary.Write((bool)pPlayer.style.HatHidden);
                writeBinary.Write((bool)pPlayer.style.FacegearHidden);
                writeBinary.Write((int)pPlayer.LastTwoHander);
                writeBinary.Write((int)pPlayer.LastOneHander);
                writeBinary.Write((int)pPlayer.LastBow);

                foreach (object quickslot in pPlayer.quickslots)
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

                writeBinary.Write((byte)pPlayer.style.HairColor);
                writeBinary.Write((byte)pPlayer.style.SkinColor);
                writeBinary.Write((byte)pPlayer.style.PonchoColor);
                writeBinary.Write((byte)pPlayer.style.ShirtColor);
                writeBinary.Write((byte)pPlayer.style.PantsColor);
                writeBinary.Write((byte)pPlayer.style.Sex);
                writeBinary.Write((string)pPlayer.Nickname);

                writeBinary.Write((int)pPlayer.ItemsCount);
                for (int i = 0; i != pPlayer.ItemsCount; i++)
                {
                    writeBinary.Write((Int32)pPlayer.Inventory[i].ItemID);
                    writeBinary.Write((Int32)pPlayer.Inventory[i].ItemCount);
                    writeBinary.Write((Int32)pPlayer.Inventory[i].ItemPos);
                }

                writeBinary.Write((int)pPlayer.UnknownVariable0);

                writeBinary.Write((int)pPlayer.MerchantItemsCount);
                for (int i = 0; i != pPlayer.MerchantItemsCount; i++)
                {
                    writeBinary.Write((int)pPlayer.MerchantItems[i].ItemID);
                    writeBinary.Write((int)pPlayer.MerchantItems[i].ItemCount);
                }

                writeBinary.Write((int)pPlayer.CardsCount);
                for (int i = 0; i != pPlayer.CardsCount; i++)
                {
                    writeBinary.Write((int)pPlayer.Cards[i].CardID);
                }

                writeBinary.Write((int)pPlayer.TreasureMapsCount);
                for (int i = 0; i != pPlayer.TreasureMapsCount; i++)
                {
                    writeBinary.Write((Int16)pPlayer.TreasureMaps[i].TreasureMapID);
                }

                writeBinary.Write((int)pPlayer.UnknownVariable01Count);
                for (int i = 0; i != pPlayer.UnknownVariable01Count; i++)
                {
                    writeBinary.Write((Int16)pPlayer.UnknownVariables01[i].UnknownVariable01ID);
                }

                writeBinary.Write((int)pPlayer.SkillsCount);
                for (int i = 0; i != pPlayer.SkillsCount; i++)
                {
                    writeBinary.Write((Int16)pPlayer.Skills[i].SkillID);
                    writeBinary.Write((byte)pPlayer.Skills[i].SkillLevel);
                }

                writeBinary.Write((Int16)pPlayer.Level);
                writeBinary.Write((int)pPlayer.EXPCurrent);
                writeBinary.Write((int)pPlayer.EXPUnknown0);
                writeBinary.Write((int)pPlayer.EXPUnknown1);
                writeBinary.Write((Int16)pPlayer.SkillTalentPoints);
                writeBinary.Write((Int16)pPlayer.SkillSilverPoints);
                writeBinary.Write((Int16)pPlayer.SkillGoldPoints);
                writeBinary.Write((int)pPlayer.Cash);

                writeBinary.Write((byte)pPlayer.PetsCount);
                for (int i = 0; i != pPlayer.PetsCount; i++)
                {
                    writeBinary.Write((int)pPlayer.Pets[i].Type1);
                    writeBinary.Write((int)pPlayer.Pets[i].Type2);
                    writeBinary.Write((string)pPlayer.Pets[i].Nickname);
                    writeBinary.Write((byte)pPlayer.Pets[i].Level);
                    writeBinary.Write((byte)pPlayer.Pets[i].Skin);

                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatHealth);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatEnergy);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatDamage);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatCrit);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatSpeed);

                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatProgressHealth);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatProgressEnergy);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatProgressDamage);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatProgressCrit);
                    writeBinary.Write((UInt16)pPlayer.Pets[i].StatProgressSpeed);
                }

                writeBinary.Write((int)pPlayer.PetsSelected);
                writeBinary.Write((byte)pPlayer.PetHidden);

                writeBinary.Write((UInt16)pPlayer.QuestsCount);
                for (int i = 0; i != pPlayer.QuestsCount; i++)
                {
                    writeBinary.Write((UInt16)pPlayer.Quests[i].QuestID);
                }

                writeBinary.Write((UInt16)pPlayer.EnemiesMetCount);
                for (int i = 0; i != pPlayer.EnemiesMetCount; i++)
                {
                    writeBinary.Write((UInt32)pPlayer.Enemies[i].EnemyID);
                }

                writeBinary.Write((UInt16)(pPlayer.UnknownVariable02Count / 16));
                for (int i = 0; i != pPlayer.UnknownVariable02Count; i++)
                {
                    writeBinary.Write((byte)pPlayer.UnknownVariables02[i].UnknownByte);
                }

                writeBinary.Write((int)pPlayer.RobinBowHighscore);

                writeBinary.Write((UInt16)pPlayer.UnknownVariable03Count);
                for (int i = 0; i != pPlayer.UnknownVariable03Count; i++)
                {
                    writeBinary.Write((UInt16)pPlayer.UnknownVariables03[i].UnknownVariable);
                }

                writeBinary.Write((UInt16)pPlayer.ItemsMetCount);
                for (int i = 0; i != pPlayer.ItemsMetCount; i++)
                {
                    writeBinary.Write((int)pPlayer.ItemsMet[i].ItemID);
                }

                writeBinary.Write((UInt16)pPlayer.ItemsCraftedCount);
                for (int i = 0; i != pPlayer.ItemsCraftedCount; i++)
                {
                    writeBinary.Write((int)pPlayer.ItemsCrafted[i].ItemID);
                }

                writeBinary.Write((UInt16)pPlayer.FishiesCaughtCount);
                for (int i = 0; i != pPlayer.FishiesCaughtCount; i++)
                {
                    writeBinary.Write((int)pPlayer.FishiesCaught[i].FishID);
                }

                writeBinary.Write((UInt16)pPlayer.EnemiesSlaughteredCount);
                for (int i = 0; i != pPlayer.EnemiesSlaughteredCount; i++)
                {
                    writeBinary.Write((int)pPlayer.EnemiesSlaughtered[i].EnemyID);
                    writeBinary.Write((int)pPlayer.EnemiesSlaughtered[i].KillCount);
                }

                writeBinary.Write((byte)pPlayer.PotionsMax);
                writeBinary.Write((byte)pPlayer.PotionsEquipped);

                for (int i = 0; i != pPlayer.PotionsEquipped; i++)
                {
                    writeBinary.Write((int)pPlayer.Potions[i].PotionID);
                }
                writeBinary.Write((int)pPlayer.BirthdayMonth);
                writeBinary.Write((int)pPlayer.BirthdayDay);
                writeBinary.Write((int)pPlayer.UniquePlayerID);
                writeBinary.Write((int)pPlayer.UnknownVariable04);
                writeBinary.Write((int)pPlayer.UnknownVariable05);
                writeBinary.Write((int)pPlayer.PlayTimeTotal);

                writeBinary.Write((byte)pPlayer.UnknownVariable06);

                writeBinary.Write((UInt16)pPlayer.UnknownVariable07Count);
                for (int i = 0; i != pPlayer.UnknownVariable07Count; i++)
                {
                    writeBinary.Write((string)pPlayer.UnknownVariables07[i].UnknownString);
                    writeBinary.Write((float)pPlayer.UnknownVariables07[i].UnknownFloat);
                }

                writeBinary.Write((UInt16)pPlayer.FlagsCount);
                for (int i = 0; i != pPlayer.FlagsCount; i++)
                {
                    writeBinary.Write((UInt16)pPlayer.Flags[i].FlagID);
                }

                writeBinary.Write((byte)pPlayer.HouseStylesCount);
                for (int i = 0; i != pPlayer.HouseStylesCount; i++)
                {
                    writeBinary.Write((byte)pPlayer.Houses[i].HouseStyleNumber);
                    writeBinary.Write((int)pPlayer.Houses[i].HouseStyleLength);
                    writeBinary.Write((byte[])pPlayer.Houses[i].HouseStyleBytes);
                }
                writeBinary.Close();
            }
        }

    }
}
