using System;
using System.Collections.Generic;
using System.IO;

namespace SoG_SGreader
{
    public static class DataReader
    {
        public static Player ReadFromFile(string fileName, ITextBoxWrapper txtConsole)
        {
            Player playerObject = new Player();

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryReader readBinary = new BinaryReader(fileStream);

                txtConsole.AppendText("\r\nFilesize: " + new FileInfo(fileName).Length);
                // show current position in HEX in the file
                txtConsole.AppendText("\r\nStarting Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.MagicByte = readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh  
                
                //TODO: Cast to SogItems
                playerObject.Equip.Hat = readBinary.ReadInt32();
                playerObject.Equip.Facegear = readBinary.ReadInt32();
                playerObject.Style.Bodytype = readBinary.ReadChar(); //seems like always B ?    
                txtConsole.AppendText("\r\nBodytype: " + playerObject.Style.Bodytype);
                txtConsole.AppendText("\r\nBodytype Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.Style.Hair = readBinary.ReadInt32();
                playerObject.Equip.Weapon = readBinary.ReadInt32();
                playerObject.Equip.Shield = readBinary.ReadInt32();
                playerObject.Equip.Armor = readBinary.ReadInt32();
                playerObject.Equip.Shoes = readBinary.ReadInt32();
                txtConsole.AppendText("\r\nShoes Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.Equip.Accessory1 = readBinary.ReadInt32();
                playerObject.Equip.Accessory2 = readBinary.ReadInt32();
                playerObject.Style.Hat = readBinary.ReadInt32();
                playerObject.Style.Facegear = readBinary.ReadInt32();
                playerObject.Style.Weapon = readBinary.ReadInt32();
                playerObject.Style.Shield = readBinary.ReadInt32();
                txtConsole.AppendText("\r\nShield Position: " + readBinary.BaseStream.Position.ToString("X"));
                
                playerObject.Style.HatHidden = readBinary.ReadBoolean();     //[Sog_PlayerProperty(16)]
                playerObject.Style.FacegearHidden = readBinary.ReadBoolean();

                //TODO: Cast to SogItems
                playerObject.LastTwoHander = readBinary.ReadInt32();  //last equipped onehander? 
                playerObject.LastOneHander = readBinary.ReadInt32(); //last equipped twohander?   
                playerObject.LastBow = readBinary.ReadInt32(); //last equipped bow?     
                txtConsole.AppendText("\r\nLastBow Position: " + readBinary.BaseStream.Position.ToString("X"));

                for (int i = 0; i < 10; i++)
                {
                    int quickSlotType = readBinary.ReadByte();
                    txtConsole.AppendText("\r\nquickSlotType: " + quickSlotType);
                    txtConsole.AppendText("\r\nquickSlotType Position: " + readBinary.BaseStream.Position.ToString("X"));

                    switch (quickSlotType)
                    {
                        case 1:
                            playerObject.Quickslots.Add((SogItems)readBinary.ReadInt32());
                            break;
                        case 2:
                            playerObject.Quickslots.Add((SogSkills)readBinary.ReadUInt16());
                            break;
                        default:
                            playerObject.Quickslots.Add(0);
                            break;
                    }
                }
                txtConsole.AppendText("\r\nAfter-quickSlot Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.Style.HairColor = readBinary.ReadByte();
                playerObject.Style.SkinColor = readBinary.ReadByte();
                playerObject.Style.PonchoColor = readBinary.ReadByte();
                playerObject.Style.ShirtColor = readBinary.ReadByte();
                playerObject.Style.PantsColor = readBinary.ReadByte();
                txtConsole.AppendText("\r\nStyle Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.Style.Sex = readBinary.ReadByte();  // female = 0; male = 1
                txtConsole.AppendText("\r\nGender: " + playerObject.Style.Sex);

                playerObject.NicknameLength = readBinary.ReadByte();

                playerObject.Nickname = new string(readBinary.ReadChars(playerObject.NicknameLength));
                txtConsole.AppendText("\r\nNickname: " + playerObject.Nickname);

                playerObject.ItemsCount = readBinary.ReadInt32();

                playerObject.Inventory = new List<Item>(playerObject.ItemsCount);
                txtConsole.AppendText("\r\nInventory Position: " + readBinary.BaseStream.Position.ToString("X"));
                for (int i = 0; i != playerObject.ItemsCount; i++)
                {
                    playerObject.Inventory.Add(new Item
                    {
                        ItemID = (SogItems)readBinary.ReadInt32(),
                        ItemCount = readBinary.ReadInt32(),
                        ItemPos = readBinary.ReadUInt32()
                    });
                }
                txtConsole.AppendText("\r\n After-Inventory Position: " + readBinary.BaseStream.Position.ToString("X"));

                txtConsole.AppendText("\r\nInventorySize: " + playerObject.ItemsCount);

                playerObject.UnknownVariable0 = readBinary.ReadInt32();   //idk what I am reading here

                playerObject.MerchantItemsCount = readBinary.ReadInt32();     //itemscount by shady merchant

                playerObject.MerchantItems = new List<MerchantItem>(playerObject.MerchantItemsCount);
                txtConsole.AppendText("\r\nMerchantItems Position: " + readBinary.BaseStream.Position.ToString("X"));

                for (int i = 0; i != playerObject.MerchantItemsCount; i++)
                {
                    playerObject.MerchantItems.Add(new MerchantItem 
                    {
                        ItemID = (SogItems)readBinary.ReadInt32(),
                        ItemCount = readBinary.ReadInt32()
                    });
                }
                
                txtConsole.AppendText("\r\nAfter-MerchantItems Position: " + readBinary.BaseStream.Position.ToString("X"));

                txtConsole.AppendText("\r\nItemCountMerchant: " + playerObject.MerchantItemsCount);
                
                playerObject.CardsCount = readBinary.ReadInt32();     //How many cards do we need to count        
                playerObject.Cards = new List<Card>(playerObject.CardsCount);
                txtConsole.AppendText("\r\nCards Position: " + readBinary.BaseStream.Position.ToString("X"));

                for (int i = 0; i != playerObject.CardsCount; i++)
                {
                    playerObject.Cards.Add(new Card
                    {
                        CardID = (SogEnemies)readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\nAfter-Cards Position: " + readBinary.BaseStream.Position.ToString("X"));
 
                txtConsole.AppendText("\r\nCardsCount: " + playerObject.CardsCount);

                playerObject.TreasureMapsCount = readBinary.ReadInt32();     //How many Treasure Maps do we need to count
                playerObject.TreasureMaps = new List<TreasureMap>(playerObject.TreasureMapsCount);
                txtConsole.AppendText("\r\nTreasuremaps Position: " + readBinary.BaseStream.Position.ToString("X"));
                for (int i = 0; i != playerObject.TreasureMapsCount; i++)
                {
                    playerObject.TreasureMaps.Add(new TreasureMap
                    { 
                        TreasureMapID = readBinary.ReadInt16()
                    });
                }
                txtConsole.AppendText("\r\nCards Position: " + readBinary.BaseStream.Position.ToString("X"));

                txtConsole.AppendText("\r\nTreasureMapCount: " + playerObject.TreasureMapsCount);

                playerObject.UnknownVariable01Count = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                playerObject.UnknownVariables01 = new List<UnknownVariable01>(playerObject.UnknownVariable01Count);
                for (int i = 0; i != playerObject.UnknownVariable01Count; i++)
                {
                    playerObject.UnknownVariables01.Add(new UnknownVariable01
                    {
                        UnknownVariable01ID = readBinary.ReadInt16()
                    });
                }
                txtConsole.AppendText("\r\nUnknownCount: " + playerObject.UnknownVariable01Count);

                playerObject.SkillsCount = readBinary.ReadInt32();     //How many Skills do we need to count
                playerObject.Skills = new List<Skill>(playerObject.SkillsCount);
                for (int i = 0; i != playerObject.SkillsCount; i++)
                {
                    playerObject.Skills.Add(new Skill
                    { 
                        SkillID = (SogSkills)readBinary.ReadInt16(), 
                        SkillLevel = readBinary.ReadByte()
                    });
                }
                
                txtConsole.AppendText("\r\nSkillCount: " + playerObject.SkillsCount);

                playerObject.Level = readBinary.ReadInt16();         //Level
                txtConsole.AppendText("\r\nLevel: " + playerObject.Level);

                playerObject.ExpCurrent = readBinary.ReadInt32();     //currentexp
                playerObject.ExpUnknown0 = readBinary.ReadInt32();     //something exp ?
                playerObject.ExpUnknown1 = readBinary.ReadInt32();     //something exp ?

                playerObject.SkillTalentPoints = readBinary.ReadInt16();    //Talent Points
                playerObject.SkillSilverPoints = readBinary.ReadInt16();    //Silver Skill Points
                playerObject.SkillGoldPoints = readBinary.ReadInt16();    //Gold Skill Points
                playerObject.Cash = readBinary.ReadInt32();   //cash
                txtConsole.AppendText("\r\nCash: " + playerObject.Cash);

                playerObject.PetsCount = readBinary.ReadByte();
                txtConsole.AppendText("\r\nPetsCount: " + playerObject.PetsCount);

                playerObject.Pets = new List<Pet>(playerObject.PetsCount);
                for (int i = 0; i != playerObject.PetsCount; i++)
                {
                    playerObject.Pets.Add(new Pet
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
                playerObject.Quests = new List<Quest>(playerObject.QuestsCount);
                for (int i = 0; i != playerObject.QuestsCount; i++)
                {
                    playerObject.Quests.Add(new Quest
                    {
                        QuestID = readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\n" + "QuestsCount: " + playerObject.QuestsCount);

                playerObject.EnemiesMetCount = readBinary.ReadUInt16();
                playerObject.Enemies = new List<Enemy>(playerObject.EnemiesMetCount);
                for (int i = 0; i != playerObject.EnemiesMetCount; i++)
                {
                    playerObject.Enemies.Add(new Enemy
                    (
                        readBinary.ReadInt32()
                    ));
                }
                txtConsole.AppendText("\r\n" + "EnemiesMetCount: " + playerObject.EnemiesMetCount);

                playerObject.UnknownVariable02Count = (UInt16)(readBinary.ReadUInt16() * 16);  // there are X sequences, each 10 bytes long
                playerObject.UnknownVariables02 = new List<UnknownVariable02>(playerObject.UnknownVariable02Count);
                for (int i = 0; i != playerObject.UnknownVariable02Count; i++)
                {
                    playerObject.UnknownVariables02.Add(new UnknownVariable02
                    {
                        UnknownByte = readBinary.ReadByte()
                    });
                }
                txtConsole.AppendText("\r\n" + "UnknownVariable02Count: " + playerObject.UnknownVariable02Count);

                playerObject.RobinBowHighscore = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "RobinBowHighscore: " + playerObject.RobinBowHighscore);

                playerObject.UnknownVariable03Count = (UInt16)(readBinary.ReadUInt16());
                playerObject.UnknownVariables03 = new List<UnknownVariable03>(playerObject.UnknownVariable03Count);
                for (int i = 0; i != playerObject.UnknownVariable03Count; i++)
                {
                    playerObject.UnknownVariables03.Add(new UnknownVariable03
                    {
                        UnknownVariable = readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\n" + "UnknownVariable03Count: " + playerObject.UnknownVariable03Count);

                playerObject.ItemsMetCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.ItemsMet = new List<ItemsSeen>(playerObject.ItemsMetCount);
                for (int i = 0; i != playerObject.ItemsMetCount; i++)
                {
                    playerObject.ItemsMet.Add(new ItemsSeen
                    {
                        ItemID = (SogItems)readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\n" + "ItemsMetCount: " + playerObject.ItemsMetCount);

                playerObject.ItemsCraftedCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.ItemsCrafted = new List<ItemCrafted>(playerObject.ItemsCraftedCount);
                for (int i = 0; i != playerObject.ItemsCraftedCount; i++)
                {
                    playerObject.ItemsCrafted.Add(new ItemCrafted
                    {
                        ItemID = (SogItems)readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\n" + "ItemsCraftedCount: " + playerObject.ItemsCraftedCount);

                playerObject.FishiesCaughtCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.FishiesCaught = new List<FishCaught>(playerObject.FishiesCaughtCount);
                for (int i = 0; i != playerObject.FishiesCaughtCount; i++)
                {
                    playerObject.FishiesCaught.Add(new FishCaught
                    {
                        FishID = (SogItems)readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\n" + "FishiesCaughtCount: " + playerObject.FishiesCaughtCount);

                playerObject.KilledEnemiesCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.KilledEnemies = new List<KilledEnemy>(playerObject.KilledEnemiesCount);
                for (int i = 0; i != playerObject.KilledEnemiesCount; i++)
                {
                    playerObject.KilledEnemies.Add(new KilledEnemy
                    {
                        EnemyID = readBinary.ReadInt32(), 
                        KillCount = readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\n" + "KilledEnemiesCount: " + playerObject.KilledEnemiesCount);

                playerObject.PotionsMax = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "PotionsMax: " + playerObject.PotionsMax);
                
                playerObject.PotionsEquipped = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "PotionsEquipped: " + playerObject.PotionsEquipped);

                playerObject.Potions = new List<Potion>(playerObject.PotionsEquipped);
                for (int i = 0; i != playerObject.PotionsEquipped; i++)
                {
                    playerObject.Potions.Add(new Potion
                    {
                        PotionID = readBinary.ReadInt32()
                    });
                }

                playerObject.BirthdayMonth = readBinary.ReadInt32();
                playerObject.BirthdayDay = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "Birthday: " + playerObject.BirthdayDay + "." + playerObject.BirthdayMonth + "." + "1081");

                playerObject.UniquePlayerId = readBinary.ReadUInt32();
                playerObject.UnknownVariable04 = readBinary.ReadInt32();
                playerObject.UnknownVariable05 = readBinary.ReadInt32();
                playerObject.PlayTimeTotal = readBinary.ReadInt32();
                txtConsole.AppendText("\r\nPlayTimeTotal: " + Math.Round((double)playerObject.PlayTimeTotal / 60 / 60 / 60, 2) + " hours");
                playerObject.UnknownVariable06 = readBinary.ReadByte();

                playerObject.UnknownVariable07Count = readBinary.ReadInt16();
                playerObject.UnknownVariables07 = new List<UnknownVariable07>(playerObject.UnknownVariable07Count);
                for (int i = 0; i != playerObject.UnknownVariable07Count; i++)
                {
                    string unknownString = readBinary.ReadString();
                    playerObject.UnknownVariables07.Add(new UnknownVariable07
                    {
                        UnknownString = unknownString, 
                        UnknownFloat = readBinary.ReadSingle()
                    });
                    
                    txtConsole.AppendText("\r\nUnknownstring: " + unknownString);
                }

                playerObject.FlagsCount = readBinary.ReadInt16();
                playerObject.Flags = new List<Flag>(playerObject.FlagsCount);
                for (int i = 0; i != playerObject.FlagsCount; i++)
                {
                    playerObject.Flags.Add(new Flag
                    {
                        FlagID = readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\nFlagsCount: " + playerObject.FlagsCount);

                playerObject.HouseStylesCount = readBinary.ReadByte();
                playerObject.Houses = new List<HouseStyle>(playerObject.HouseStylesCount);
                for (int i = 0; i != playerObject.HouseStylesCount; i++)
                {
                    byte styleNumber = readBinary.ReadByte();
                    int styleLength = readBinary.ReadInt32();
                    byte[] styleBytes = new byte[styleLength];
                    
                    for (int j = 0; j != styleLength; j++)
                    {
                        styleBytes[j] = readBinary.ReadByte();
                    }
                    // add the housestyle to the list
                    playerObject.Houses.Add(new HouseStyle
                    {
                        HouseStyleNumber = styleNumber,
                        HouseStyleLength = styleLength,
                        HouseStyleBytes = styleBytes
                    });
                }
                
                txtConsole.AppendText("\r\nHouseStylesCount: " + playerObject.HouseStylesCount);

                txtConsole.AppendText("\r\nLength: " + readBinary.BaseStream.Length);
                txtConsole.AppendText("\r\nPosition: " + readBinary.BaseStream.Position);
                txtConsole.AppendText("\r\nIs Position and length the same?: " + (readBinary.BaseStream.Position == readBinary.BaseStream.Length).ToString());

                readBinary.Close();
                fileStream.Close();
            }
            txtConsole.AppendText("\r\n");
            
            return playerObject;
        }
        
        public static string GetCharName(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryReader readBinary = new BinaryReader(fileStream);

                readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh    
                readBinary.ReadInt32(); //pPlayer.equip.Hat =
                readBinary.ReadInt32(); //pPlayer.equip.Facegear =
                readBinary.ReadChar(); // pPlayer.style.Bodytype = 
                readBinary.ReadInt32(); //pPlayer.style.Hair = 
                readBinary.ReadInt32(); //pPlayer.equip.Weapon = 
                readBinary.ReadInt32(); //pPlayer.equip.Shield = 
                readBinary.ReadInt32(); //pPlayer.equip.Armor =
                readBinary.ReadInt32(); //pPlayer.equip.Shoes = 
                readBinary.ReadInt32(); //pPlayer.equip.Accessory1 = 
                readBinary.ReadInt32(); //pPlayer.equip.Accessory2 = 
                readBinary.ReadInt32(); //pPlayer.style.Hat = 
                readBinary.ReadInt32(); //pPlayer.style.Facegear = 
                readBinary.ReadInt32(); //pPlayer.style.Weapon = 
                readBinary.ReadInt32(); //pPlayer.style.Shield = 

                readBinary.ReadBoolean(); //pPlayer.style.HatHidden = 
                readBinary.ReadBoolean(); //pPlayer.style.FacegearHidden = 

                readBinary.ReadInt32(); //pPlayer.LastTwoHander =  
                readBinary.ReadInt32(); //pPlayer.LastOneHander =  
                readBinary.ReadInt32(); //pPlayer.LastBow =     

                for (int i = 0; i < 10; i++)
                {
                    int quckslotType = readBinary.ReadByte();
                    if (quckslotType == 1)
                    {
                        readBinary.ReadInt32(); //pPlayer.quickslots.Add((Sog_Items)
                    }
                    else if (quckslotType == 2)
                    {
                        readBinary.ReadUInt16();    //pPlayer.quickslots.Add((Sog_Spells)
                    }
                    else
                    {
                        
                    }
                }

                readBinary.ReadByte();      //pPlayer.style.HairColor = 
                readBinary.ReadByte();      //pPlayer.style.SkinColor = 
                readBinary.ReadByte();      //pPlayer.style.PonchoColor = 
                readBinary.ReadByte();      // pPlayer.style.ShirtColor = 
                readBinary.ReadByte();      //pPlayer.style.PantsColor = 

                readBinary.ReadByte();   //pPlayer.style.Sex = 
                string nickname = readBinary.ReadString();               
                readBinary.Dispose();

                return nickname;
            }
        }
    }
}
