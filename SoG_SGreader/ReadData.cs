using System;
using System.Collections.Generic;
using System.IO;

namespace Sog_SGreader
{
    public partial class FrmMain
    {
        private void ReadData(string fileName)
        {
            InitVariables();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryReader readBinary = new BinaryReader(fileStream);

                txtConsole.AppendText("\r\nFilesize: " + new FileInfo(fileName).Length);

                pPlayer.MagicByte = readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh    
                pPlayer.equip.Hat = readBinary.ReadInt32();
                pPlayer.equip.Facegear = readBinary.ReadInt32();
                pPlayer.style.Bodytype = readBinary.ReadChar(); //seems like always B ?    
                pPlayer.style.Hair = readBinary.ReadInt32();
                pPlayer.equip.Weapon = readBinary.ReadInt32();
                pPlayer.equip.Shield = readBinary.ReadInt32();
                pPlayer.equip.Armor = readBinary.ReadInt32();
                pPlayer.equip.Shoes = readBinary.ReadInt32();
                pPlayer.equip.Accessory1 = readBinary.ReadInt32();
                pPlayer.equip.Accessory2 = readBinary.ReadInt32();
                pPlayer.style.Hat = readBinary.ReadInt32();
                pPlayer.style.Facegear = readBinary.ReadInt32();
                pPlayer.style.Weapon = readBinary.ReadInt32();
                pPlayer.style.Shield = readBinary.ReadInt32();

                pPlayer.style.HatHidden = readBinary.ReadBoolean();     //[Sog_PlayerProperty(16)]
                pPlayer.style.FacegearHidden = readBinary.ReadBoolean();

                pPlayer.LastTwoHander = readBinary.ReadInt32();  //last equipped onehander? 
                pPlayer.LastOneHander = readBinary.ReadInt32(); //last equipped twohander?   
                pPlayer.LastBow = readBinary.ReadInt32(); //last equipped bow?     

                for (int i = 0; i < 10; i++)
                {
                    int iQs_ID = readBinary.ReadByte();
                    if (iQs_ID == 1)
                    {
                        pPlayer.quickslots.Add((Sog_Items)readBinary.ReadInt32());
                    }
                    else if (iQs_ID == 2)
                    {
                        pPlayer.quickslots.Add((Sog_Skills)readBinary.ReadUInt16());
                    }
                    else
                    {
                        pPlayer.quickslots.Add(0);
                    }
                }

                pPlayer.style.HairColor = readBinary.ReadByte();
                pPlayer.style.SkinColor = readBinary.ReadByte();
                pPlayer.style.PonchoColor = readBinary.ReadByte();
                pPlayer.style.ShirtColor = readBinary.ReadByte();
                pPlayer.style.PantsColor = readBinary.ReadByte();

                pPlayer.style.Sex = readBinary.ReadByte();  // female = 0; male = 1

                pPlayer.NicknameLength = readBinary.ReadByte();

                pPlayer.Nickname = new string(readBinary.ReadChars(pPlayer.NicknameLength));

                pPlayer.ItemsCount = readBinary.ReadInt32();

                pPlayer.Inventory = new List<Sog_Player.Item>(pPlayer.ItemsCount);
                for (int i = 0; i != pPlayer.ItemsCount; i++)
                {
                    Sog_Player.Item iItem = new Sog_Player.Item((Sog_Items)readBinary.ReadInt32(), (int)readBinary.ReadInt32(), readBinary.ReadUInt32());
                    pPlayer.Inventory.Add(iItem);
                }

                txtConsole.AppendText("\r\nInventorysize: " + pPlayer.ItemsCount);

                pPlayer.UnknownVariable0 = readBinary.ReadInt32();   //idk what I am reading here

                pPlayer.MerchantItemsCount = readBinary.ReadInt32();     //itemscount by shady merchant

                pPlayer.MerchantItems = new List<Sog_Player.MerchantItem>(pPlayer.MerchantItemsCount);
                for (int i = 0; i != pPlayer.MerchantItemsCount; i++)
                {
                    Sog_Player.MerchantItem mItem = new Sog_Player.MerchantItem((Sog_Items)readBinary.ReadInt32(), (int)readBinary.ReadInt32());
                    pPlayer.MerchantItems.Add(mItem);
                }
                txtConsole.AppendText("\r\niItemCountMerchant: " + pPlayer.MerchantItemsCount);


                pPlayer.CardsCount = readBinary.ReadInt32();     //How many cards do we need to count        
                pPlayer.Cards = new List<Sog_Player.Card>(pPlayer.CardsCount);
                for (int i = 0; i != pPlayer.CardsCount; i++)
                {
                    Sog_Player.Card cCard = new Sog_Player.Card(readBinary.ReadInt32());
                    pPlayer.Cards.Add(cCard);
                }
                txtConsole.AppendText("\r\niCardsCount: " + pPlayer.CardsCount);

                pPlayer.TreasureMapsCount = readBinary.ReadInt32();     //How many Treasure Maps do we need to count
                pPlayer.TreasureMaps = new List<Sog_Player.TreasureMap>(pPlayer.TreasureMapsCount);
                for (int i = 0; i != pPlayer.TreasureMapsCount; i++)
                {
                    Sog_Player.TreasureMap treasureMap = new Sog_Player.TreasureMap(readBinary.ReadInt16());
                    pPlayer.TreasureMaps.Add(treasureMap);
                }
                txtConsole.AppendText("\r\niTreasureMapCount: " + pPlayer.TreasureMapsCount);

                pPlayer.UnknownVariable01Count = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                pPlayer.UnknownVariables01 = new List<Sog_Player.UnknownVariable01>(pPlayer.UnknownVariable01Count);
                for (int i = 0; i != pPlayer.UnknownVariable01Count; i++)
                {
                    Sog_Player.UnknownVariable01 unknownVariables01 = new Sog_Player.UnknownVariable01(readBinary.ReadInt16());    //Unknown
                    pPlayer.UnknownVariables01.Add(unknownVariables01);
                }
                txtConsole.AppendText("\r\niUnknownCount: " + pPlayer.UnknownVariable01Count);

                pPlayer.SkillsCount = readBinary.ReadInt32();     //How many Skills do we need to count
                pPlayer.Skills = new List<Sog_Player.Skill>(pPlayer.SkillsCount);
                for (int i = 0; i != pPlayer.SkillsCount; i++)
                {
                    Sog_Player.Skill skill = new Sog_Player.Skill((Sog_Skills)readBinary.ReadInt16(), readBinary.ReadByte());
                    pPlayer.Skills.Add(skill);
                }
                txtConsole.AppendText("\r\niSkillCount: " + pPlayer.SkillsCount);

                pPlayer.Level = readBinary.ReadInt16();         //Level

                pPlayer.EXPCurrent = readBinary.ReadInt32();     //currentexp
                pPlayer.EXPUnknown0 = readBinary.ReadInt32();     //something exp ?
                pPlayer.EXPUnknown1 = readBinary.ReadInt32();     //something exp ?

                pPlayer.SkillTalentPoints = readBinary.ReadInt16();    //Talent Points
                pPlayer.SkillSilverPoints = readBinary.ReadInt16();    //Silver Skill Points
                pPlayer.SkillGoldPoints = readBinary.ReadInt16();    //Gold Skill Points
                pPlayer.Cash = readBinary.ReadInt32();   //cash

                pPlayer.PetsCount = readBinary.ReadByte();

                pPlayer.Pets = new List<Sog_Player.Pet>(pPlayer.PetsCount);
                for (int i = 0; i != pPlayer.PetsCount; i++)
                {
                    pPlayer.Pets.Add(new Sog_Player.Pet
                    {
                        Type1 = readBinary.ReadInt32(),
                        Type2 = readBinary.ReadInt32(),
                        Nickname = readBinary.ReadString(),
                        Level = readBinary.ReadByte(),
                        Skin = readBinary.ReadByte(),

                        StatHealth = readBinary.ReadUInt16(),
                        StatEnergy = readBinary.ReadUInt16(),
                        StatDamage = readBinary.ReadUInt16(),
                        StatCrit = readBinary.ReadUInt16(),
                        StatSpeed = readBinary.ReadUInt16(),

                        StatProgressHealth = readBinary.ReadUInt16(),
                        StatProgressEnergy = readBinary.ReadUInt16(),
                        StatProgressDamage = readBinary.ReadUInt16(),
                        StatProgressCrit = readBinary.ReadUInt16(),
                        StatProgressSpeed = readBinary.ReadUInt16()
                    });
                    txtConsole.AppendText("\r\n" + i + " Petname: " + pPlayer.Pets[i].Nickname);
                }

                pPlayer.PetsSelected = readBinary.ReadInt32();
                pPlayer.PetHidden = readBinary.ReadByte();

                //              |            // 
                //              |            // 
                //          new stuff        // 
                //      we're not editing    // 
                //             yet           // 

                pPlayer.QuestsCount = readBinary.ReadUInt16();
                pPlayer.Quests = new List<Sog_Player.Quest>(pPlayer.QuestsCount);
                for (int i = 0; i != pPlayer.QuestsCount; i++)
                {
                    Sog_Player.Quest quest = new Sog_Player.Quest(readBinary.ReadUInt16());
                    pPlayer.Quests.Add(quest);
                }
                txtConsole.AppendText("\r\n" + " QuestsCount: " + pPlayer.QuestsCount);

                pPlayer.EnemiesMetCount = readBinary.ReadUInt16();
                pPlayer.Enemies = new List<Sog_Player.Enemy>(pPlayer.EnemiesMetCount);
                for (int i = 0; i != pPlayer.EnemiesMetCount; i++)
                {
                    Sog_Player.Enemy enemy = new Sog_Player.Enemy(readBinary.ReadInt32());
                    pPlayer.Enemies.Add(enemy);
                }
                txtConsole.AppendText("\r\n" + " EnemiesMetCount: " + pPlayer.EnemiesMetCount);

                pPlayer.UnknownVariable02Count = (UInt16)(readBinary.ReadUInt16() * 16);  // there are X sequences, each 10 bytes long
                pPlayer.UnknownVariables02 = new List<Sog_Player.UnknownVariable02>(pPlayer.UnknownVariable02Count);
                for (int i = 0; i != pPlayer.UnknownVariable02Count; i++)
                {
                    Sog_Player.UnknownVariable02 unknownVariable02 = new Sog_Player.UnknownVariable02(readBinary.ReadByte());
                    pPlayer.UnknownVariables02.Add(unknownVariable02);
                }
                txtConsole.AppendText("\r\n" + " UnknownVariable02Count: " + pPlayer.UnknownVariable02Count);

                pPlayer.RobinBowHighscore = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + " RobinBowHighscore: " + pPlayer.RobinBowHighscore);

