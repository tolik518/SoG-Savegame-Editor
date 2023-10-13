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

                playerObject.MagicByte = readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh    
                playerObject.equip.Hat = readBinary.ReadInt32();
                playerObject.equip.Facegear = readBinary.ReadInt32();
                playerObject.style.Bodytype = readBinary.ReadChar(); //seems like always B ?    
                playerObject.style.Hair = readBinary.ReadInt32();
                playerObject.equip.Weapon = readBinary.ReadInt32();
                playerObject.equip.Shield = readBinary.ReadInt32();
                playerObject.equip.Armor = readBinary.ReadInt32();
                playerObject.equip.Shoes = readBinary.ReadInt32();
                playerObject.equip.Accessory1 = readBinary.ReadInt32();
                playerObject.equip.Accessory2 = readBinary.ReadInt32();
                playerObject.style.Hat = readBinary.ReadInt32();
                playerObject.style.Facegear = readBinary.ReadInt32();
                playerObject.style.Weapon = readBinary.ReadInt32();
                playerObject.style.Shield = readBinary.ReadInt32();

                playerObject.style.HatHidden = readBinary.ReadBoolean();     //[Sog_PlayerProperty(16)]
                playerObject.style.FacegearHidden = readBinary.ReadBoolean();

                playerObject.LastTwoHander = readBinary.ReadInt32();  //last equipped onehander? 
                playerObject.LastOneHander = readBinary.ReadInt32(); //last equipped twohander?   
                playerObject.LastBow = readBinary.ReadInt32(); //last equipped bow?     

                for (int i = 0; i < 10; i++)
                {
                    int quickSlotType = readBinary.ReadByte();
                    if (quickSlotType == 1)
                    {
                        playerObject.quickslots.Add((Sog_Items)readBinary.ReadInt32());
                    }
                    else if (quickSlotType == 2)
                    {
                        playerObject.quickslots.Add((Sog_Skills)readBinary.ReadUInt16());
                    }
                    else
                    {
                        playerObject.quickslots.Add(0);
                    }
                }

                playerObject.style.HairColor = readBinary.ReadByte();
                playerObject.style.SkinColor = readBinary.ReadByte();
                playerObject.style.PonchoColor = readBinary.ReadByte();
                playerObject.style.ShirtColor = readBinary.ReadByte();
                playerObject.style.PantsColor = readBinary.ReadByte();

                playerObject.style.Sex = readBinary.ReadByte();  // female = 0; male = 1

                playerObject.NicknameLength = readBinary.ReadByte();

                playerObject.Nickname = new string(readBinary.ReadChars(playerObject.NicknameLength));

                playerObject.ItemsCount = readBinary.ReadInt32();

                playerObject.Inventory = new List<Sog_Player.Item>(playerObject.ItemsCount);
                for (int i = 0; i != playerObject.ItemsCount; i++)
                {
                    Sog_Player.Item iItem = new Sog_Player.Item(
                        (Sog_Items)readBinary.ReadInt32(),
                        (int)readBinary.ReadInt32(),
                        readBinary.ReadUInt32()
                    );
                    playerObject.Inventory.Add(iItem);
                }

                txtConsole.AppendText("\r\nInventorySize: " + playerObject.ItemsCount);

                playerObject.UnknownVariable0 = readBinary.ReadInt32();   //idk what I am reading here

                playerObject.MerchantItemsCount = readBinary.ReadInt32();     //itemscount by shady merchant

                playerObject.MerchantItems = new List<Sog_Player.MerchantItem>(playerObject.MerchantItemsCount);
                for (int i = 0; i != playerObject.MerchantItemsCount; i++)
                {
                    Sog_Player.MerchantItem mItem = new Sog_Player.MerchantItem((Sog_Items)readBinary.ReadInt32(), (int)readBinary.ReadInt32());
                    playerObject.MerchantItems.Add(mItem);
                }
                txtConsole.AppendText("\r\nItemCountMerchant: " + playerObject.MerchantItemsCount);


                playerObject.CardsCount = readBinary.ReadInt32();     //How many cards do we need to count        
                playerObject.Cards = new List<Sog_Player.Card>(playerObject.CardsCount);
                for (int i = 0; i != playerObject.CardsCount; i++)
                {
                    Sog_Player.Card cCard = new Sog_Player.Card(readBinary.ReadInt32());
                    playerObject.Cards.Add(cCard);
                }
                txtConsole.AppendText("\r\nCardsCount: " + playerObject.CardsCount);

                playerObject.TreasureMapsCount = readBinary.ReadInt32();     //How many Treasure Maps do we need to count
                playerObject.TreasureMaps = new List<Sog_Player.TreasureMap>(playerObject.TreasureMapsCount);
                for (int i = 0; i != playerObject.TreasureMapsCount; i++)
                {
                    Sog_Player.TreasureMap treasureMap = new Sog_Player.TreasureMap(readBinary.ReadInt16());
                    playerObject.TreasureMaps.Add(treasureMap);
                }
                txtConsole.AppendText("\r\nTreasureMapCount: " + playerObject.TreasureMapsCount);

                playerObject.UnknownVariable01Count = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                playerObject.UnknownVariables01 = new List<Sog_Player.UnknownVariable01>(playerObject.UnknownVariable01Count);
                for (int i = 0; i != playerObject.UnknownVariable01Count; i++)
                {
                    Sog_Player.UnknownVariable01 unknownVariables01 = new Sog_Player.UnknownVariable01(readBinary.ReadInt16());    //Unknown
                    playerObject.UnknownVariables01.Add(unknownVariables01);
                }
                txtConsole.AppendText("\r\nUnknownCount: " + playerObject.UnknownVariable01Count);

                playerObject.SkillsCount = readBinary.ReadInt32();     //How many Skills do we need to count
                playerObject.Skills = new List<Sog_Player.Skill>(playerObject.SkillsCount);
                for (int i = 0; i != playerObject.SkillsCount; i++)
                {
                    Sog_Player.Skill skill = new Sog_Player.Skill((Sog_Skills)readBinary.ReadInt16(), readBinary.ReadByte());
                    playerObject.Skills.Add(skill);
                }
                txtConsole.AppendText("\r\nSkillCount: " + playerObject.SkillsCount);

                playerObject.Level = readBinary.ReadInt16();         //Level

                playerObject.EXPCurrent = readBinary.ReadInt32();     //currentexp
                playerObject.EXPUnknown0 = readBinary.ReadInt32();     //something exp ?
                playerObject.EXPUnknown1 = readBinary.ReadInt32();     //something exp ?

                playerObject.SkillTalentPoints = readBinary.ReadInt16();    //Talent Points
                playerObject.SkillSilverPoints = readBinary.ReadInt16();    //Silver Skill Points
                playerObject.SkillGoldPoints = readBinary.ReadInt16();    //Gold Skill Points
                playerObject.Cash = readBinary.ReadInt32();   //cash

                playerObject.PetsCount = readBinary.ReadByte();
                txtConsole.AppendText("\r\nPetsCount: " + playerObject.PetsCount);

                playerObject.Pets = new List<Sog_Player.Pet>(playerObject.PetsCount);
                for (int i = 0; i != playerObject.PetsCount; i++)
                {
                    playerObject.Pets.Add(new Sog_Player.Pet
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
                    txtConsole.AppendText("\r\n" + i + ". Petname: " + playerObject.Pets[i].Nickname);
                }

                playerObject.PetsSelected = readBinary.ReadInt32();
                playerObject.PetHidden = readBinary.ReadByte();

                //              |            // 
                //              |            // 
                //          new stuff        // 
                //      we're not editing    // 
                //             yet           // 

                playerObject.QuestsCount = readBinary.ReadUInt16();
                playerObject.Quests = new List<Sog_Player.Quest>(playerObject.QuestsCount);
                for (int i = 0; i != playerObject.QuestsCount; i++)
                {
                    Sog_Player.Quest quest = new Sog_Player.Quest(readBinary.ReadUInt16());
                    playerObject.Quests.Add(quest);
                }
                txtConsole.AppendText("\r\n" + "QuestsCount: " + playerObject.QuestsCount);

                playerObject.EnemiesMetCount = readBinary.ReadUInt16();
                playerObject.Enemies = new List<Sog_Player.Enemy>(playerObject.EnemiesMetCount);
                for (int i = 0; i != playerObject.EnemiesMetCount; i++)
                {
                    Sog_Player.Enemy enemy = new Sog_Player.Enemy(readBinary.ReadInt32());
                    playerObject.Enemies.Add(enemy);
                }
                txtConsole.AppendText("\r\n" + "EnemiesMetCount: " + playerObject.EnemiesMetCount);

                playerObject.UnknownVariable02Count = (UInt16)(readBinary.ReadUInt16() * 16);  // there are X sequences, each 10 bytes long
                playerObject.UnknownVariables02 = new List<Sog_Player.UnknownVariable02>(playerObject.UnknownVariable02Count);
                for (int i = 0; i != playerObject.UnknownVariable02Count; i++)
                {
                    Sog_Player.UnknownVariable02 unknownVariable02 = new Sog_Player.UnknownVariable02(readBinary.ReadByte());
                    playerObject.UnknownVariables02.Add(unknownVariable02);
                }
                txtConsole.AppendText("\r\n" + "UnknownVariable02Count: " + playerObject.UnknownVariable02Count);

                playerObject.RobinBowHighscore = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "RobinBowHighscore: " + playerObject.RobinBowHighscore);

                playerObject.UnknownVariable03Count = (UInt16)(readBinary.ReadUInt16());
                playerObject.UnknownVariables03 = new List<Sog_Player.UnknownVariable03>(playerObject.UnknownVariable03Count);
                for (int i = 0; i != playerObject.UnknownVariable03Count; i++)
                {
                    Sog_Player.UnknownVariable03 unknownVariable03 = new Sog_Player.UnknownVariable03(readBinary.ReadUInt16());
                    playerObject.UnknownVariables03.Add(unknownVariable03);
                }
                txtConsole.AppendText("\r\n" + "UnknownVariable03Count: " + playerObject.UnknownVariable03Count);

                playerObject.ItemsMetCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.ItemsMet = new List<Sog_Player.ItemMet>(playerObject.ItemsMetCount);
                for (int i = 0; i != playerObject.ItemsMetCount; i++)
                {
                    Sog_Player.ItemMet itemsMet = new Sog_Player.ItemMet((Sog_Items)readBinary.ReadInt32());
                    playerObject.ItemsMet.Add(itemsMet);
                }
                txtConsole.AppendText("\r\n" + "ItemsMetCount: " + playerObject.ItemsMetCount);

                playerObject.ItemsCraftedCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.ItemsCrafted = new List<Sog_Player.ItemCrafted>(playerObject.ItemsCraftedCount);
                for (int i = 0; i != playerObject.ItemsCraftedCount; i++)
                {
                    Sog_Player.ItemCrafted itemsMet = new Sog_Player.ItemCrafted((Sog_Items)readBinary.ReadInt32());
                    playerObject.ItemsCrafted.Add(itemsMet);
                }
                txtConsole.AppendText("\r\n" + "ItemsCraftedCount: " + playerObject.ItemsCraftedCount);

                playerObject.FishiesCaughtCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.FishiesCaught = new List<Sog_Player.FishCaught>(playerObject.FishiesCaughtCount);
                for (int i = 0; i != playerObject.FishiesCaughtCount; i++)
                {
                    Sog_Player.FishCaught fish = new Sog_Player.FishCaught((Sog_Items)readBinary.ReadInt32());
                    playerObject.FishiesCaught.Add(fish);
                }
                txtConsole.AppendText("\r\n" + "FishiesCaughtCount: " + playerObject.FishiesCaughtCount);

                playerObject.EnemiesSlaughteredCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.EnemiesSlaughtered = new List<Sog_Player.EnemySlaughtered>(playerObject.EnemiesSlaughteredCount);
                for (int i = 0; i != playerObject.EnemiesSlaughteredCount; i++)
                {
                    Sog_Player.EnemySlaughtered enemy = new Sog_Player.EnemySlaughtered(readBinary.ReadInt32(), readBinary.ReadInt32());
                    playerObject.EnemiesSlaughtered.Add(enemy);
                }
                txtConsole.AppendText("\r\n" + "EnemiesSlaughteredCount: " + playerObject.EnemiesSlaughteredCount);

                playerObject.PotionsMax = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + " PotionsMax: " + playerObject.PotionsMax);
                playerObject.PotionsEquipped = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "PotionsEquipped: " + playerObject.PotionsEquipped);

                playerObject.Potions = new List<Sog_Player.Potion>(playerObject.PotionsEquipped);
                for (int i = 0; i != playerObject.PotionsEquipped; i++)
                {
                    Sog_Player.Potion potion = new Sog_Player.Potion(readBinary.ReadInt32());
                    playerObject.Potions.Add(potion);
                }

                playerObject.BirthdayMonth = readBinary.ReadInt32();
                playerObject.BirthdayDay = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "Birthday: " + playerObject.BirthdayDay + "." + playerObject.BirthdayMonth + "." + "1081");

                playerObject.UniquePlayerID = readBinary.ReadUInt32();
                playerObject.UnknownVariable04 = readBinary.ReadInt32();
                playerObject.UnknownVariable05 = readBinary.ReadInt32();
                playerObject.PlayTimeTotal = readBinary.ReadInt32();
                txtConsole.AppendText("\r\nPlayTimeTotal: " + (double)playerObject.PlayTimeTotal / 60 / 60 / 60 + " hours");
                playerObject.UnknownVariable06 = readBinary.ReadByte();

                playerObject.UnknownVariable07Count = readBinary.ReadInt16();
                playerObject.UnknownVariables07 = new List<Sog_Player.UnknownVariable07>(playerObject.UnknownVariable07Count);
                for (int i = 0; i != playerObject.UnknownVariable07Count; i++)
                {
                    string s = readBinary.ReadString();
                    Sog_Player.UnknownVariable07 unknownVariable07 = new Sog_Player.UnknownVariable07(s, readBinary.ReadSingle());
                    playerObject.UnknownVariables07.Add(unknownVariable07);
                    txtConsole.AppendText("\r\nUnknownstring: " + s);
                }

                playerObject.FlagsCount = readBinary.ReadInt16();
                playerObject.Flags = new List<Sog_Player.Flag>(playerObject.FlagsCount);
                for (int i = 0; i != playerObject.FlagsCount; i++)
                {
                    Sog_Player.Flag flag = new Sog_Player.Flag(readBinary.ReadUInt16());
                    playerObject.Flags.Add(flag);
                }
                txtConsole.AppendText("\r\nFlagsCount: " + playerObject.FlagsCount);

                playerObject.HouseStylesCount = readBinary.ReadByte();
                playerObject.Houses = new List<Sog_Player.HouseStyle>(playerObject.HouseStylesCount);
                for (int i = 0; i != playerObject.HouseStylesCount; i++)
                {
                    byte StyleNumber = readBinary.ReadByte();
                    int StyleLength = readBinary.ReadInt32();
                    byte[] StyleBytes = new byte[StyleLength];
                    for (int j = 0; j != StyleLength; j++)
                    {
                        StyleBytes[j] = readBinary.ReadByte();
                    }
                    Sog_Player.HouseStyle house = new Sog_Player.HouseStyle(StyleNumber, StyleLength, StyleBytes);
                    playerObject.Houses.Add(house);
                }
                txtConsole.AppendText("\r\nHouseStylesCount: " + playerObject.HouseStylesCount);

                txtConsole.AppendText("\r\nLength: " + readBinary.BaseStream.Length);
                txtConsole.AppendText("\r\nPosition: " + readBinary.BaseStream.Position);

                readBinary.Close();
                fileStream.Close();
            }
        }


    }
}
