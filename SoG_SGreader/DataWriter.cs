using System.IO;

namespace SoG_SGreader
{
    public class DataWriter
    {
        private readonly Player playerObject;

        public DataWriter(Player playerObject)
        {
            this.playerObject = playerObject;
        }

        public void WriteToFile(string fileName)
        {
            using (var writeBinary = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                Equip equip = playerObject.Equip;
                Style style = playerObject.Style;

                writeBinary.Write(playerObject.MagicByte);
                writeBinary.Write(equip.Hat);
                writeBinary.Write(equip.Facegear);
                writeBinary.Write(style.Bodytype);
                writeBinary.Write(style.Hair);
                writeBinary.Write(equip.Weapon);
                writeBinary.Write(equip.Shield);
                writeBinary.Write(equip.Armor);
                writeBinary.Write(equip.Shoes);
                writeBinary.Write(equip.Accessory1);
                writeBinary.Write(equip.Accessory2);
                writeBinary.Write(style.Hat);
                writeBinary.Write(style.Facegear);
                writeBinary.Write(style.Weapon);
                writeBinary.Write(style.Shield);
                writeBinary.Write(style.HatHidden);
                writeBinary.Write(style.FacegearHidden);
                writeBinary.Write(playerObject.LastTwoHander);
                writeBinary.Write(playerObject.LastOneHander);
                writeBinary.Write(playerObject.LastBow);

                foreach (var quickslot in playerObject.Quickslots)
                {
                    if (quickslot.GetType() == typeof(SogItem))
                    {
                        writeBinary.Write((byte) 1);
                        writeBinary.Write((int) quickslot);
                    }
                    else if (quickslot.GetType() == typeof(SogSkill))
                    {
                        writeBinary.Write((byte) 2);
                        writeBinary.Write((ushort) quickslot);
                    }
                    else
                    {
                        writeBinary.Write((byte) 0);
                    }
                }

                writeBinary.Write((byte) style.HairColor);
                writeBinary.Write((byte) style.SkinColor);
                writeBinary.Write((byte) style.PonchoColor);
                writeBinary.Write((byte) style.ShirtColor);
                writeBinary.Write((byte) style.PantsColor);
                writeBinary.Write((byte) style.Sex);
                writeBinary.Write(playerObject.Nickname);

                writeBinary.Write((int) playerObject.ItemsCount);
                for (var i = 0; i != playerObject.ItemsCount; i++)
                {
                    writeBinary.Write((int) playerObject.Inventory[i].ItemID);
                    writeBinary.Write(playerObject.Inventory[i].ItemCount);
                    writeBinary.Write((int) playerObject.Inventory[i].ItemPos);
                }

                // Inventory.DisplayItem.PickupNumberPool???
                writeBinary.Write(playerObject.UnknownVariable0);

                writeBinary.Write((int) playerObject.MerchantItems.Count);
                for (var i = 0; i != playerObject.MerchantItems.Count; i++)
                {
                    writeBinary.Write((int) playerObject.MerchantItems[i].ItemID);
                    writeBinary.Write(playerObject.MerchantItems[i].ItemCount);
                }

                writeBinary.Write((int) playerObject.Cards.Count);
                for (var i = 0; i != playerObject.Cards.Count; i++)
                {
                    writeBinary.Write((int) playerObject.Cards[i].CardID);
                }

                writeBinary.Write((int) playerObject.TreasureMaps.Count);
                for (var i = 0; i != playerObject.TreasureMaps.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.TreasureMaps[i].TreasureMapID);
                }

                writeBinary.Write((int) playerObject.TreasureFound.Count);
                for (var i = 0; i != playerObject.TreasureFound.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.TreasureFound[i].TreasureMapID);
                }

                writeBinary.Write((int) playerObject.Skills.Count);
                for (var i = 0; i != playerObject.Skills.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.Skills[i].SkillID);
                    writeBinary.Write(playerObject.Skills[i].SkillLevel);
                }

                writeBinary.Write(playerObject.Level);
                writeBinary.Write(playerObject.ExpCurrent);
                writeBinary.Write(playerObject.ExpUnknown0);
                writeBinary.Write(playerObject.ExpUnknown1);
                writeBinary.Write(playerObject.SkillTalentPoints);
                writeBinary.Write(playerObject.SkillSilverPoints);
                writeBinary.Write(playerObject.SkillGoldPoints);
                writeBinary.Write(playerObject.Cash);