                pPlayer.UnknownVariable03Count = (UInt16)(readBinary.ReadUInt16());
                pPlayer.UnknownVariables03 = new List<Sog_Player.UnknownVariable03>(pPlayer.UnknownVariable03Count);
                for (int i = 0; i != pPlayer.UnknownVariable03Count; i++)
                {
                    Sog_Player.UnknownVariable03 unknownVariable03 = new Sog_Player.UnknownVariable03(readBinary.ReadUInt16());
                    pPlayer.UnknownVariables03.Add(unknownVariable03);
                }
                txtConsole.AppendText("\r\n" + " UnknownVariable03Count: " + pPlayer.UnknownVariable03Count);

                pPlayer.ItemsMetCount = (UInt16)(readBinary.ReadUInt16());
                pPlayer.ItemsMet = new List<Sog_Player.ItemMet>(pPlayer.ItemsMetCount);
                for (int i = 0; i != pPlayer.ItemsMetCount; i++)
                {
                    Sog_Player.ItemMet itemsMet = new Sog_Player.ItemMet((Sog_Items)readBinary.ReadInt32());
                    pPlayer.ItemsMet.Add(itemsMet);
                }
                txtConsole.AppendText("\r\n" + " ItemsMetCount: " + pPlayer.ItemsMetCount);

