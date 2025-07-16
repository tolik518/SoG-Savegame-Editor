using SoG_SGreader.Wrapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoG_SGreader
{
    public partial class FrmMain : Form
    {
        public static readonly string SupportedPatch = "1.10f";
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

            txtConsole.AppendText(OpenedSaveGamePath);

            // TODO: This is a workaround to get the textbox into the wrapper (for easier testing)
            var txtConsoleWrapped = new UITextBox(txtConsole);
            playerObject = SaveGameSerializer.Deserialize(OpenedSaveGamePath, txtConsoleWrapped);

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
            var items = System.Enum.GetNames(typeof(SogItem));
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
            var items = System.Enum.GetNames(typeof(SogItem));
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

            cbAddItem.DataSource = items;

            dataGridCards.AutoGenerateColumns = false;
            dataGridCards.Columns.Clear();
            dataGridCards.DataSource = null;
            dataGridCards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Card",
                DataPropertyName = "Card",
                HeaderText = "Card",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 70,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray }
            });
            dataGridCards.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CardCount",
                DataPropertyName = "CardCount",
                HeaderText = "Card Count",
                ReadOnly = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30
            });
            dataGridCards.AllowUserToAddRows = false;

            dataGridInventory.AutoGenerateColumns = false;
            dataGridInventory.Columns.Clear();
            dataGridInventory.DataSource = null;
            dataGridInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemID",
                DataPropertyName = "ItemID",
                HeaderText = "ID",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray }
            });
            dataGridInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemName",
                DataPropertyName = "ItemName",
                HeaderText = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 55,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray }
            });
            dataGridInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemCount",
                DataPropertyName = "ItemCount",
                HeaderText = "Count",
                ReadOnly = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "N0",
                    NullValue = "0",
                }
            });
            dataGridInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemPlusses",
                DataPropertyName = "ItemPlusses",
                HeaderText = "Plusses",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray },
                Visible = false

            });
            dataGridInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ItemPos",
                DataPropertyName = "ItemPos",
                HeaderText = "Position",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 0.00001f,
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.LightGray },
                Visible = false
            });
            dataGridInventory.AllowUserToAddRows = false;

            //fill checkboxLists with all the values from the enums
            dataGridCards.DataSource = System.Enum.GetNames(typeof(SogEnemy))
                .Select(name => new CardViewModel { Card = name, CardCount = 0 })
                .ToList();
            cblstQuests.DataSource = System.Enum.GetNames(typeof(SogQuest));
            cblstEnemiesSeens.DataSource = System.Enum.GetNames(typeof(SogEnemy));
            cblstFlags.DataSource = System.Enum.GetNames(typeof(SogFlag));
            cblstMaps.DataSource = System.Enum.GetNames(typeof(SogTreasureMap));
            cblstTrophies.DataSource = System.Enum.GetNames(typeof(SogTrophy));
            cblstItemsSeen.DataSource = System.Enum.GetNames(typeof(SogItem));
            cblstItemsCrafted.DataSource = System.Enum.GetNames(typeof(SogItem));
            cblstFishCaught.DataSource = System.Enum.GetNames(typeof(SogFish));
        }

        private void PopulateFields()
        {

            txtNickname.Text = playerObject.Nickname;

            cbHat.Text = Item.GetNameById(playerObject.Equip.Hat);
            cbFacegear.Text = Item.GetNameById(playerObject.Equip.Facegear);
            cbWeapon.Text = Item.GetNameById(playerObject.Equip.Weapon);
            cbShield.Text = Item.GetNameById(playerObject.Equip.Shield);
            cbArmor.Text = Item.GetNameById(playerObject.Equip.Armor);
            cbShoes.Text = Item.GetNameById(playerObject.Equip.Shoes);

            cbAccessory1.Text = Item.GetNameById(playerObject.Equip.Accessory1);
            cbAccessory2.Text = Item.GetNameById(playerObject.Equip.Accessory2);

            cbStyleHat.Text = Item.GetNameById(playerObject.Style.Hat);
            cbStyleFacegear.Text = Item.GetNameById(playerObject.Style.Facegear);
            cbStyleWeapon.Text = Item.GetNameById(playerObject.Style.Weapon);
            cbStyleShield.Text = Item.GetNameById(playerObject.Style.Shield);

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

            // add items to dataGridInventory as a datasource
            dataGridInventory.Rows.Clear();
            foreach (var item in playerObject.Inventory)
            {
                dataGridInventory.Rows.Add(
                    (int) item.ID,
                    item.GetItemName(),
                    item.Count,
                    item.Plusses,
                    item.Position
                );
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

            // add card and cardcount to the newly created dataGridCards
            foreach (var card in playerObject.Cards)
            {
                var existingCard = dataGridCards.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(
                        row => row.Cells["Card"].Value.ToString() == card.Key.CardID.ToString()
                    );

                if (existingCard != null) {
                    existingCard.Cells["CardCount"].Value = card.Value;
                }
                else {
                    dataGridCards.Rows.Add(card.Key.CardID.ToString(), card.Value);
                }
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
                bool playerHasSeenItem = playerObject.HasSeenItem((SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsSeen.Items[i].ToString()));
                cblstItemsSeen.SetItemChecked(i, playerHasSeenItem);
            }

            for (int i = 0; i < cblstItemsCrafted.Items.Count; i++)
            {
                bool playerHasCraftedItem = playerObject.HasCraftedItem((SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsCrafted.Items[i].ToString()));
                cblstItemsCrafted.SetItemChecked(i, playerHasCraftedItem);
            }

            for (int i = 0; i < cblstFishCaught.Items.Count; i++)
            {
                bool playerHasCaughtFish = playerObject.HasCaughtFish((SogItem)System.Enum.Parse(typeof(SogItem), cblstFishCaught.Items[i].ToString()));
                cblstFishCaught.SetItemChecked(i, playerHasCaughtFish);
            }
        }

        private void GetDataFromFields()
        {
            playerObject.Nickname = txtNickname.Text;

            // set the potion for all potions
            playerObject.Potions.Clear();
            if (cbPotion1.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = (SogItem)System.Enum.Parse(typeof(SogItem), cbPotion1.Text) });
            }

            if (cbPotion2.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = (SogItem)System.Enum.Parse(typeof(SogItem), cbPotion2.Text) });
            }

            if (cbPotion3.Enabled == true)
            {
                playerObject.Potions.Add(new Potion { PotionID = (SogItem)System.Enum.Parse(typeof(SogItem), cbPotion3.Text) });
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

            // get the data from dataGridInventory
            playerObject.Inventory.Clear();
            int itemsCount = 0;
            foreach (DataGridViewRow row in dataGridInventory.Rows)
            {
                if (
                    row.Cells["ItemCount"].Value == null ||
                    row.Cells["ItemPos"].Value == null)
                {
                    continue;
                }
                itemsCount++;

                SogItem itemId = (SogItem) int.Parse(row.Cells["ItemID"].Value.ToString());

                int itemCount = 0;
                if (int.TryParse(row.Cells["ItemCount"].Value.ToString().Replace(".", ""), out int count))
                {
                    itemCount = count;
                }
                else
                {
                    itemCount = int.MaxValue - 1;
                }

                uint itemPos = uint.Parse(row.Cells["ItemPos"].Value.ToString());

                Item item = new Item
                {
                    ID = itemId,
                    Count = itemCount,
                    Position = itemPos
                };

                playerObject.Inventory.Add(item);
            }
            playerObject.ItemsCount = itemsCount;

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
            foreach (DataGridViewRow row in dataGridCards.Rows)
            {
                if (row.Cells["CardCount"].Value != null && int.TryParse(row.Cells["CardCount"].Value.ToString(), out int cardCount) && cardCount > 0)
                {
                    var cardId = (SogEnemy)System.Enum.Parse(typeof(SogEnemy), row.Cells["Card"].Value.ToString());
                    playerObject.Cards.Add(
                        new KeyValuePair<Card, ushort>(
                            new Card { 
                                CardID = cardId 
                            }, 
                            (ushort)cardCount
                        )
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
                            ItemID = (SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsSeen.Items[i].ToString())
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
                            ItemID = (SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsCrafted.Items[i].ToString())
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
                            FishID = (SogItem)System.Enum.Parse(typeof(SogItem), cblstFishCaught.Items[i].ToString())
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
                    FileStream fileStream = File.Create(sFilename); 
                    fileStream.Close();
                }

                GetDataFromFields();
                SaveGameSerializer.Serialize(playerObject, sFilename);

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

        private void ClothingColor_Click(object sender, EventArgs e)
        {
            using (var form = new FrmColorSelect())
            {
                form.ShowDialog();
                string sColor = form.Color;

                if (!string.IsNullOrEmpty(sColor))
                {
                    Control currentSender = (Control)sender;

                    currentSender.BackColor = ColorTranslator.FromHtml(sColor);
                    sColor = "_" + form.Color.TrimStart('#');

                    if (currentSender == btnHairColor)
                    {
                        playerObject.Style.HairColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (currentSender == btnPonchoColor)
                    {
                        playerObject.Style.PonchoColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (currentSender == btnShirtColor)
                    {
                        playerObject.Style.ShirtColor = (byte)(SogColor)System.Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (currentSender == btnPantsColor)
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

        private void NumPetStat_ValueChanged(object sender, EventArgs e)
        {
            if (lstPets.FocusedItem != null)
            {
                var currentSender = (Control)sender;
                lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();

                if (currentSender == numPetHP)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();
                }
                else if (currentSender == numPetEnergy)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[3].Text = numPetEnergy.Value.ToString();
                }
                else if (currentSender == numPetDamage)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[4].Text = numPetDamage.Value.ToString();
                }
                else if (currentSender == numPetCrit)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[5].Text = numPetCrit.Value.ToString();
                }
                else if (currentSender == numPetSpeed)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[6].Text = numPetSpeed.Value.ToString();
                }
                else if (currentSender == numPetLevel)
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
            // do the same for dataGridCards, but take the number of cards from the playerObject into account
            for (int i = 0; i < dataGridCards.Rows.Count; i++)
            {
                var card = (SogEnemy)System.Enum.Parse(typeof(SogEnemy), dataGridCards.Rows[i].Cells["Card"].Value.ToString());
                int cardCount = playerObject.GetCardCount(card);
                dataGridCards.Rows[i].Cells["CardCount"].Value = cardCount;
            }

        }

        private void btnSelectAllCards_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridCards.Rows.Count; i++)
            {
                var card = (SogEnemy)System.Enum.Parse(typeof(SogEnemy), dataGridCards.Rows[i].Cells["Card"].Value.ToString());
                int cardCount = playerObject.GetCardCount(card);
                if (cardCount == 0)
                {
                    dataGridCards.Rows[i].Cells["CardCount"].Value = 1;
                }
                else
                {
                    dataGridCards.Rows[i].Cells["CardCount"].Value = cardCount;
                }
            }

        }

        private void btnDeselectAllCards_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridCards.Rows.Count; i++)
            {
                dataGridCards.Rows[i].Cells["CardCount"].Value = 0;
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
                Process.Start(Directory.GetCurrentDirectory());
                return;
            }

            string folderPath = Directory.GetParent(OpenedSaveGamePath).FullName;
            Process.Start(folderPath);
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
                bool playerHasSeenItem = playerObject.HasSeenItem((SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsSeen.Items[i].ToString()));
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
                bool playerHasCraftedItem = playerObject.HasCraftedItem((SogItem)System.Enum.Parse(typeof(SogItem), cblstItemsCrafted.Items[i].ToString()));
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
                bool playerHasCaughtFish = playerObject.HasCaughtFish((SogItem)System.Enum.Parse(typeof(SogItem), cblstFishCaught.Items[i].ToString()));
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            uint maxPos = 0;
            // get the highest position in the inventory dataGrid
            foreach (DataGridViewRow row in dataGridInventory.Rows)
            {
                if (row.Cells["ItemPos"].Value != null && uint.TryParse(row.Cells["ItemPos"].Value.ToString(), out uint pos))
                {
                    if (pos > maxPos)
                    {
                        maxPos = pos;
                    }
                }
            }                 

            int plusses = (int)numPlusses.Value;

            SogItem itemIdWithoutPlusses = Item.GetItemByName(cbAddItem.Text);
            SogItem itemId = itemIdWithoutPlusses + (plusses * Item.PlusItemStart);

            // check if itemId exists in the dataGridInventory ID column, if it exists, dont touch and dont update it, just return
            foreach (DataGridViewRow row in dataGridInventory.Rows)
            {
                if (row.Cells["ItemID"].Value != null && int.TryParse(row.Cells["ItemID"].Value.ToString(), out int existingItemId))
                {
                    if (existingItemId == (int)itemId)
                    {
                        txtConsole.AppendText("\r\n" +itemId + " already exists in the inventory");
                        return;
                    }
                }
            }

            var item = new Item
            {
                ID = itemId,
                Count = 1,
                Position = maxPos + 1 // add 1 to the highest position
            };

            dataGridInventory.Rows.Add(
                (int)item.ID,
                item.GetItemName(),
                item.Count,
                item.Plusses,
                item.Position 
            );
        }

        private void btnSkinColor_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(Text + "\r\nSkin color changing is not supported yet. Please open an issue on Github if you want this feature, because I was too lazy to implement it yet.");
        }
    }

    // quick hack, please refactor if you see this :D
    public class CardViewModel
    {
        public string Card { get; set; }
        public int CardCount { get; set; }
    }
}