using SoG_SGreader.Enum;
using SoG_SGreader.Wrapper;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoG_SGreader
{
    public partial class FrmMain : Form
    {
        public static readonly string SupportedPatch = "1.03a";
        public string InstalledGamePatch = "";
        private Player playerObject;
        private readonly ComboBox[] cbQuickslot = new ComboBox[10];
        private readonly ComboBox[] cbQuickslotType = new ComboBox[10];
        private string InitialPlaytime;

        public string OpenedSaveGamePath { get; set; }

        public FrmMain(string saveGamePath)
        {
            InitializeComponent(); //Initializing elements from the Designer
            InitElements(); //Initializing elements from this file
            txtConsole.AppendText("Official Repository: https://github.com/tolik518/SoG_SGreader \r\n");

            if (File.Exists(saveGamePath))
            {
                OpenedSaveGamePath = saveGamePath;
                LoadSaveGame();
            }
            else
            {
                txtConsole.AppendText("Savefile with the following path doesnt exist: " + saveGamePath + "\r\n");
            }
        }
        //TODO: When a file is being opened, we need to reset all variables
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + Path.Combine("Secrets of Grindea", "Characters"),
                Filter = "SoG Savegame (*.cha)|*.cha",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenedSaveGamePath = openFileDialog1.FileName;
                LoadSaveGame();
            }
        }

        private void LoadSaveGame()
        {
            playerObject = new Player();
            lstPets.Items.Clear();
            lstInventory.Items.Clear();

            txtConsole.AppendText(OpenedSaveGamePath);

            // TODO: This is a workaround to get the textbox into the wrapper (for easier testing)
            var txtConsoleWrapped = new UITextBox(txtConsole);
            playerObject = DataReader.ReadFromFile(OpenedSaveGamePath, txtConsoleWrapped);

            saveToolStripMenuItem.Enabled = true;

            InitFields();
            PopulateFields();
        }

        //TODO: Check out if there is a way to show the items in the designer 
        private void InitElements() //  Designer Items
        {
            int iQuickslotYpos = 262;
            for (int i = 9; i >= 0; i--) // We need 10 comboBoxes for the quickslots and for the types
            {                            // Its nice to have them accessible through an index
                cbQuickslot[i] = new ComboBox
                {
                    FormattingEnabled = true,
                    Location = new Point(180, iQuickslotYpos),
                    Name = $"cbQuickslot[{i}]",
                    Size = new Size(152, 21),
                    Enabled = false
                };

                cbQuickslotType[i] = new ComboBox
                {
                    FormattingEnabled = true,
                    Location = new Point(94, iQuickslotYpos),
                    Name = $"cbQuickslotType[{i}]",
                    Size = new Size(79, 21),
                    Enabled = false
                };
                grpQuickslots.Controls.Add(cbQuickslotType[i]);
                grpQuickslots.Controls.Add(cbQuickslot[i]);

                iQuickslotYpos -= 27;
            }
        }

        //this method is responsible to update the content of the Quckslot combobox depending on what
        //was selected in the Type combobox
        private void QuickslotType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var items = GameEnums.SogItem.GetNames().ToArray();
            var skills = System.Enum.GetNames(typeof(SogSkill));

            for (int i = 0; i < 10; i++)
            {
                cbQuickslot[i].DataSource = cbQuickslotType[i].Text switch
                {
                    "SogItem" => items,
                    "SogSpells" => skills,
                    _ => null,
                };
                cbQuickslot[i].Text = playerObject.Quickslots[i].ToString();
            }
        }

        private string[] FilterItems(string[] items, params string[] prefixes)
        {
            return items.Where(item => prefixes.Any(item.StartsWith) || item == "Null").ToArray();
        }

        private void InitFields()
        {
            var items = GameEnums.SogItem.GetNames().ToArray();
            var skills = System.Enum.GetNames(typeof(SogSkill));


            cbHat.DataSource = FilterItems(items, "Hat_");
            cbFacegear.DataSource = FilterItems(items, "Facegear_");
            cbWeapon.DataSource = FilterItems(items, "OneHanded_", "TwoHanded_");
            cbShield.DataSource = FilterItems(items, "Shield_");
            cbArmor.DataSource = FilterItems(items, "Armor_");
            cbShoes.DataSource = FilterItems(items, "Shoes_");
            cbAccessory1.DataSource = FilterItems(items, "Accessory_");
            cbAccessory2.DataSource = FilterItems(items, "Accessory_");
            cbStyleHat.DataSource = FilterItems(items, "Hat_");

            cbStyleFacegear.DataSource = FilterItems(items, "Facegear_");
            cbStyleWeapon.DataSource = FilterItems(items, "OneHanded_", "TwoHanded_");
            cbStyleShield.DataSource = FilterItems(items, "Shield_");

            cbPotion1.DataSource = FilterItems(items, "PotionType_");
            cbPotion2.DataSource = FilterItems(items, "PotionType_");
            cbPotion3.DataSource = FilterItems(items, "PotionType_");

            var quickslotTypes = new[] { "Sog_Items", "Sog_Spells", "Int32" };
            for (int i = 0; i != 10; i++)
            {
                cbQuickslot[i].DataSource = cbQuickslotType[i].Text switch
                {
                    "SogItem" => items,
                    "SogSpells" => skills,
                    _ => null,
                };
                cbQuickslotType[i].DataSource = quickslotTypes;
            }

            cbSelectedItem.DataSource = items;

            //fill checkboxLists with all the values from the enums
            cblstCards.DataSource = System.Enum.GetNames(typeof(SogEnemy));
            cblstQuests.DataSource = System.Enum.GetNames(typeof(SogQuest));
            cblstEnemiesSeens.DataSource = System.Enum.GetNames(typeof(SogEnemy));
            cblstFlags.DataSource = System.Enum.GetNames(typeof(SogFlag));
            cblstMaps.DataSource = System.Enum.GetNames(typeof(SogTreasureMap));
            cblstTrophies.DataSource = System.Enum.GetNames(typeof(SogTrophy));
            cblstItemsSeen.DataSource = GameEnums.SogItem.GetNames().ToArray();
            cblstItemsCrafted.DataSource = GameEnums.SogItem.GetNames().ToArray();
            cblstFishCaught.DataSource = FilterItems(items, "Misc_Fish_");
        }

        private void PopulateFields()
        {
            var items = GameEnums.SogItem.GetNames();


            txtNickname.Text = playerObject.Nickname;

            cbHat.Text = GameEnums.SogItem.GetName(playerObject.Equip.Hat);
            cbFacegear.Text = GameEnums.SogItem.GetName(playerObject.Equip.Facegear);
            cbWeapon.Text = GameEnums.SogItem.GetName(playerObject.Equip.Weapon);
            cbShield.Text = GameEnums.SogItem.GetName(playerObject.Equip.Shield);
            cbArmor.Text = GameEnums.SogItem.GetName(playerObject.Equip.Armor);
            cbShoes.Text = GameEnums.SogItem.GetName(playerObject.Equip.Shoes);

            cbAccessory1.Text = GameEnums.SogItem.GetName(playerObject.Equip.Accessory1);
            cbAccessory2.Text = GameEnums.SogItem.GetName(playerObject.Equip.Accessory2);

            cbStyleHat.Text = GameEnums.SogItem.GetName(playerObject.Style.Hat);
            cbStyleFacegear.Text = GameEnums.SogItem.GetName(playerObject.Style.Facegear);
            cbStyleWeapon.Text = GameEnums.SogItem.GetName(playerObject.Style.Weapon);
            cbStyleShield.Text = GameEnums.SogItem.GetName(playerObject.Style.Shield);

            numPotionsEquipped.Value = playerObject.PotionsEquipped;
            numPotionsMax.Value = playerObject.PotionsMax;

            if (numPotionsEquipped.Value > 0)
            {
                cbPotion1.Text = (playerObject.Potions[0].PotionID).ToString();
                cbPotion1.Enabled = true;
            }

            if (numPotionsEquipped.Value > 1)
            {
                cbPotion2.Text = (playerObject.Potions[1].PotionID).ToString();
                cbPotion2.Enabled = true;
            }

            if (numPotionsEquipped.Value > 2)
            {
                cbPotion3.Text = (playerObject.Potions[2].PotionID).ToString();
                cbPotion3.Enabled = true;
            }

            for (int i = 0; i < 10; i++)
            {
                cbQuickslot[i].Text = playerObject.Quickslots[i].ToString();
                cbQuickslotType[i].Text = (playerObject.Quickslots[i].GetType()).Name.ToString();
            }

            btnHairColor.BackColor = ColorTranslator.FromHtml("#" + ((SogColor)playerObject.Style.HairColor).ToString().TrimStart('_'));
            // btnSkinColor.BackColor = ColorTranslator.FromHtml("#" + ((SoG_Colors)iHairColor).ToString().TrimStart('_'));
            btnPonchoColor.BackColor = ColorTranslator.FromHtml("#" + ((SogColor)playerObject.Style.PonchoColor).ToString().TrimStart('_'));
            btnShirtColor.BackColor = ColorTranslator.FromHtml("#" + ((SogColor)playerObject.Style.ShirtColor).ToString().TrimStart('_'));
            btnPantsColor.BackColor = ColorTranslator.FromHtml("#" + ((SogColor)playerObject.Style.PantsColor).ToString().TrimStart('_'));

            for (int i = 0; i != playerObject.ItemsCount; i++)
            {
                var vItem = new ListViewItem(
                    new[] {
                        GameEnums.SogItem.GetName(playerObject.Inventory[i].ItemID),
                        playerObject.Inventory[i].ItemCount.ToString(),
                        playerObject.Inventory[i].ItemPos.ToString()
                    }
                );

                lstInventory.Items.Add(vItem);
            }

            // KilledEnemies
            for (int i = 0; i != playerObject.KilledEnemiesCount; i++)
            {
                var vKilledEnemy = new ListViewItem(
                    new[]
                    {
                        playerObject.KilledEnemies[i].EnemyID.ToString(),
                        playerObject.KilledEnemies[i].KillCount.ToString()
                    }
                );

                lstEnemiesKilled.Items.Add(vKilledEnemy);
            }

            numGold.Value = playerObject.Cash;       

            numLevel.Value = playerObject.Level;
            numEXPcurrent.Value = playerObject.ExpCurrent;
            numEXPUnknown0.Value = playerObject.ExpUnknown0;
            numEXPUnknown1.Value = playerObject.ExpUnknown1;

            numSkillTalentPoints.Value = playerObject.SkillTalentPoints;
            numSkillSilverPoints.Value = playerObject.SkillSilverPoints;
            numSkillGoldPoints.Value = playerObject.SkillGoldPoints;

            for (int i = 0; i != playerObject.PetsCount; i++)
            {
                var pPet = new ListViewItem(new[] {
                    playerObject.Pets[i].Level.ToString(),
                    playerObject.Pets[i].Nickname.ToString(),
                    playerObject.Pets[i].StatHealth.ToString(),
                    playerObject.Pets[i].StatEnergy.ToString(),
                    playerObject.Pets[i].StatDamage.ToString(),
                    playerObject.Pets[i].StatCrit.ToString(),
                    playerObject.Pets[i].StatSpeed.ToString()
                });

                lstPets.Items.Add(pPet);
            }

            InitialPlaytime = TimeSpan.FromSeconds(playerObject.PlayTimeTotal / 60).ToString(@"d\:hh\:mm\:ss");
            txtTimePlayed.Text = InitialPlaytime;
            numID.Value = playerObject.UniquePlayerId;
            numBirthdayDay.Value = playerObject.BirthdayDay;
            numBirtdayMonth.Value = playerObject.BirthdayMonth;

            rbMale.Checked = playerObject.Style.Sex != 0;
            rbFemale.Checked = playerObject.Style.Sex == 0;


            var skills = getSkillMappings();
            foreach (var skill in skills)
            {
                skill.Field.Value = playerObject.GetSkillLevel(skill.SkillID);
            }

            // find out if player has the card. mark the checkbox if yes
            for (int i = 0; i < cblstCards.Items.Count; i++)
            {
                bool playerHasCard = playerObject.HasCard((SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString()));
                cblstCards.SetItemChecked(i, playerHasCard);
            }

            // find out if player has the Quest. mark the checkbox if yes
            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                bool playerHasQuest = playerObject.HasQuest((SogQuest)System.Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString()));
                cblstQuests.SetItemChecked(i, playerHasQuest);
            }

            for (int i = 0; i < cblstEnemiesSeens.Items.Count; i++)
            {
                bool playerHasMetEnemy = playerObject.HasSeenEnemy((SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString()));
                cblstEnemiesSeens.SetItemChecked(i, playerHasMetEnemy);
            }

            for (int i = 0; i < cblstFlags.Items.Count; i++)
            {
                bool playerHasFlag = playerObject.HasFlag((SogFlag)System.Enum.Parse(typeof(SogFlag), cblstFlags.Items[i].ToString()));
                cblstFlags.SetItemChecked(i, playerHasFlag);
            }

            for (int i = 0; i < cblstMaps.Items.Count; i++)
            {
                bool playerHasMap = playerObject.HasMap((SogTreasureMap)System.Enum.Parse(typeof(SogTreasureMap), cblstMaps.Items[i].ToString()));
                cblstMaps.SetItemChecked(i, playerHasMap);
            }

            for (int i = 0; i < cblstTrophies.Items.Count; i++)
            {
                bool playerHasTrophy = playerObject.HasTrophy((SogTrophy)System.Enum.Parse(typeof(SogTrophy), cblstTrophies.Items[i].ToString()));
                cblstTrophies.SetItemChecked(i, playerHasTrophy);
            }

            for (int i = 0; i < cblstItemsSeen.Items.Count; i++)
            {
                string itemName = cblstItemsSeen.Items[i].ToString();
                int itemValue = GameEnums.SogItem.GetValue(itemName);  // Retrieve the integer value from the enum name.
                bool playerHasSeenItem = playerObject.HasSeenItem(itemValue);
                cblstItemsSeen.SetItemChecked(i, playerHasSeenItem);
            }

            for (int i = 0; i < cblstItemsCrafted.Items.Count; i++)
            {
                bool playerHasCraftedItem = playerObject.HasCraftedItem(GameEnums.SogItem.GetValue(cblstItemsCrafted.Items[i].ToString()));
                cblstItemsCrafted.SetItemChecked(i, playerHasCraftedItem);
            }

            for (int i = 0; i < cblstFishCaught.Items.Count; i++)
            {
                bool playerHasCaughtFish = playerObject.HasCaughtFish(GameEnums.SogItem.GetValue(cblstFishCaught.Items[i].ToString()));
                cblstFishCaught.SetItemChecked(i, playerHasCaughtFish);
            }
        }

        private void GetDataFromFields()
        {
            playerObject.Nickname = txtNickname.Text;
            playerObject.Equip.Hat = GameEnums.SogItem.GetValue(cbHat.Text);
            playerObject.Equip.Facegear = GameEnums.SogItem.GetValue(cbFacegear.Text);
            playerObject.Equip.Weapon = GameEnums.SogItem.GetValue(cbWeapon.Text);
            playerObject.Equip.Shield = GameEnums.SogItem.GetValue(cbShield.Text);
            playerObject.Equip.Armor = GameEnums.SogItem.GetValue(cbArmor.Text);
            playerObject.Equip.Shoes = GameEnums.SogItem.GetValue(cbShoes.Text);

            playerObject.Equip.Accessory1 = GameEnums.SogItem.GetValue(cbAccessory1.Text);
            playerObject.Equip.Accessory2 = GameEnums.SogItem.GetValue(cbAccessory2.Text);

            playerObject.Style.Hat = GameEnums.SogItem.GetValue(cbStyleHat.Text);
            playerObject.Style.Facegear = GameEnums.SogItem.GetValue(cbStyleFacegear.Text);
            playerObject.Style.Weapon = GameEnums.SogItem.GetValue(cbStyleWeapon.Text);
            playerObject.Style.Shield = GameEnums.SogItem.GetValue(cbStyleShield.Text);

            // set the potion for all potions
            playerObject.Potions.Clear();
            if (cbPotion1.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = GameEnums.SogItem.GetValue(cbPotion1.Text) });
            }

            if (cbPotion2.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = GameEnums.SogItem.GetValue(cbPotion2.Text) });
            }

            if (cbPotion3.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = GameEnums.SogItem.GetValue(cbPotion3.Text) });
            }

            /* TODO: Quickslots are not being saved correctly, we need to fix this
            for (int i = 0; i < 10; i++)
            {
                if (cbQuickslotType[i].Text == nameof(SogItems))
                {
                    //playerObject.quickslots[i] = System.Enum.Parse(typeof(Sog_Items), cbQuickslot[i].Text);
                    playerObject.Quickslots[i] = playerObject.Quickslots[i];
                }
                else if (cbQuickslotType[i].Text == nameof(SogSkills))
                {
                    //playerObject.quickslots[i] = System.Enum.Parse(typeof(Sog_Skills), cbQuickslot[i].Text);
                    playerObject.Quickslots[i] = playerObject.Quickslots[i];
                }
                else
                {
                    //playerObject.Quickslots[i] = 0;
                    playerObject.Quickslots[i] = playerObject.Quickslots[i];
            }
            }*/

            playerObject.ItemsCount = lstInventory.Items.Count;
            playerObject.Inventory.Clear();

            for (int i = 0; i != lstInventory.Items.Count; i++)
            {
                Item item = new Item
                {
                    ItemID = GameEnums.SogItem.GetValue(lstInventory.Items[i].SubItems[0].Text),
                    ItemCount = int.Parse(lstInventory.Items[i].SubItems[1].Text),
                    ItemPos = uint.Parse(lstInventory.Items[i].SubItems[2].Text)
                };

                playerObject.Inventory.Add(item);
            }

            playerObject.Level = (Int16)numLevel.Value;
            playerObject.Cash = (int)numGold.Value;
            playerObject.ExpCurrent = (int)numEXPcurrent.Value;
            playerObject.ExpUnknown0 = (int)numEXPUnknown0.Value;
            playerObject.ExpUnknown1 = (int)numEXPUnknown1.Value;

            playerObject.SkillTalentPoints = (Int16)numSkillTalentPoints.Value;
            playerObject.SkillSilverPoints = (Int16)numSkillSilverPoints.Value;
            playerObject.SkillGoldPoints = (Int16)numSkillGoldPoints.Value;

            playerObject.Skills.Clear();
            var skills = getSkillMappings();

            foreach (var skill in skills)
            {
                if (skill.Field.Value != 0)
                {
                    playerObject.Skills.Add(new Skill
                    {
                        SkillID = skill.SkillID,
                        SkillLevel = (byte)skill.Field.Value
                    });
                }
            }

            playerObject.PetsCount = (byte)lstPets.Items.Count;

            for (byte i = 0; i != playerObject.PetsCount; i++)
            {
                playerObject.Pets.Add(new Pet
                {
                    Type1 = playerObject.Pets[0].Type1,
                    Type2 = playerObject.Pets[0].Type2,
                    Nickname = lstPets.Items[i].SubItems[1].Text,
                    Level = Byte.Parse(lstPets.Items[i].SubItems[0].Text),
                    Skin = playerObject.Pets[0].Skin,

                    StatHealth = UInt16.Parse(lstPets.Items[i].SubItems[2].Text),
                    StatEnergy = UInt16.Parse(lstPets.Items[i].SubItems[3].Text),
                    StatDamage = UInt16.Parse(lstPets.Items[i].SubItems[4].Text),
                    StatCrit = UInt16.Parse(lstPets.Items[i].SubItems[5].Text),
                    StatSpeed = UInt16.Parse(lstPets.Items[i].SubItems[6].Text),

                    StatProgressHealth = playerObject.Pets[0].StatProgressHealth,
                    StatProgressEnergy = playerObject.Pets[0].StatProgressEnergy,
                    StatProgressDamage = playerObject.Pets[0].StatProgressDamage,
                    StatProgressCrit = playerObject.Pets[0].StatProgressCrit,
                    StatProgressSpeed = playerObject.Pets[0].StatProgressSpeed
                });
                playerObject.Pets.RemoveAt(0);
            }

            playerObject.UniquePlayerId = (UInt32)numID.Value;

            // dont change the playtime if its not parseable
            if (TimeSpan.TryParse(txtTimePlayed.Text, out TimeSpan result))
            {
                if (result.TotalSeconds > int.MaxValue)
                {
                    txtConsole.AppendText("\r\n\r\nPlaytime is too high. Please check the format.");
                    return;
                }

                // if the playtime was changed, update the playtime
                // was added to prevent rounding errors
                if (InitialPlaytime != txtTimePlayed.Text)
                {
                    playerObject.PlayTimeTotal = Math.Min((int)(result.TotalSeconds * 60), int.MaxValue);
                }
                else
                {
                    playerObject.PlayTimeTotal = playerObject.PlayTimeTotal;
                }
            }
            else
            {
                txtConsole.AppendText("\r\n\r\nPlaytime is not parseable. Please check the format.");
            }

            playerObject.BirthdayDay = (int)numBirthdayDay.Value;
            playerObject.BirthdayMonth = (int)numBirtdayMonth.Value;

            playerObject.Style.Sex = rbMale.Checked ? 1 : 0;

            playerObject.Cards.Clear();
            for (int i = 0; i != cblstCards.Items.Count; i++)
            {
                if (cblstCards.GetItemChecked(i))
                {
                    playerObject.Cards.Add(
                        new Card
                        {
                            CardID = (SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.Quests.Clear();
            for (int i = 0; i != cblstQuests.Items.Count; i++)
            {
                if (cblstQuests.GetItemChecked(i))
                {
                    playerObject.Quests.Add(
                        new Quest
                        {
                            QuestID = (SogQuest)System.Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.EnemiesSeen.Clear();
            for (int i = 0; i != cblstEnemiesSeens.Items.Count; i++)
            {
                if (cblstEnemiesSeens.GetItemChecked(i))
                {
                    playerObject.EnemiesSeen.Add(
                        new Enemy
                        {
                            EnemyID = (SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.Flags.Clear();
            for (int i = 0; i != cblstFlags.Items.Count; i++)
            {
                if (cblstFlags.GetItemChecked(i))
                {
                    playerObject.Flags.Add(
                        new Flag
                        {
                            FlagID = (SogFlag)System.Enum.Parse(typeof(SogFlag), cblstFlags.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.TreasureMaps.Clear();
            for (int i = 0; i != cblstMaps.Items.Count; i++)
            {
                if (cblstMaps.GetItemChecked(i))
                {
                    playerObject.TreasureMaps.Add(
                        new TreasureMap
                        {
                            TreasureMapID = (SogTreasureMap)System.Enum.Parse(typeof(SogTreasureMap), cblstMaps.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.Trophies.Clear();
            for (int i = 0; i != cblstTrophies.Items.Count; i++)
            {
                if (cblstTrophies.GetItemChecked(i))
                {
                    playerObject.Trophies.Add(
                        new Trophy
                        {
                            TrophyID = (SogTrophy)System.Enum.Parse(typeof(SogTrophy), cblstTrophies.Items[i].ToString())
                        }
                     );
                }
            }

            playerObject.ItemsSeen.Clear();
            for (int i = 0; i != cblstItemsSeen.Items.Count; i++)
            {
                if (cblstItemsSeen.GetItemChecked(i))
                {
                    playerObject.ItemsSeen.Add(
                        new ItemSeen
                        {
                            ItemID = GameEnums.SogItem.GetValue(cblstItemsSeen.Items[i].ToString())
                        }
                    );
                }
            }

            playerObject.ItemsCrafted.Clear();
            for (int i = 0; i != cblstItemsCrafted.Items.Count; i++)
            {
                if (cblstItemsCrafted.GetItemChecked(i))
                {
                    playerObject.ItemsCrafted.Add(
                        new ItemCrafted
                        {
                            ItemID = GameEnums.SogItem.GetValue(cblstItemsCrafted.Items[i].ToString())
                        }
                     );
                }
            }

            playerObject.FishCaught.Clear();
            for (int i = 0; i != cblstFishCaught.Items.Count; i++)
            {
                if (cblstFishCaught.GetItemChecked(i))
                {
                    playerObject.FishCaught.Add(
                        new FishCaught
                        {
                            FishID = GameEnums.SogItem.GetValue(cblstFishCaught.Items[i].ToString())
                        }
                     );
                }
            }
        }

        private (NumericUpDown Field, SogSkill SkillID)[] getSkillMappings()
        {
            return new (NumericUpDown Field, SogSkill SkillID)[]
            {
                (numSkillMelee1h0, SogSkill.Skill_OneHanded_Stinger),
                (numSkillMelee1h1, SogSkill.Skill_OneHanded_MillionStabs),
                (numSkillMelee1h2, SogSkill.Skill_OneHanded_SpiritSlash),
                (numSkillMelee1h3, SogSkill.Skill_OneHanded_ShadowClone),
                (numSkillMelee1h4, SogSkill.Skill_OneHanded_QuickCounter),
                (numSkillMelee2h0, SogSkill.Skill_TwoHanded_Overhead),
                (numSkillMelee2h1, SogSkill.Skill_TwoHanded_Spin),
                (numSkillMelee2h2, SogSkill.Skill_TwoHanded_Throw),
                (numSkillMelee2h3, SogSkill.Skill_TwoHanded_Smash),
                (numSkillMelee2h4, SogSkill.Skill_TwoHanded_BerserkMode),

                (numSkillMagicF0, SogSkill.Magic_Fire_Fireball),
                (numSkillMagicF1, SogSkill.Magic_Fire_Meteor),
                (numSkillMagicF2, SogSkill.Magic_Fire_Flamethrower),
                (numSkillMagicI0, SogSkill.Magic_Ice_IceSpikes),
                (numSkillMagicI1, SogSkill.Magic_Ice_IceNova),
                (numSkillMagicI2, SogSkill.Magic_Ice_FrostyFriend),
                (numSkillMagicE0, SogSkill.Magic_Earth_EarthSpike),
                (numSkillMagicE1, SogSkill.Magic_Earth_SummonPlant),
                (numSkillMagicE2, SogSkill.Magic_Earth_InsectSwarm),
                (numSkillMagicA0, SogSkill.Magic_Wind_ChainLightning),
                (numSkillMagicA1, SogSkill.Magic_Wind_SummonCloud),
                (numSkillMagicA2, SogSkill.Magic_Wind_StaticTouch),

                (numUtilityO0, SogSkill.Magic_Support_DeathMark),
                (numUtilityO1, SogSkill.Magic_Support_Stasis),
                (numUtilityO2, SogSkill.Magic_Support_Taunt),
                (numUtilityD0, SogSkill.Magic_Support_Blink),
                (numUtilityD1, SogSkill.Magic_Support_Focus),
                (numUtilityD2, SogSkill.Magic_Support_Barrier),
                (numUtilityE0, SogSkill.Magic_Support_BuffATK),
                (numUtilityE1, SogSkill.Magic_Support_BuffSPD),
                (numUtilityE2, SogSkill.Magic_Support_BuffDEF),

                (numTalentMelee0, SogSkill.Talent_Strength),
                (numTalentMelee1, SogSkill.Talent_Fencer),
                (numTalentMelee2, SogSkill.Talent_Brawler),
                (numTalentMelee3, SogSkill.Talent_BurningWeapon),
                (numTalentMelee4, SogSkill.Talent_ChillyTouch),

                (numTalentMelee5, SogSkill.Talent_SecondWind),
                (numTalentMelee6, SogSkill.Talent_Melee_KnowledgeIsPower),
                (numTalentMelee7, SogSkill.Talent_Wit),
                (numTalentMelee8, SogSkill.Talent_LastBreath),
                (numTalentMelee9, SogSkill.Talent_Backhander),

                (numTalentMelee10, SogSkill.Talent_InsultToInjury),
                (numTalentMelee11, SogSkill.Talent_Melee_BloodThirst),
                (numTalentMelee12, SogSkill.Talent_Melee_ComboStarter),
                (numTalentMelee13, SogSkill.Talent_Melee_SuddenStrike),
                (numTalentMelee14, SogSkill.Talent_Melee_Riposte),

                (numTalentMagic0, SogSkill.Talent_Intelligence),
                (numTalentMagic1, SogSkill.Talent_Magic_FastTalker),
                (numTalentMagic2, SogSkill.Talent_ArcaneCharge),
                (numTalentMagic3, SogSkill.Talent_Prismatic),
                (numTalentMagic4, SogSkill.Talent_Battlemage),

                (numTalentMagic5, SogSkill.Talent_Magic_Concentration),
                (numTalentMagic6, SogSkill.Talent_Turtle),
                (numTalentMagic7, SogSkill.Talent_Magic_SoulEater),
                (numTalentMagic8, SogSkill.Talent_Magic_Specialist),
                (numTalentMagic9, SogSkill.Talent_LastSpark),

                (numTalentMagic10, SogSkill.Talent_Magic_WandMaster),
                (numTalentMagic11, SogSkill.Talent_ArcaneCollar),
                (numTalentMagic12, SogSkill.Talent_CripplingBlast),
                (numTalentMagic13, SogSkill.Talent_Manaburn),
                (numTalentMagic14, SogSkill.Talent_SnapCast),

                (numTalentGeneral0, SogSkill.Talent_Adaptable),
                (numTalentGeneral1, SogSkill.Talent_Tenacious),
                (numTalentGeneral2, SogSkill.Talent_General_HealthInsurance),
                (numTalentGeneral3, SogSkill.Talent_Endurance),
                (numTalentGeneral4, SogSkill.Talent_General_Metabolism),
                (numTalentGeneral5, SogSkill.Talent_Surgeon),
                (numTalentGeneral6, SogSkill.Talent_Brutality),

                (numTalentGeneral7, SogSkill.Talent_General_UtilityFlow),
                (numTalentGeneral8, SogSkill.Talent_General_GotYouCovered),
                (numTalentGeneral9, SogSkill.Talent_LastStand),
                (numTalentGeneral10, SogSkill.Talent_General_SteadyDefense),
                (numTalentGeneral11, SogSkill.Talent_General_LadyLuck),
                (numTalentGeneral12, SogSkill.Talent_General_QuickShot),
                (numTalentGeneral13, SogSkill.Talent_General_AmmoScavenger),

                (numTalentGeneral14, SogSkill.Talent_Multitasking),
                (numTalentGeneral15, SogSkill.Talent_ShieldBearer),
                (numTalentGeneral16, SogSkill.Talent_General_KineticEnergy),
                (numTalentGeneral17, SogSkill.Talent_General_EfficientCounter),
                (numTalentGeneral18, SogSkill.Talent_QuickReflexes),
                (numTalentGeneral19, SogSkill.Talent_FineTaste),
                (numTalentGeneral20, SogSkill.Talent_General_Alchemist),
            };
        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInventory.FocusedItem == null || lstInventory.FocusedItem.Index == -1)
            {
                return;
            }
            cbSelectedItem.Text = lstInventory.Items[lstInventory.FocusedItem.Index].SubItems[0].Text;
            numItemCount.Value = Int32.Parse(lstInventory.Items[lstInventory.FocusedItem.Index].SubItems[1].Text);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sFilename;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Save character",
                DefaultExt = ".cha",
                Filter = "Character files (*.cha)|*.cha|All files (*.*)|*.*",
                RestoreDirectory = true,
                InitialDirectory = Directory.GetParent(OpenedSaveGamePath).FullName
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFilename = saveFileDialog1.FileName;
                if (!File.Exists(sFilename))
                {
                    FileStream fileStream = File.Create(sFilename); //there should be a better way to do this lol
                    fileStream.Close();
                }

                GetDataFromFields();
                DataWriter dataWriter = new DataWriter(playerObject);
                dataWriter.WriteToFile(sFilename);

                txtConsole.AppendText("\r\n\r\nFile was saved successfully under: ");
                txtConsole.AppendText("\r\n" + sFilename);
            }
            else
            {
                txtConsole.AppendText("\r\n\r\nFile was NOT saved.");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private void NumItemCount_ValueChanged(object sender, EventArgs e)
        {
            if (lstInventory.FocusedItem != null)
            {
                lstInventory.Items[lstInventory.FocusedItem.Index].SubItems[1].Text = numItemCount.Value.ToString();
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string sSelectedItem = cbSelectedItem.Text;
            uint maxPos = 0;
            for (int i = 0; i != lstInventory.Items.Count; i++)
            {
                if (UInt32.Parse(lstInventory.Items[i].SubItems[2].Text) > maxPos)
                {
                    maxPos = UInt32.Parse(lstInventory.Items[i].SubItems[2].Text);
                }
            }

            if (lstInventory.FindItemWithText(cbSelectedItem.Text) == null) //look if the item already exists; 
            {
                var vItem = new ListViewItem(new[] { cbSelectedItem.Text, numItemCount.Value.ToString(), (++maxPos).ToString() });
                lstInventory.Items.Add(vItem);
                //Sog_Player.Item iitem = new Sog_Player.Item((Sog_Items)System.Enum.Parse(typeof(Sog_Items), lstInventory.Items[lstInventory.Items.Count - 1].SubItems[0].Text),
                //                                                                 Int32.Parse(lstInventory.Items[lstInventory.Items.Count - 1].SubItems[1].Text),
                //                                                                  UInt32.Parse(lstInventory.Items[lstInventory.Items.Count - 1].SubItems[2].Text));
                //pPlayer.inventory.Add(iitem);
                //pPlayer.InventorySize++;
            }
            lstInventory.EnsureVisible(lstInventory.FindItemWithText(cbSelectedItem.Text).Index);
            lstInventory.Items[lstInventory.FindItemWithText(cbSelectedItem.Text).Index].Selected = true;
            lstInventory.Select();

            cbSelectedItem.Text = sSelectedItem;
        }

        private void ClothingColor_Click(object sender, EventArgs e)
        {
            using (var form = new FrmColorSelect())
            {
                form.ShowDialog();
                string sColor = form.Color;

                if (!string.IsNullOrEmpty(sColor))
                {
                    ((Control)sender).BackColor = ColorTranslator.FromHtml(sColor);
                    sColor = "_" + form.Color.TrimStart('#');

                    if (((Control)sender) == btnHairColor)
                    {
                        playerObject.Style.HairColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnPonchoColor)
                    {
                        playerObject.Style.PonchoColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnShirtColor)
                    {
                        playerObject.Style.ShirtColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnPantsColor)
                    {
                        playerObject.Style.PantsColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                }
            }
            ActiveControl = lblHair; //workarround so the button won't be highlighted anymore
        }

        private void LstPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPets.FocusedItem == null)
            {
                txtPetNickname.Enabled = false;
                return;
            }
            txtPetNickname.Enabled = true;


            int index = lstPets.FocusedItem.Index;
            numPetHP.Value = Int32.Parse(lstPets.Items[index].SubItems[2].Text);
            numPetEnergy.Value = Int32.Parse(lstPets.Items[index].SubItems[3].Text);
            numPetDamage.Value = Int32.Parse(lstPets.Items[index].SubItems[4].Text);
            numPetCrit.Value = Int32.Parse(lstPets.Items[index].SubItems[5].Text);
            numPetSpeed.Value = Int32.Parse(lstPets.Items[index].SubItems[6].Text);

            numPetLevel.Value = Int32.Parse(lstPets.Items[index].SubItems[0].Text);

            txtPetNickname.Text = lstPets.Items[index].SubItems[1].Text;

            cbPetType.Text = ((SogPet)playerObject.Pets[index].Type1).ToString();
        }

        private void BtnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            int i = lstInventory.FocusedItem.Index;
            lstInventory.Items.RemoveAt(i);
        }

        private void NumPetStat_ValueChanged(object sender, EventArgs e)
        {
            if (lstPets.FocusedItem != null)
            {
                lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();

                if ((Control)sender == numPetHP)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();
                }
                else if ((Control)sender == numPetEnergy)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[3].Text = numPetEnergy.Value.ToString();
                }
                else if ((Control)sender == numPetDamage)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[4].Text = numPetDamage.Value.ToString();
                }
                else if ((Control)sender == numPetCrit)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[5].Text = numPetCrit.Value.ToString();
                }
                else if ((Control)sender == numPetSpeed)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[6].Text = numPetSpeed.Value.ToString();
                }
                else if ((Control)sender == numPetLevel)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[0].Text = numPetLevel.Value.ToString();
                }
            }
        }

        private void TxtPetNickname_TextChanged(object sender, EventArgs e)
        {
            lstPets.Items[lstPets.FocusedItem.Index].SubItems[1].Text = txtPetNickname.Text;
        }

        private void JSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "File was saved successfully under\r\n";
            string caption = "Save complete";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            try
            {
                string jsonPath = JsonHandler.SaveGameToJson(playerObject, Directory.GetParent(OpenedSaveGamePath).FullName);
                message += jsonPath;
                txtConsole.AppendText("\r\n\r\n" + message);
            }
            catch (Exception ex)
            {
                message = "There was an error while saving the file. Please check the console for more information.";
                caption = "Error";
                buttons = MessageBoxButtons.OK;
                txtConsole.AppendText("\r\n\r\n" + ex.Message);
            }
            finally
            {
                MessageBox.Show(message, caption, buttons);
            }
        }

        //source: https://www.programmersought.com/article/973286506/
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)  //Skills Menu, makes the Tabs go sidewards
        {
            SolidBrush brush = new SolidBrush(Color.Black); //monochrome brush
            RectangleF tabTextArea = (RectangleF)tabControlSkills.GetTabRect(e.Index); //Drawing area
            StringFormat sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            }; //Package text layout format information

            e.Graphics.DrawString(
                tabControlSkills.Controls[e.Index].Text,
                SystemInformation.MenuFont,
                brush,
                tabTextArea,
                sf
            );
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            String Debug = Debugger.IsAttached ? "[Debug]" : "";
            Text = "SoG: Savegame Editor v" + Application.ProductVersion + " by tolik518 " + Debug;

            ITextBoxWrapper txtConsoleWrapped = new UITextBox(txtConsole);

            try
            {
                var patchVersion = await GamePatchReader.GetCurrentGamePatchAsync(txtConsoleWrapped);
                if (!patchVersion.Equals(SupportedPatch) && !patchVersion.Equals("?.???a"))
                {
                    txtConsole.AppendText("\r\nPlease open an issue on Github or contact me. There is a mismatch between the supported patch and game patch which could lead to potential data loss.");
                }
                lblGamePatch.Text = lblGamePatch.Text.Replace("0.000a", patchVersion);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                lblGamePatch.Text = "?.???a";
                txtConsole.AppendText("\r\n" + ex.Message);
            }
        }

        private void btnResetCards_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstCards.Items.Count; i++)
            {
                bool playerHasCard = playerObject.HasCard((SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString()));
                cblstCards.SetItemChecked(i, playerHasCard);
            }
        }

        private void btnSelectAllCards_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstCards.Items.Count; i++)
            {
                cblstCards.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllCards_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstCards.Items.Count; i++)
            {
                cblstCards.SetItemChecked(i, false);
            }
        }

        private void btnResetQuests_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                bool playerHasQuest = playerObject.HasQuest((SogQuest)System.Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString()));
                cblstQuests.SetItemChecked(i, playerHasQuest);
            }
        }

        private void btnSelectAllQuests_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                cblstQuests.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllQuests_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                cblstQuests.SetItemChecked(i, false);
            }
        }

        private void btnSelectAllEnemiesSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstEnemiesSeens.Items.Count; i++)
            {
                cblstEnemiesSeens.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllEnemiesSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstEnemiesSeens.Items.Count; i++)
            {
                cblstEnemiesSeens.SetItemChecked(i, false);
            }
        }

        private void btnResetEnemiesSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstEnemiesSeens.Items.Count; i++)
            {
                bool playerHasMetEnemy = playerObject.HasSeenEnemy((SogEnemy)System.Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString()));
                cblstEnemiesSeens.SetItemChecked(i, playerHasMetEnemy);
            }
        }

        private void openSavegameFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // dont crash OpenedSaveGamePath is null, just open the default folder
            if (string.IsNullOrEmpty(OpenedSaveGamePath))
            {
                System.Diagnostics.Process.Start(Directory.GetCurrentDirectory());
                return;
            }

            string folderPath = Directory.GetParent(OpenedSaveGamePath).FullName;
            System.Diagnostics.Process.Start(folderPath);
        }

        private void btnSelectAllFlags_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFlags.Items.Count; i++)
            {
                cblstFlags.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllFlags_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFlags.Items.Count; i++)
            {
                cblstFlags.SetItemChecked(i, false);
            }
        }

        private void btnResetFlags_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFlags.Items.Count; i++)
            {
                bool playerHasFlag = playerObject.HasFlag((SogFlag)System.Enum.Parse(typeof(SogFlag), cblstFlags.Items[i].ToString()));
                cblstFlags.SetItemChecked(i, playerHasFlag);
            }
        }

        private void btnSelectAllMaps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstMaps.Items.Count; i++)
            {
                cblstMaps.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllMaps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstMaps.Items.Count; i++)
            {
                cblstMaps.SetItemChecked(i, false);
            }
        }

        private void btnResetMaps_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstMaps.Items.Count; i++)
            {
                bool playerHasMap = playerObject.HasMap((SogTreasureMap)System.Enum.Parse(typeof(SogTreasureMap), cblstMaps.Items[i].ToString()));
                cblstMaps.SetItemChecked(i, playerHasMap);
            }
        }

        private void btnSelectAllTrophies_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstTrophies.Items.Count; i++)
            {
                cblstTrophies.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllTrophies_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstTrophies.Items.Count; i++)
            {
                cblstTrophies.SetItemChecked(i, false);
            }
        }

        private void btnResetTrophies_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstTrophies.Items.Count; i++)
            {
                bool playerHasTrophy = playerObject.HasTrophy((SogTrophy)System.Enum.Parse(typeof(SogTrophy), cblstTrophies.Items[i].ToString()));
                cblstTrophies.SetItemChecked(i, playerHasTrophy);
            }
        }

        private void btnSelectAllItemsSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsSeen.Items.Count; i++)
            {
                cblstItemsSeen.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllItemsSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsSeen.Items.Count; i++)
            {
                cblstItemsSeen.SetItemChecked(i, false);
            }
        }

        private void btnResetItemsSeen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsSeen.Items.Count; i++)
            {
                bool playerHasSeenItem = playerObject.HasSeenItem(GameEnums.SogItem.GetValue(cblstItemsSeen.Items[i].ToString()));
                cblstItemsSeen.SetItemChecked(i, playerHasSeenItem);
            }
        }

        private void btnSelectAllItemsCrafted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsCrafted.Items.Count; i++)
            {
                cblstItemsCrafted.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllItemsCrafted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsCrafted.Items.Count; i++)
            {
                cblstItemsCrafted.SetItemChecked(i, false);
            }
        }

        private void btnResetItemsCrafted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstItemsCrafted.Items.Count; i++)
            {
                bool playerHasCraftedItem = playerObject.HasCraftedItem(GameEnums.SogItem.GetValue(cblstItemsCrafted.Items[i].ToString()));
                cblstItemsCrafted.SetItemChecked(i, playerHasCraftedItem);
            }
        }

        private void btnSelectAllFishCaught_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFishCaught.Items.Count; i++)
            {
                cblstFishCaught.SetItemChecked(i, true);
            }
        }

        private void btnDeselectAllFishCaught_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFishCaught.Items.Count; i++)
            {
                cblstFishCaught.SetItemChecked(i, false);
            }
        }

        private void btnResetFishCaught_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cblstFishCaught.Items.Count; i++)
            {
                bool playerHasCaughtFish = playerObject.HasCaughtFish(GameEnums.SogItem.GetValue(cblstFishCaught.Items[i].ToString()));
                cblstFishCaught.SetItemChecked(i, playerHasCaughtFish);
            }
        }

        private void cblstFlags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (!cblstFlagsChecked.Items.Contains(cblstFlags.Items[e.Index]))
                {
                    cblstFlagsChecked.Items.Add(cblstFlags.Items[e.Index]);
                    cblstFlagsChecked.SetItemChecked(cblstFlagsChecked.Items.Count - 1, true);
                }
            } 
            else if (e.NewValue == CheckState.Unchecked)
            {
                cblstFlagsChecked.Items.RemoveAt(cblstFlagsChecked.Items.IndexOf(cblstFlags.Items[e.Index]));
            }
            
        }

        private void cblstFlagsChecked_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
            {
                cblstFlags.SetItemChecked(
                    cblstFlags.Items.IndexOf(cblstFlagsChecked.Items[e.Index]),
                    false
                );
            }
        }

        private void cbOnlyLegalMeleeSkills_CheckedChanged(object sender, EventArgs e)
        {
            // if checked, only let user select up to the max legal skill level
            // get the max legal skill level from the attribute
            if (cbOnlyLegalLevels.Checked)
            {
                for (int i = 0; i != getSkillMappings().Length; i++)
                {
                    getSkillMappings()[i].Field.Maximum = Skill.GetMaxLevel(getSkillMappings()[i].SkillID);
                }
            }
            else
            {
                for (int i = 0; i != getSkillMappings().Length; i++)
                {
                    getSkillMappings()[i].Field.Maximum = 255;
                }
            }
        }

        private void tabControlSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlSkills.SelectedTab.Controls.Add(cbOnlyLegalLevels);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }
    }
}