                writeBinary.Write((byte) playerObject.Pets.Count);
                for (var i = 0; i != playerObject.Pets.Count; i++)
                {
                    var currentPet = playerObject.Pets[i];

                    writeBinary.Write(currentPet.Type1);
                    writeBinary.Write(currentPet.Type2);
                    writeBinary.Write(currentPet.Nickname);
                    writeBinary.Write(currentPet.Level);
                    writeBinary.Write(currentPet.Skin);

                    writeBinary.Write(currentPet.StatHealth);
                    writeBinary.Write(currentPet.StatEnergy);
                    writeBinary.Write(currentPet.StatDamage);
                    writeBinary.Write(currentPet.StatCrit);
                    writeBinary.Write(currentPet.StatSpeed);

                    writeBinary.Write(currentPet.StatProgressHealth);
                    writeBinary.Write(currentPet.StatProgressEnergy);
                    writeBinary.Write(currentPet.StatProgressDamage);
                    writeBinary.Write(currentPet.StatProgressCrit);
                    writeBinary.Write(currentPet.StatProgressSpeed);
                }

                writeBinary.Write(playerObject.PetsSelected);
                writeBinary.Write(playerObject.PetHidden);

                writeBinary.Write((ushort) playerObject.Quests.Count);
                for (int i = 0; i != playerObject.Quests.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.Quests[i].QuestID);
                }

                writeBinary.Write((ushort) playerObject.EnemiesSeen.Count);
                for (int i = 0; i != playerObject.EnemiesSeen.Count; i++)
                {
                    writeBinary.Write((int) playerObject.EnemiesSeen[i].EnemyID);
                }

                writeBinary.Write((ushort) (playerObject.UnknownVariables02.Count / 16));
                for (int i = 0; i != playerObject.UnknownVariables02.Count; i++)
                {
                    writeBinary.Write(playerObject.UnknownVariables02[i].UnknownByte);
                }

                writeBinary.Write(playerObject.RobinBowHighscore);

                writeBinary.Write((ushort) playerObject.Trophies.Count);
                for (int i = 0; i != playerObject.Trophies.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.Trophies[i].TrophyID);
                }

                writeBinary.Write((ushort) playerObject.ItemsSeen.Count);
                for (int i = 0; i != playerObject.ItemsSeen.Count; i++)
                {
                    writeBinary.Write((int) playerObject.ItemsSeen[i].ItemID);
                }

                writeBinary.Write((ushort) playerObject.ItemsCrafted.Count);
                for (int i = 0; i != playerObject.ItemsCrafted.Count; i++)
                {
                    writeBinary.Write((int) playerObject.ItemsCrafted[i].ItemID);
                }

                writeBinary.Write((ushort) playerObject.FishCaught.Count);
                for (int i = 0; i != playerObject.FishCaught.Count; i++)
                {
                    writeBinary.Write((int) playerObject.FishCaught[i].FishID);
                }

                writeBinary.Write((ushort) playerObject.KilledEnemies.Count);
                for (int i = 0; i != playerObject.KilledEnemies.Count; i++)
                {
                    writeBinary.Write((int) playerObject.KilledEnemies[i].EnemyID);
                    writeBinary.Write(playerObject.KilledEnemies[i].KillCount);
                }

                writeBinary.Write(playerObject.PotionsMax);
                writeBinary.Write(playerObject.PotionsEquipped);

                for (int i = 0; i != playerObject.PotionsEquipped; i++)
                {
                    writeBinary.Write((int) playerObject.Potions[i].PotionID);
                }

                writeBinary.Write(playerObject.BirthdayMonth);
                writeBinary.Write(playerObject.BirthdayDay);
                writeBinary.Write((int) playerObject.UniquePlayerId);
                writeBinary.Write(playerObject.LastAutosave);
                writeBinary.Write(playerObject.SaveUnknown);

                writeBinary.Write(playerObject.PlayTimeTotal); // check for overflow

                writeBinary.Write((byte)playerObject.PhaseShiftStuff);

                writeBinary.Write((ushort) playerObject.CharacterFlags.Count);
                for (int i = 0; i != playerObject.CharacterFlags.Count; i++)
                {
                    writeBinary.Write(playerObject.CharacterFlags[i].Name);
                    writeBinary.Write(playerObject.CharacterFlags[i].Value);
                }

                writeBinary.Write((ushort) playerObject.Flags.Count);
                for (int i = 0; i != playerObject.Flags.Count; i++)
                {
                    writeBinary.Write((ushort) playerObject.Flags[i].FlagID);
                }

                writeBinary.Write((byte) playerObject.HouseStyles.Count);
                for (int i = 0; i != playerObject.HouseStyles.Count; i++)
                {
                    writeBinary.Write(playerObject.HouseStyles[i].Number);
                    writeBinary.Write((uint) playerObject.HouseStyles[i].Length);
                    writeBinary.Write(playerObject.HouseStyles[i].Bytes);
                }

                writeBinary.Close();
            }
        }
    }
}