                pPlayer.ItemsCraftedCount = (UInt16)(readBinary.ReadUInt16());
                pPlayer.ItemsCrafted = new List<Sog_Player.ItemCrafted>(pPlayer.ItemsCraftedCount);
                for (int i = 0; i != pPlayer.ItemsCraftedCount; i++)
                {
                    Sog_Player.ItemCrafted itemsMet = new Sog_Player.ItemCrafted((Sog_Items)readBinary.ReadInt32());
                    pPlayer.ItemsCrafted.Add(itemsMet);
                }
                txtConsole.AppendText("\r\n" + " ItemsCraftedCount: " + pPlayer.ItemsCraftedCount);

                pPlayer.FishiesCaughtCount = (UInt16)(readBinary.ReadUInt16());
                pPlayer.FishiesCaught = new List<Sog_Player.FishCaught>(pPlayer.FishiesCaughtCount);
                for (int i = 0; i != pPlayer.FishiesCaughtCount; i++)
                {
                    Sog_Player.FishCaught fish = new Sog_Player.FishCaught((Sog_Items)readBinary.ReadInt32());
                    pPlayer.FishiesCaught.Add(fish);
                }
                txtConsole.AppendText("\r\n" + " FishiesCaughtCount: " + pPlayer.FishiesCaughtCount);

