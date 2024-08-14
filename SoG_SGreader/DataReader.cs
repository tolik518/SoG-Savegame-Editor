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

                playerObject.MagicByte = readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh  
                
                //TODO: Cast to SogItems
                playerObject.Equip.Hat = readBinary.ReadInt32();
                playerObject.Equip.Facegear = readBinary.ReadInt32();
                playerObject.Style.Bodytype = readBinary.ReadChar(); //seems like always B ?    
                txtConsole.AppendText("\r\nBodytype: " + playerObject.Style.Bodytype);
                playerObject.Style.Hair = readBinary.ReadInt32();
                playerObject.Equip.Weapon = readBinary.ReadInt32();
                playerObject.Equip.Shield = readBinary.ReadInt32();
                playerObject.Equip.Armor = readBinary.ReadInt32();
                playerObject.Equip.Shoes = readBinary.ReadInt32();
                playerObject.Equip.Accessory1 = readBinary.ReadInt32();
                playerObject.Equip.Accessory2 = readBinary.ReadInt32();
                playerObject.Style.Hat = readBinary.ReadInt32();
                playerObject.Style.Facegear = readBinary.ReadInt32();
                playerObject.Style.Weapon = readBinary.ReadInt32();
                playerObject.Style.Shield = readBinary.ReadInt32();
                
                playerObject.Style.HatHidden = readBinary.ReadBoolean();     //[Sog_PlayerProperty(16)]
                playerObject.Style.FacegearHidden = readBinary.ReadBoolean();

                //TODO: Cast to SogItems
                playerObject.LastTwoHander = readBinary.ReadInt32();  //last equipped onehander? 
                playerObject.LastOneHander = readBinary.ReadInt32(); //last equipped twohander?   
                playerObject.LastBow = readBinary.ReadInt32(); //last equipped bow?     

                for (int i = 0; i < 10; i++)
                {
                    int quickSlotType = readBinary.ReadByte();
                    txtConsole.AppendText("\r\nquickSlotType: " + quickSlotType);

                    switch (quickSlotType)
                    {
                        case 1:
                            playerObject.Quickslots.Add(readBinary.ReadInt32());
                            break;
                        case 2:
                            playerObject.Quickslots.Add(readBinary.ReadUInt16());
                            break;
                        default:
                            playerObject.Quickslots.Add(0);
                            break;
                    }
                }
                playerObject.Style.HairColor = readBinary.ReadByte();
                playerObject.Style.SkinColor = readBinary.ReadByte();
                playerObject.Style.PonchoColor = readBinary.ReadByte();
                playerObject.Style.ShirtColor = readBinary.ReadByte();
                playerObject.Style.PantsColor = readBinary.ReadByte();

                playerObject.Style.Sex = readBinary.ReadByte();  // female = 0; male = 1
                txtConsole.AppendText("\r\nGender: " + playerObject.Style.Sex);

                playerObject.NicknameLength = readBinary.ReadByte();

                playerObject.Nickname = new string(readBinary.ReadChars(playerObject.NicknameLength));
                txtConsole.AppendText("\r\nNickname: " + playerObject.Nickname);

                playerObject.ItemsCount = readBinary.ReadInt32();

                playerObject.Inventory = new List<Item>(playerObject.ItemsCount);
                for (int i = 0; i != playerObject.ItemsCount; i++)
                {
                    playerObject.Inventory.Add(new Item
                    {
                        ItemID = readBinary.ReadInt32(),
                        ItemCount = readBinary.ReadInt32(),
                        ItemPos = readBinary.ReadUInt32()
                    });
                }

                txtConsole.AppendText("\r\nInventorySize: " + playerObject.ItemsCount);

                playerObject.UnknownVariable0 = readBinary.ReadInt32();   //idk what I am reading here

                playerObject.MerchantItemsCount = readBinary.ReadInt32();     //itemscount by shady merchant

                playerObject.MerchantItems = new List<MerchantItem>(playerObject.MerchantItemsCount);

                for (int i = 0; i != playerObject.MerchantItemsCount; i++)
                {
                    playerObject.MerchantItems.Add(new MerchantItem 
                    {
                        ItemID = (SogItem)readBinary.ReadInt32(),
                        ItemCount = readBinary.ReadInt32()
                    });
                }

                txtConsole.AppendText("\r\nItemCountMerchant: " + playerObject.MerchantItemsCount);
                
                playerObject.CardsCount = readBinary.ReadInt32();     //How many cards do we need to count        
                playerObject.Cards = new List<Card>(playerObject.CardsCount);

                for (int i = 0; i != playerObject.CardsCount; i++)
                {
                    playerObject.Cards.Add(new Card
                    {
                        CardID = (SogEnemy)readBinary.ReadInt32()
                    });
                }
 
                txtConsole.AppendText("\r\nCardsCount: " + playerObject.CardsCount);

                playerObject.TreasureMapsCount = readBinary.ReadInt32();     //How many Treasure Maps do we need to count
                playerObject.TreasureMaps = new List<TreasureMap>(playerObject.TreasureMapsCount);
                for (int i = 0; i != playerObject.TreasureMapsCount; i++)
                {
                    playerObject.TreasureMaps.Add(new TreasureMap
                    { 
                        TreasureMapID = (SogTreasureMap) readBinary.ReadInt16()
                    });
                }

                txtConsole.AppendText("\r\nTreasureMapCount: " + playerObject.TreasureMapsCount);

                playerObject.TreasureFoundCount = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                playerObject.TreasureFound = new List<TreasureFound>(playerObject.TreasureFoundCount);
                for (int i = 0; i != playerObject.TreasureFoundCount; i++)
                {
                    playerObject.TreasureFound.Add(new TreasureFound
                    {
                        TreasureMapID = (SogTreasureMap) readBinary.ReadInt16()
                    });
                }
                txtConsole.AppendText("\r\nUnknownCount: " + playerObject.TreasureFoundCount);

                playerObject.SkillsCount = readBinary.ReadInt32();     //How many Skills do we need to count
                txtConsole.AppendText("\r\n" + "> SkillsCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.Skills = new List<Skill>(playerObject.SkillsCount);
                for (int i = 0; i != playerObject.SkillsCount; i++)
                {
                    var skillID = (SogSkill)readBinary.ReadInt16();
                    var skillLevel = readBinary.ReadByte();
                    playerObject.Skills.Add(new Skill
                    { 
                        SkillID = skillID, 
                        SkillLevel = skillLevel
                    });
                    txtConsole.AppendText("\r\n" + "Skill " + i +": " + skillID.ToString() + " Level " + skillLevel);
                }

                txtConsole.AppendText("\r\nSkillCount: " + playerObject.SkillsCount);


                playerObject.Level = readBinary.ReadInt16();         //Level
                txtConsole.AppendText("\r\n" + "> Level Position: " + readBinary.BaseStream.Position.ToString("X"));

                txtConsole.AppendText("\r\nLevel: " + playerObject.Level);

                playerObject.ExpCurrent = readBinary.ReadInt32();     //currentexp
                playerObject.ExpUnknown0 = readBinary.ReadInt32();     //something exp ?
                playerObject.ExpUnknown1 = readBinary.ReadInt32();     //something exp ?
                txtConsole.AppendText("\r\n" + "ExpUnknown1" + playerObject.ExpCurrent);
                txtConsole.AppendText("\r\n" + "ExpUnknown1" + playerObject.ExpUnknown0);
                txtConsole.AppendText("\r\n" + "ExpUnknown1" + playerObject.ExpUnknown1);

                playerObject.SkillTalentPoints = readBinary.ReadInt16();    //Talent Points
                playerObject.SkillSilverPoints = readBinary.ReadInt16();    //Silver Skill Points
                playerObject.SkillGoldPoints = readBinary.ReadInt16();    //Gold Skill Points
                txtConsole.AppendText("\r\n" + "SkillTalentPoints: " + playerObject.SkillTalentPoints);
                txtConsole.AppendText("\r\n" + "SkillSilverPoints: " + playerObject.SkillSilverPoints);
                txtConsole.AppendText("\r\n" + "SkillGoldPoints: " + playerObject.SkillGoldPoints);
                txtConsole.AppendText("\r\n" + "> SkillGoldPoints Position: " + readBinary.BaseStream.Position.ToString("X"));


                playerObject.Cash = readBinary.ReadInt32();   //cash
                // get the position of the stream in hex, not in int
                txtConsole.AppendText("\r\n" + "> Cash Position: " + readBinary.BaseStream.Position.ToString("X"));
                txtConsole.AppendText("\r\nCash: " + playerObject.Cash);

                playerObject.PetsCount = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "> PetsCount Position: " + readBinary.BaseStream.Position.ToString("X"));
                txtConsole.AppendText("\r\nPetsCount: " + playerObject.PetsCount);

                playerObject.Pets = new List<Pet>(playerObject.PetsCount);
                for (int i = 0; i != playerObject.PetsCount; i++)
                {
                    txtConsole.AppendText("\r\n" + "> Position: " + readBinary.BaseStream.Position.ToString("X"));
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

                txtConsole.AppendText("\r\n" + "> Petsselected Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.PetsSelected = readBinary.ReadInt32();

                txtConsole.AppendText("\r\n" + "> PetHidden Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.PetHidden = readBinary.ReadByte();


                playerObject.QuestsCount = readBinary.ReadUInt16();
                txtConsole.AppendText("\r\n" + "> QuestsCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.Quests = new List<Quest>(playerObject.QuestsCount);
                for (int i = 0; i != playerObject.QuestsCount; i++)
                {
                    playerObject.Quests.Add(new Quest
                    {
                        QuestID = (SogQuest) readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\n" + "QuestsCount: " + playerObject.QuestsCount);

                txtConsole.AppendText("\r\n" + "> EnemiesSeenCount Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.EnemiesSeenCount = readBinary.ReadUInt16();
                playerObject.EnemiesSeen = new List<Enemy>(playerObject.EnemiesSeenCount);
                for (int i = 0; i != playerObject.EnemiesSeenCount; i++)
                {
                    playerObject.EnemiesSeen.Add(new Enemy
                    {
                        EnemyID = (SogEnemy) readBinary.ReadInt32()
                    });
                }
                txtConsole.AppendText("\r\n" + "EnemiesSeenCount: " + playerObject.EnemiesSeenCount);
                txtConsole.AppendText("\r\n" + "> EnemiesSeenCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.UnknownVariable02Count = (UInt16)(readBinary.ReadUInt16() * 16);  // there are X sequences, each 10 bytes long
                txtConsole.AppendText("\r\n" + "UnknownVariable02Count: " + playerObject.UnknownVariable02Count);
                txtConsole.AppendText("\r\n" + "> UnknownVariable02Count Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.UnknownVariables02 = new List<UnknownVariable02>(playerObject.UnknownVariable02Count);
                for (int i = 0; i != playerObject.UnknownVariable02Count; i++)
                {
                    playerObject.UnknownVariables02.Add(new UnknownVariable02
                    {
                        UnknownByte = readBinary.ReadByte()
                    });
                }
                txtConsole.AppendText("\r\n" + "UnknownVariable02Count: " + playerObject.UnknownVariable02Count);
                txtConsole.AppendText("\r\n" + "> Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.RobinBowHighscore = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "RobinBowHighscore: " + playerObject.RobinBowHighscore);
                txtConsole.AppendText("\r\n" + "> RobinBowHighscore Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.TrophiesCount = (ushort)(readBinary.ReadUInt16());
                playerObject.Trophies = new List<Trophy>(playerObject.TrophiesCount);
                for (int i = 0; i != playerObject.TrophiesCount; i++)
                {
                    playerObject.Trophies.Add(new Trophy
                    {
                        TrophyID = (SogTrophy) readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\n" + "TrophiesCount: " + playerObject.TrophiesCount);
                txtConsole.AppendText("\r\n" + "> TrophiesCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.ItemsSeenCount = (UInt16)(readBinary.ReadUInt16());
                txtConsole.AppendText("\r\n" + "ItemsSeenCount: " + playerObject.ItemsSeenCount);
                txtConsole.AppendText("\r\n" + "> ItemsSeenCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.ItemsSeen = new List<ItemSeen>(playerObject.ItemsSeenCount);
                for (int i = 0; i != playerObject.ItemsSeenCount; i++)
                {
                    playerObject.ItemsSeen.Add(new ItemSeen
                    {
                        ItemID = readBinary.ReadInt32()
                    });
                }

                playerObject.ItemsCraftedCount = (UInt16)(readBinary.ReadUInt16());
                txtConsole.AppendText("\r\n" + "ItemsCraftedCount: " + playerObject.ItemsCraftedCount);
                txtConsole.AppendText("\r\n" + "> ItemsCraftedCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.ItemsCrafted = new List<ItemCrafted>(playerObject.ItemsCraftedCount);
                for (int i = 0; i != playerObject.ItemsCraftedCount; i++)
                {
                    playerObject.ItemsCrafted.Add(new ItemCrafted
                    {
                        ItemID = readBinary.ReadInt32()
                    });
                }

                playerObject.FishiesCaughtCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.FishCaught = new List<FishCaught>(playerObject.FishiesCaughtCount);
                txtConsole.AppendText("\r\n" + "FishiesCaughtCount: " + playerObject.FishiesCaughtCount);
                txtConsole.AppendText("\r\n" + "> FishiesCaughtCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                for (int i = 0; i != playerObject.FishiesCaughtCount; i++)
                {
                    playerObject.FishCaught.Add(new FishCaught
                    {
                        FishID = readBinary.ReadInt32()
                    });
                }

                playerObject.KilledEnemiesCount = (UInt16)(readBinary.ReadUInt16());
                playerObject.KilledEnemies = new List<KilledEnemy>(playerObject.KilledEnemiesCount);
                txtConsole.AppendText("\r\n" + "KilledEnemiesCount: " + playerObject.KilledEnemiesCount);
                txtConsole.AppendText("\r\n" + "> KilledEnemiesCount Position: " + readBinary.BaseStream.Position.ToString("X"));

                for (int i = 0; i != playerObject.KilledEnemiesCount; i++)
                {
                    playerObject.KilledEnemies.Add(new KilledEnemy
                    {
                        EnemyID = (SogEnemy) readBinary.ReadInt32(), 
                        KillCount = readBinary.ReadInt32()
                    });
                }

                playerObject.PotionsMax = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "PotionsMax: " + playerObject.PotionsMax);
                txtConsole.AppendText("\r\n" + "> PotionsMax Position: " + readBinary.BaseStream.Position.ToString("X"));

                playerObject.PotionsEquipped = readBinary.ReadByte();
                txtConsole.AppendText("\r\n" + "PotionsEquipped: " + playerObject.PotionsEquipped);
                txtConsole.AppendText("\r\n" + "> PotionsMax Position: " + readBinary.BaseStream.Position.ToString("X"));

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
                txtConsole.AppendText("\r\n" + "BirthdayDay: " + playerObject.BirthdayDay);
                txtConsole.AppendText("\r\n" + "> BirthdayDay Position: " + readBinary.BaseStream.Position.ToString("X"));

                txtConsole.AppendText("\r\n" + "Birthday: " + playerObject.BirthdayDay + "." + playerObject.BirthdayMonth + "." + "1081");

                playerObject.UniquePlayerId = readBinary.ReadUInt32();
                txtConsole.AppendText("\r\n" + "UniquePlayerId: " + playerObject.UniquePlayerId);
                txtConsole.AppendText("\r\n" + "> UniquePlayerId Position: " + readBinary.BaseStream.Position.ToString("X"));
                playerObject.LastAutosave = readBinary.ReadInt32();
                playerObject.SaveUnknown = readBinary.ReadInt32();
                playerObject.PlayTimeTotal = readBinary.ReadInt32();
                txtConsole.AppendText("\r\n" + "PlayTimeTotal: " + playerObject.PlayTimeTotal);
                txtConsole.AppendText("\r\n" + "> PlayTimeTotal Position: " + readBinary.BaseStream.Position.ToString("X"));
                txtConsole.AppendText("\r\nPlayTimeTotal: " + Math.Round((double)playerObject.PlayTimeTotal / 60 / 60 / 60, 2) + " hours");
                playerObject.PhaseShiftStuff = readBinary.ReadByte();

                playerObject.CharacterFlagCount = readBinary.ReadInt16();
                playerObject.CharacterFlags = new List<CharacterFlags>(playerObject.CharacterFlagCount);
                for (int i = 0; i != playerObject.CharacterFlagCount; i++)
                {
                    string unknownString = readBinary.ReadString();
                    playerObject.CharacterFlags.Add(new CharacterFlags
                    {
                        Name = unknownString, 
                        Value = readBinary.ReadSingle()
                    });
                    
                    txtConsole.AppendText("\r\nUnknownstring: " + unknownString);
                }

                playerObject.FlagsCount = readBinary.ReadInt16();
                playerObject.Flags = new List<Flag>(playerObject.FlagsCount);
                for (int i = 0; i != playerObject.FlagsCount; i++)
                {
                    playerObject.Flags.Add(new Flag
                    {
                        FlagID = (SogFlag) readBinary.ReadUInt16()
                    });
                }
                txtConsole.AppendText("\r\nFlagsCount: " + playerObject.FlagsCount);

                playerObject.HouseStylesCount = readBinary.ReadByte();
                playerObject.HouseStyles = new List<HouseStyle>(playerObject.HouseStylesCount);
                for (int i = 0; i != playerObject.HouseStylesCount; i++)
                {
                    byte styleNumber = readBinary.ReadByte();
                    uint styleLength = readBinary.ReadUInt32();
                    byte[] styleBytes = new byte[styleLength];
                    
                    for (int j = 0; j != styleLength; j++)
                    {
                        styleBytes[j] = readBinary.ReadByte();
                    }
                    // add the housestyle to the list
                    playerObject.HouseStyles.Add(new HouseStyle
                    {
                        Number = styleNumber,
                        Length = styleLength,
                        Bytes = styleBytes
                    });
                }
                
                txtConsole.AppendText("\r\nHouseStylesCount: " + playerObject.HouseStylesCount);

                txtConsole.AppendText("\r\nLength: " + readBinary.BaseStream.Length);
                txtConsole.AppendText("\r\nPosition: " + readBinary.BaseStream.Position.ToString("X"));
                txtConsole.AppendText("\r\nIs Position and length the same?: " + (readBinary.BaseStream.Position == readBinary.BaseStream.Length).ToString());

                readBinary.Close();
                fileStream.Close();
            }
            txtConsole.AppendText("\r\n");
            
            return playerObject;
        }

        public static PlayerPreview GetPlayerPreview(string fileName)
        {
            string nickname = "";
            bool sex = false;
            try {
                using FileStream fileStream = new FileStream(fileName, FileMode.Open);
                BinaryReader readBinary = new BinaryReader(fileStream);

                readBinary.ReadInt32();    
                readBinary.ReadInt32(); //equip.Hat
                readBinary.ReadInt32(); //equip.Facegear
                readBinary.ReadChar();  //style.Bodytype 
                readBinary.ReadInt32(); //style.Hair 
                readBinary.ReadInt32(); //equip.Weapon
                readBinary.ReadInt32(); //equip.Shield
                readBinary.ReadInt32(); //equip.Armor
                readBinary.ReadInt32(); //equip.Shoes
                readBinary.ReadInt32(); //equip.Accessory1
                readBinary.ReadInt32(); //equip.Accessory2
                readBinary.ReadInt32(); //style.Hat
                readBinary.ReadInt32(); //style.Facegear  
                readBinary.ReadInt32(); //style.Weapon  
                readBinary.ReadInt32(); //style.Shield

                readBinary.ReadBoolean(); //style.HatHidden
                readBinary.ReadBoolean(); //style.FacegearHidde 

                readBinary.ReadInt32(); //LastTwoHander 
                readBinary.ReadInt32(); //LastOneHander 
                readBinary.ReadInt32(); //LastBow     

                for (int i = 0; i < 10; i++)
                {
                    int quckslotType = readBinary.ReadByte();
                    if (quckslotType == 1)
                    {
                        readBinary.ReadInt32(); //SogItem
                    }
                    else if (quckslotType == 2)
                    {
                        readBinary.ReadUInt16(); //SogSkill
                    }
                }

                readBinary.ReadByte(); //style.HairColor
                readBinary.ReadByte(); //style.SkinColor
                readBinary.ReadByte(); //style.PonchoColor
                readBinary.ReadByte(); //style.ShirtColor
                readBinary.ReadByte(); //style.PantsColor

                sex = readBinary.ReadBoolean();
                nickname = readBinary.ReadString();
                readBinary.Dispose();
            }
            catch (Exception)
            {
                nickname = "[!ERROR!]";
                sex = false;
            }
            
            return new PlayerPreview { Sex = sex, Nickname = nickname};
        }
    
        public static World ReadWorldFromFile(string fileName, ITextBoxWrapper txtConsole)
        {
            World worldObject = new World();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryReader readBinary = new BinaryReader(fileStream);

                worldObject.MagicByte = readBinary.ReadInt32();
                worldObject.SavePointId = readBinary.ReadInt32(); 
                worldObject.QuestsCount = readBinary.ReadInt32();  
                worldObject.Quests = new List<Quest>(worldObject.QuestsCount);
                for (int i = 0; i != worldObject.QuestsCount; i++)
                {
                    var currentObjectiveGroup = readBinary.ReadByte();

                }
                readBinary.Close();
                fileStream.Close();
            }
            return worldObject;
        }


    }
}
