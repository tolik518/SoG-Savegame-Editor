using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader
{
    public partial class FrmMain : Form
    {
        public static readonly string SupportedPatch = "0.99g";
        public string InstalledGamePatch = "";
        private Player playerObject = new Player();
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
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + Path.Combine("Secrets of Grindea","Characters"),
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
            txtConsole.AppendText(OpenedSaveGamePath);
            InitVariables();
            
            // TODO: This is a workaround to get the textbox into the wrapper (for easier testing)
            ITextBoxWrapper txtConsoleWrapped = new UITextBox(txtConsole);
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
            var items = Enum.GetNames(typeof(SogItem));
            var skills = Enum.GetNames(typeof(SogSkill));

            for (int i = 0; i < 10; i++)
            {
                switch (cbQuickslotType[i].Text)
                {
                    case "SogItem":
                        cbQuickslot[i].DataSource = items;
                        break;
                    case "SogSpells":
                        cbQuickslot[i].DataSource = skills;
                        break;
                    default:
                        cbQuickslot[i].DataSource = null;
                        break;
                }
                cbQuickslot[i].Text = playerObject.Quickslots[i].ToString();
            }
        }

        private string[] FilterItems(string[] items, params string[] prefixes)
        {
            return items.Where(item => prefixes.Any(item.StartsWith) || item == "Null").ToArray();
        }
        
        private void InitFields()
        {
            var items = Enum.GetNames(typeof(SogItem));
            var skills = Enum.GetNames(typeof(SogSkill));

            cbHat.DataSource = FilterItems(items, "Hat_");
            cbFacegear.DataSource = FilterItems(items, "Facegear_");
            cbWeapon.DataSource = FilterItems(items, "OneHanded_", "TwoHanded_", "Bow_");
            cbShield.DataSource = FilterItems(items, "Shield_");
            cbArmor.DataSource = FilterItems(items, "Armor_");
            cbShoes.DataSource = FilterItems(items, "Shoes_");
            cbAccessory1.DataSource = FilterItems(items, "Accessory_");
            cbAccessory2.DataSource = FilterItems(items, "Accessory_");
            cbStyleHat.DataSource = FilterItems(items, "Hat_");
            
            cbStyleFacegear.DataSource = FilterItems(items, "Facegear_");
            cbStyleWeapon.DataSource = FilterItems(items, "OneHanded_", "TwoHanded_", "Bow_");
            cbStyleShield.DataSource = FilterItems(items, "Shield_");

            var quickslotTypes = new[] { "Sog_Items", "Sog_Spells", "Int32" };
            for (int i = 0; i != 10; i++)
            {
                switch (cbQuickslotType[i].Text)
                {
                    case "SogItem":
                        cbQuickslot[i].DataSource = items;
                        break;
                    case "SogSpells":
                        cbQuickslot[i].DataSource = skills;
                        break;
                    default:
                        cbQuickslot[i].DataSource = null;
                        break;
                }

                cbQuickslotType[i].DataSource = quickslotTypes;
            }

            cbSelectedItem.DataSource = items;

            //fill checkboxLists with all the values from the enums
            cblstCards.DataSource = Enum.GetNames(typeof(SogEnemy));
            cblstQuests.DataSource = Enum.GetNames(typeof(SogQuest));
            cblstEnemiesSeens.DataSource = Enum.GetNames(typeof(SogEnemy));
        }

        private void PopulateFields()
        {

            txtNickname.Text = playerObject.Nickname;

            cbHat.Text = ((SogItem)playerObject.Equip.Hat).ToString();
            cbFacegear.Text = ((SogItem)playerObject.Equip.Facegear).ToString();
            cbWeapon.Text = ((SogItem)playerObject.Equip.Weapon).ToString();
            cbShield.Text = ((SogItem)playerObject.Equip.Shield).ToString();
            cbArmor.Text = ((SogItem)playerObject.Equip.Armor).ToString();
            cbShoes.Text = ((SogItem)playerObject.Equip.Shoes).ToString();

            cbAccessory1.Text = ((SogItem)playerObject.Equip.Accessory1).ToString();
            cbAccessory2.Text = ((SogItem)playerObject.Equip.Accessory2).ToString();

            cbStyleHat.Text = ((SogItem)playerObject.Style.Hat).ToString();
            cbStyleFacegear.Text = ((SogItem)playerObject.Style.Facegear).ToString();
            cbStyleWeapon.Text = ((SogItem)playerObject.Style.Weapon).ToString();
            cbStyleShield.Text = ((SogItem)playerObject.Style.Shield).ToString();

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
                        playerObject.Inventory[i].ItemID.ToString(), 
                        playerObject.Inventory[i].ItemCount.ToString(), 
                        playerObject.Inventory[i].ItemPos.ToString() 
                    }
                );

                lstInventory.Items.Add(vItem);
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

            sliderSkillMelee1h0.Value = playerObject.GetSkillLevel(SogSkill.Skill_OneHanded_Stinger);
            sliderSkillMelee1h1.Value = playerObject.GetSkillLevel(SogSkill.Skill_OneHanded_MillionStabs);
            sliderSkillMelee1h2.Value = playerObject.GetSkillLevel(SogSkill.Skill_OneHanded_SpiritSlash);
            sliderSkillMelee1h3.Value = playerObject.GetSkillLevel(SogSkill.Skill_OneHanded_ShadowClone);
            sliderSkillMelee1h4.Value = playerObject.GetSkillLevel(SogSkill.Skill_OneHanded_QuickCounter);

            sliderSkillMelee2h0.Value = playerObject.GetSkillLevel(SogSkill.Skill_TwoHanded_Overhead);
            sliderSkillMelee2h1.Value = playerObject.GetSkillLevel(SogSkill.Skill_TwoHanded_Spin);
            sliderSkillMelee2h2.Value = playerObject.GetSkillLevel(SogSkill.Skill_TwoHanded_Throw);
            sliderSkillMelee2h3.Value = playerObject.GetSkillLevel(SogSkill.Skill_TwoHanded_Smash);
            sliderSkillMelee2h4.Value = playerObject.GetSkillLevel(SogSkill.Skill_TwoHanded_BerserkMode);

            sliderSkillMagicF0.Value = playerObject.GetSkillLevel(SogSkill.Magic_Fire_Fireball);
            sliderSkillMagicF1.Value = playerObject.GetSkillLevel(SogSkill.Magic_Fire_Meteor);
            sliderSkillMagicF2.Value = playerObject.GetSkillLevel(SogSkill.Magic_Fire_Flamethrower);
 
            sliderSkillMagicI0.Value = playerObject.GetSkillLevel(SogSkill.Magic_Ice_IceSpikes);
            sliderSkillMagicI1.Value = playerObject.GetSkillLevel(SogSkill.Magic_Ice_IceNova);
            sliderSkillMagicI2.Value = playerObject.GetSkillLevel(SogSkill.Magic_Ice_FrostyFriend);
 
            sliderSkillMagicE0.Value = playerObject.GetSkillLevel(SogSkill.Magic_Earth_EarthSpike);
            sliderSkillMagicE1.Value = playerObject.GetSkillLevel(SogSkill.Magic_Earth_SummonPlant);
            sliderSkillMagicE2.Value = playerObject.GetSkillLevel(SogSkill.Magic_Earth_InsectSwarm);
 
            sliderSkillMagicA0.Value = playerObject.GetSkillLevel(SogSkill.Magic_Wind_ChainLightning);
            sliderSkillMagicA1.Value = playerObject.GetSkillLevel(SogSkill.Magic_Wind_SummonCloud);
            sliderSkillMagicA2.Value = playerObject.GetSkillLevel(SogSkill.Magic_Wind_StaticTouch);

            // find out if player has the card. mark the checkbox if yes
            for (int i = 0; i < cblstCards.Items.Count; i++)
            {
                bool playerHasCard = playerObject.HasCard((SogEnemy)Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString()));
                cblstCards.SetItemChecked(i, playerHasCard);
            }

            // find out if player has the Quest. mark the checkbox if yes
            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                bool playerHasQuest = playerObject.HasQuest((SogQuest)Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString()));
                cblstQuests.SetItemChecked(i, playerHasQuest);
            }

            for (int i = 0; i < cblstQuests.Items.Count; i++)
            {
                bool playerHasMetEnemy = playerObject.HasSeenEnemy((SogEnemy)Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString()));
                cblstEnemiesSeens.SetItemChecked(i, playerHasMetEnemy);
            }
        }

        //TODO: we need to clean all our variables before we load a new file 
        private void InitVariables() { }

        private void GetDataFromFields()
        {
            playerObject.Nickname = txtNickname.Text;
            playerObject.Equip.Hat = (int)Enum.Parse(typeof(SogItem), cbHat.Text);
            playerObject.Equip.Facegear = (int)Enum.Parse(typeof(SogItem), cbFacegear.Text);
            playerObject.Equip.Weapon = (int)Enum.Parse(typeof(SogItem), cbWeapon.Text);
            playerObject.Equip.Shield = (int)Enum.Parse(typeof(SogItem), cbShield.Text);
            playerObject.Equip.Armor = (int)Enum.Parse(typeof(SogItem), cbArmor.Text);
            playerObject.Equip.Shoes = (int)Enum.Parse(typeof(SogItem), cbShoes.Text);

            playerObject.Equip.Accessory1 = (int)Enum.Parse(typeof(SogItem), cbAccessory1.Text);
            playerObject.Equip.Accessory2 = (int)Enum.Parse(typeof(SogItem), cbAccessory2.Text);

            playerObject.Style.Hat = (int)Enum.Parse(typeof(SogItem), cbStyleHat.Text);
            playerObject.Style.Facegear = (int)Enum.Parse(typeof(SogItem), cbStyleFacegear.Text);
            playerObject.Style.Weapon = (int)Enum.Parse(typeof(SogItem), cbStyleWeapon.Text);
            playerObject.Style.Shield = (int)Enum.Parse(typeof(SogItem), cbStyleShield.Text);

            /* TODO: Quickslots are not being saved correctly, we need to fix this
            for (int i = 0; i < 10; i++)
            {
                if (cbQuickslotType[i].Text == nameof(SogItems))
                {
                    //playerObject.quickslots[i] = Enum.Parse(typeof(Sog_Items), cbQuickslot[i].Text);
                    playerObject.Quickslots[i] = playerObject.Quickslots[i];
                }
                else if (cbQuickslotType[i].Text == nameof(SogSkills))
                {
                    //playerObject.quickslots[i] = Enum.Parse(typeof(Sog_Skills), cbQuickslot[i].Text);
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
                    ItemID = (SogItem)Enum.Parse(typeof(SogItem), lstInventory.Items[i].SubItems[0].Text),
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
            if (TimeSpan.TryParse(txtTimePlayed.Text, out TimeSpan result)) {
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
            } else {
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
                            CardID = (SogEnemy)Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString())
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
                            QuestID = (SogQuest)Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString())
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
                            EnemyID = (SogEnemy)Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString())
                        }
                    );
                }
            }
        }

        private void LstInventory_SelectedIndexChanged(object sender, EventArgs e)
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save character";
            saveFileDialog1.DefaultExt = ".cha";
            saveFileDialog1.Filter = "Character files (*.cha)|*.cha|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Directory.GetParent(OpenedSaveGamePath).FullName;

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
                //Sog_Player.Item iitem = new Sog_Player.Item((Sog_Items)Enum.Parse(typeof(Sog_Items), lstInventory.Items[lstInventory.Items.Count - 1].SubItems[0].Text),
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
                        playerObject.Style.HairColor = (byte)(SogColor)Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnPonchoColor)
                    {
                        playerObject.Style.PonchoColor = (byte)(SogColor)Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnShirtColor)
                    {
                        playerObject.Style.ShirtColor = (byte)(SogColor)Enum.Parse(typeof(SogColor), sColor);
                    }
                    else if (((Control)sender) == btnPantsColor)
                    {
                        playerObject.Style.PantsColor = (byte)(SogColor)Enum.Parse(typeof(SogColor), sColor);
                    }
                }
            }
            ActiveControl = label1; //workarround so the button won't be highlighted anymore
        }

        private void LstPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPets.FocusedItem == null)
            {
                return;
            }

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

                if ((Control) sender == numPetHP)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();
                }
                else if ((Control) sender == numPetEnergy)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[3].Text = numPetEnergy.Value.ToString();
                }
                else if ((Control) sender == numPetDamage)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[4].Text = numPetDamage.Value.ToString();
                }
                else if ((Control)sender == numPetCrit)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[5].Text = numPetCrit.Value.ToString();
                }
                else if ((Control) sender == numPetSpeed)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[6].Text = numPetSpeed.Value.ToString();
                }
                else if ((Control) sender == numPetLevel)
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
            RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index); //Drawing area
            StringFormat sf = new StringFormat(); //Package text layout format information
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(
                tabControl1.Controls[e.Index].Text,
                SystemInformation.MenuFont,
                brush,
                tabTextArea,
                sf
            );
        }

        private void PictureBox3_Click(object sender, EventArgs e) //:3 Icon in the top corner
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }

        private async void FrmMain_Load(object sender, EventArgs e) 
        {
            Text = "SoG: Savegame Editor v" + Application.ProductVersion + " by tolik518";

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
                bool playerHasCard = playerObject.HasCard((SogEnemy)Enum.Parse(typeof(SogEnemy), cblstCards.Items[i].ToString()));
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
                bool playerHasQuest = playerObject.HasQuest((SogQuest)Enum.Parse(typeof(SogQuest), cblstQuests.Items[i].ToString()));
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
                bool playerHasMetEnemy = playerObject.HasSeenEnemy((SogEnemy)Enum.Parse(typeof(SogEnemy), cblstEnemiesSeens.Items[i].ToString()));
                cblstEnemiesSeens.SetItemChecked(i, playerHasMetEnemy);
            }
        }
        
        private void openSavegameFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = Directory.GetParent(OpenedSaveGamePath).FullName;
            System.Diagnostics.Process.Start(folderPath);
        }
    }
}