                pPlayer.EnemiesSlaughteredCount = (UInt16)(readBinary.ReadUInt16());
                pPlayer.EnemiesSlaughtered = new List<Sog_Player.EnemySlaughtered>(pPlayer.EnemiesSlaughteredCount);
                for (int i = 0; i != pPlayer.EnemiesSlaughteredCount; i++)
                {
                    Sog_Player.EnemySlaughtered enemy = new Sog_Player.EnemySlaughtered(readBinary.ReadInt32(), readBinary.ReadInt32());
                    pPlayer.EnemiesSlaughtered.Add(enemy);
                }
                txtConsole.AppendText("\r\n" + " EnemiesSlaughteredCount: " + pPlayer.EnemiesSlaughteredCount);

                pPlayer.PotionsMax = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + " PotionsMax: " + pPlayer.PotionsMax);
                pPlayer.PotionsEquipped = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + " PotionsEquipped: " + pPlayer.PotionsEquipped);

                pPlayer.Potions = new List<Sog_Player.Potion>(pPlayer.PotionsEquipped);
                for (int i = 0; i != pPlayer.PotionsEquipped; i++)
                {
                    Sog_Player.Potion potion = new Sog_Player.Potion(readBinary.ReadInt32());
                    pPlayer.Potions.Add(potion);
                }

                pPlayer.BirthdayMonth = readBinary.ReadInt32();
                pPlayer.BirthdayDay = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + " Birthday: " + pPlayer.BirthdayDay + "." + pPlayer.BirthdayMonth + "." + "1081");

                pPlayer.UniquePlayerID = readBinary.ReadUInt32();
                pPlayer.UnknownVariable04 = readBinary.ReadInt32();
                pPlayer.UnknownVariable05 = readBinary.ReadInt32();
                pPlayer.PlayTimeTotal = readBinary.ReadInt32();
                txtConsole.AppendText("\r\nPlayTimeTotal: " + (double)pPlayer.PlayTimeTotal / 60 / 60 / 60 + " hours");
                pPlayer.UnknownVariable06 = readBinary.ReadByte();

                pPlayer.UnknownVariable07Count = readBinary.ReadInt16();
                pPlayer.UnknownVariables07 = new List<Sog_Player.UnknownVariable07>(pPlayer.UnknownVariable07Count);
                for (int i = 0; i != pPlayer.UnknownVariable07Count; i++)
                {
                    string s = readBinary.ReadString();
                    Sog_Player.UnknownVariable07 unknownVariable07 = new Sog_Player.UnknownVariable07(s, readBinary.ReadSingle());
                    pPlayer.UnknownVariables07.Add(unknownVariable07);
                    txtConsole.AppendText("\r\nUnknownstring: " + s);
                }

                pPlayer.FlagsCount = readBinary.ReadInt16();
                pPlayer.Flags = new List<Sog_Player.Flag>(pPlayer.FlagsCount);
                for (int i = 0; i != pPlayer.FlagsCount; i++)
                {
                    Sog_Player.Flag flag = new Sog_Player.Flag(readBinary.ReadUInt16());
                    pPlayer.Flags.Add(flag);
                }
                txtConsole.AppendText("\r\nFlagsCount: " + pPlayer.FlagsCount);

                pPlayer.HouseStylesCount = readBinary.ReadByte();
                pPlayer.Houses = new List<Sog_Player.HouseStyle>(pPlayer.HouseStylesCount);
                for (int i = 0; i != pPlayer.HouseStylesCount; i++)
                {
                    byte StyleNumber = readBinary.ReadByte();
                    int StyleLength = readBinary.ReadInt32();
                    byte[] StyleBytes = new byte[StyleLength];
                    for (int j = 0; j != StyleLength; j++)
                    {
                        StyleBytes[j] = readBinary.ReadByte();
                    }
                    Sog_Player.HouseStyle house = new Sog_Player.HouseStyle(StyleNumber, StyleLength, StyleBytes);
                    pPlayer.Houses.Add(house);
                }

                txtConsole.AppendText("\r\nLength: " + readBinary.BaseStream.Length);
                txtConsole.AppendText("\r\nPosition: " + readBinary.BaseStream.Position);

                readBinary.Close();
                fileStream.Close();
            }
        }


    }
}
