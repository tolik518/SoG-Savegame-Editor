using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Sog_SGreader
{
    public partial class FrmMain : Form
    {
        public FrmMain(string sFilePath)
        {
            InitializeComponent();    //Initializing elements from the Designer
            InitElements(); //Initializing elements from this file
            txtConsole.AppendText("https://github.com/tolik518/SoG_SGreader \r\n");
            txtConsole.AppendText("Support me via Cardano: \r\n");
            txtConsole.AppendText("addr1q8lscf0hrrf883q3ztdlpafge8vp8g6n2mjexhwg5m2nylk48l93aamzj4h9kw6yxpwca2dnkgmf2whqlaw0cym7mzwsrn5hch\r\n");
            txtConsole.AppendText("________________________________________\r\n");
            if (File.Exists(sFilePath))
            {
                LoadSaveGame(sFilePath);
            }
            txtConsole.AppendText("\r\npPlayer.Cash: " + pPlayer.Cash);
        }
        //TODO: When a file is beeing opened, we need to reset als variables
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.ExpandEnvironmentVariables(@"%APPDATA%\Secrets of Grindea\Characters"),
                Filter = "SoG Savegame (*.cha)|*.cha",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
				LoadSaveGame(openFileDialog1.FileName);
            }
        }

        internal void LoadSaveGame(string sFilePath)
        {
           
            txtConsole.AppendText(sFilePath);
            ReadData(sFilePath);
            saveToolStripMenuItem.Enabled = true;

            InitFields();
            PopulateFileds();
        }

        private readonly ComboBox[] cbQuickslot = new ComboBox[10];
        private readonly ComboBox[] cbQuickslotType = new ComboBox[10];

        //TODO: Check out if there is a way to show the items in the designer 
        private void InitElements() //  Designer Items
        {
            int iQuickslotYpos = 262;
            for (int i = 9; i >= 0; i--) // We need 10 comboBoxes for the quickslots and for the types
            {                            // Its nice to have them accesable through an index
                cbQuickslot[i] = new ComboBox
                {
                    FormattingEnabled = true,
                    Location = new Point(180, iQuickslotYpos),
                    Name = $"cbQuickslot[{i}]",
                    Size = new Size(152, 21)
                };

                cbQuickslotType[i] = new ComboBox
                {
                    FormattingEnabled = true,
                    Location = new Point(94, iQuickslotYpos),
                    Name = "cbQuickslotType[i]",
                    Size = new Size(79, 21)
                };
                groupBox3.Controls.Add(cbQuickslotType[i]);
                groupBox3.Controls.Add(cbQuickslot[i]);
                cbQuickslotType[i].SelectedIndexChanged += new System.EventHandler(QuickslotType_SelectedIndexChanged);

                iQuickslotYpos -= 27;
            }
        }

        //this method is responsible to update the content of the Quckslot combobox depending on what
        //was selected in the Type combobox
        private void QuickslotType_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i != 10; i++)
            {
                if (cbQuickslotType[i].Text == "Sog_Items")
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(Sog_Items));
                }
                else if (cbQuickslotType[i].Text == "Sog_Spells")
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(Sog_Skills));
                }
                else
                {
                    cbQuickslot[i].DataSource = null;
                }
                cbQuickslot[i].Text = (pPlayer.quickslots[i]).ToString();
            }
        }

        private void InitFields()
        {
			var items = Enum.GetNames(typeof(Sog_Items));

			//Enum.GetValues(typeof((Enum)Enum.GetNames(typeof(Sog_Items)).Where(item => item.StartsWith("_Hat_"))));
			cbHat.DataSource			= items.Where(item => item.StartsWith("_Hat_") || item == "Null").ToArray();   //TODO
			cbFacegear.DataSource		= items.Where(item => item.StartsWith("_Facegear_") || item == "Null").ToArray();
			cbWeapon.DataSource 		= items.Where(item => item.StartsWith("_OneHanded_") ||
															  item.StartsWith("_TwoHanded_") ||
															  item.StartsWith("_Bow_") || item == "Null").ToArray();

			cbShield.DataSource 		= items.Where(item => item.StartsWith("_Shield_") || item == "Null").ToArray();
			cbArmor.DataSource 		    = items.Where(item => item.StartsWith("_Armor_") || item == "Null").ToArray();
			cbShoes.DataSource 			= items.Where(item => item.StartsWith("_Shoes_") || item == "Null").ToArray();
			cbAccessory1.DataSource 	= items.Where(item => item.StartsWith("_Accessory_") || item == "Null").ToArray();
			cbAccessory2.DataSource 	= items.Where(item => item.StartsWith("_Accessory_") || item == "Null").ToArray();

			cbStyleHat.DataSource 		= items.Where(item => item.StartsWith("_Hat_") || item == "Null").ToArray();
			cbStyleFacegear.DataSource  = items.Where(item => item.StartsWith("_Facegear_") || item == "Null").ToArray();
			cbStyleWeapon.DataSource 	= items.Where(item => item.StartsWith("_OneHanded_") ||
															  item.StartsWith("_TwoHanded_") ||
															  item.StartsWith("_Bow_") || item == "Null").ToArray();
			cbStyleShield.DataSource    = items.Where(item => item.StartsWith("_Shield_") || item == "Null").ToArray();

			/// TODO: I need to check if the quickslotsType field changes to fill out the fields with new items
			for (int i = 0; i != 10; i++)
            {
                if (pPlayer.quickslots[i].GetType() == typeof(Sog_Items))
                {
                    cbQuickslot[i].DataSource = items;
                }
                else if (pPlayer.quickslots[i].GetType() == typeof(Sog_Skills))
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(Sog_Skills));
                }
                cbQuickslotType[i].DataSource = new string[] { "Sog_Items", "Sog_Spells", "Int32" };
            }
            cbSelectedItem.DataSource = items;
        }

        private void PopulateFileds()
        {
            txtNickname.Text = pPlayer.Nickname;

            cbHat.Text = ((Sog_Items)pPlayer.equip.Hat).ToString();
            cbFacegear.Text = ((Sog_Items)pPlayer.equip.Facegear).ToString();
            cbWeapon.Text = ((Sog_Items)pPlayer.equip.Weapon).ToString();
            cbShield.Text = ((Sog_Items)pPlayer.equip.Shield).ToString();
            cbArmor.Text = ((Sog_Items)pPlayer.equip.Armor).ToString();
            cbShoes.Text = ((Sog_Items)pPlayer.equip.Shoes).ToString();

            cbAccessory1.Text = ((Sog_Items)pPlayer.equip.Accessory1).ToString();
            cbAccessory2.Text = ((Sog_Items)pPlayer.equip.Accessory2).ToString();

            cbStyleHat.Text = ((Sog_Items)pPlayer.style.Hat).ToString();
            cbStyleFacegear.Text = ((Sog_Items)pPlayer.style.Facegear).ToString();
            cbStyleWeapon.Text = ((Sog_Items)pPlayer.style.Weapon).ToString();
            cbStyleShield.Text = ((Sog_Items)pPlayer.style.Shield).ToString();

            for (int i = 0; i < 10; i++)
            {
                cbQuickslot[i].Text = pPlayer.quickslots[i].ToString();
                cbQuickslotType[i].Text = (pPlayer.quickslots[i].GetType()).Name.ToString();
            }

            btnHairColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.HairColor).ToString().TrimStart('_'));
            // btnSkinColor.BackColor = ColorTranslator.FromHtml("#" + ((SoG_Colors)iHairColor).ToString().TrimStart('_'));
            btnPonchoColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.PonchoColor).ToString().TrimStart('_'));
            btnShirtColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.ShirtColor).ToString().TrimStart('_'));
            btnPantsColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.PantsColor).ToString().TrimStart('_'));

            for (int i = 0; i != pPlayer.ItemsCount; i++)
            {
                var vItem = new ListViewItem(new[] { pPlayer.Inventory[i].ItemID.ToString(), pPlayer.Inventory[i].ItemCount.ToString(), pPlayer.Inventory[i].ItemPos.ToString() });
                lstInventory.Items.Add(vItem);
            }

            numGold.Value = pPlayer.Cash;

            numLevel.Value = pPlayer.Level;
            numEXPcurrent.Value = pPlayer.EXPCurrent;
            numEXPUnknown0.Value = pPlayer.EXPUnknown0;
            numEXPUnknown1.Value = pPlayer.EXPUnknown1;

            numSkillTalentPoints.Value = pPlayer.SkillTalentPoints;
            numSkillSilverPoints.Value = pPlayer.SkillSilverPoints;
            numSkillGoldPoints.Value = pPlayer.SkillGoldPoints;


            for (int i = 0; i != pPlayer.PetsCount; i++)
            {
                var pPet = new ListViewItem(new[] { pPlayer.Pets[i].Level.ToString(),
                                                    pPlayer.Pets[i].Nickname.ToString(),
                                                    pPlayer.Pets[i].StatHealth.ToString(),
                                                    pPlayer.Pets[i].StatEnergy.ToString(),
                                                    pPlayer.Pets[i].StatDamage.ToString(),
                                                    pPlayer.Pets[i].StatCrit.ToString(),
                                                    pPlayer.Pets[i].StatSpeed.ToString()


                });
                lstPets.Items.Add(pPet);
            }
            txtTimePlayed.Text = TimeSpan.FromSeconds(pPlayer.PlayTimeTotal/60).ToString(@"d\:hh\:mm\:ss");
            numID.Value = pPlayer.UniquePlayerID;
            numBirthdayDay.Value = pPlayer.BirthdayDay;
            numBirtdayMonth.Value = pPlayer.BirthdayMonth;

            sliderSkillMelee1h0.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_OneHanded_Stinger) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_OneHanded_Stinger).SkillLevel : 0 ;
            sliderSkillMelee1h1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_OneHanded_MillionStabs) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_OneHanded_MillionStabs).SkillLevel : 0;
            sliderSkillMelee1h2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_OneHanded_SpiritSlash) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_OneHanded_SpiritSlash).SkillLevel : 0;
            sliderSkillMelee1h3.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_OneHanded_ShadowClone) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_OneHanded_ShadowClone).SkillLevel : 0;
            sliderSkillMelee1h4.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_OneHanded_QuickCounter) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_OneHanded_QuickCounter).SkillLevel : 0;

            sliderSkillMelee2h0.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Overhead) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Overhead).SkillLevel : 0;
            sliderSkillMelee2h1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Spin) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Spin).SkillLevel : 0;
            sliderSkillMelee2h2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Throw) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Throw).SkillLevel : 0;
            sliderSkillMelee2h3.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Smash) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_TwoHanded_Smash).SkillLevel : 0;
            sliderSkillMelee2h4.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Skill_TwoHanded_BerserkMode) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Skill_TwoHanded_BerserkMode).SkillLevel : 0;
        
            sliderSkillMagicF0.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Fire_Fireball) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Fire_Fireball).SkillLevel : 0;
            sliderSkillMagicF1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Fire_Meteor) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Fire_Meteor).SkillLevel : 0;
            sliderSkillMagicF2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Fire_Flamethrower) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Fire_Flamethrower).SkillLevel : 0;

            sliderSkillMagicI0.Value  = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Ice_IceSpikes) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Ice_IceSpikes).SkillLevel : 0;
            sliderSkillMagicI1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Ice_IceNova) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Ice_IceNova).SkillLevel : 0;
            sliderSkillMagicI2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Ice_FrostyFriend) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Ice_FrostyFriend).SkillLevel : 0;

            sliderSkillMagicE0.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Earth_EarthSpike) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Earth_EarthSpike).SkillLevel : 0;
            sliderSkillMagicE1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Earth_SummonPlant) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Earth_SummonPlant).SkillLevel : 0;
            sliderSkillMagicE2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Earth_InsectSwarm) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Earth_InsectSwarm).SkillLevel : 0;

            sliderSkillMagicA0.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Wind_ChainLightning) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Wind_ChainLightning).SkillLevel : 0;
            sliderSkillMagicA1.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Wind_SummonCloud) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Wind_SummonCloud).SkillLevel : 0;
            sliderSkillMagicA2.Value = pPlayer.Skills.Any(x => x.SkillID == Sog_Skills._Magic_Wind_StaticTouch) ? pPlayer.Skills.Find(x => x.SkillID == Sog_Skills._Magic_Wind_StaticTouch).SkillLevel : 0;

        }
        private void InitVariables()    //TODO: we need to clean all our variables before we load a new file 
        {

        }
        private void GetDataFromFields()
        {
            pPlayer.Nickname = txtNickname.Text;
            pPlayer.equip.Hat = (int)Enum.Parse(typeof(Sog_Items), cbHat.Text);
            pPlayer.equip.Facegear = (int)Enum.Parse(typeof(Sog_Items), cbFacegear.Text);
            pPlayer.equip.Weapon = (int)Enum.Parse(typeof(Sog_Items), cbWeapon.Text);
            pPlayer.equip.Shield = (int)Enum.Parse(typeof(Sog_Items), cbShield.Text);
            pPlayer.equip.Armor = (int)Enum.Parse(typeof(Sog_Items), cbArmor.Text);
            pPlayer.equip.Shoes = (int)Enum.Parse(typeof(Sog_Items), cbShoes.Text);

            pPlayer.equip.Accessory1 = (int)Enum.Parse(typeof(Sog_Items), cbAccessory1.Text);
            pPlayer.equip.Accessory2 = (int)Enum.Parse(typeof(Sog_Items), cbAccessory2.Text);

            pPlayer.style.Hat = (int)Enum.Parse(typeof(Sog_Items), cbStyleHat.Text);
            pPlayer.style.Facegear = (int)Enum.Parse(typeof(Sog_Items), cbStyleFacegear.Text);
            pPlayer.style.Weapon = (int)Enum.Parse(typeof(Sog_Items), cbStyleWeapon.Text);
            pPlayer.style.Shield = (int)Enum.Parse(typeof(Sog_Items), cbStyleShield.Text);

            for (int i = 0; i < 10; i++)
            {

                if (cbQuickslotType[i].Text == typeof(Sog_Items).Name.ToString())
                {
                    pPlayer.quickslots[i] = Enum.Parse(typeof(Sog_Items), cbQuickslot[i].Text);
                }
                else if (cbQuickslotType[i].Text == typeof(Sog_Skills).Name.ToString())
                {
                    pPlayer.quickslots[i] = Enum.Parse(typeof(Sog_Skills), cbQuickslot[i].Text);
                }
                else
                {
                    pPlayer.quickslots[i] = (int)0;
                }
            }

            pPlayer.ItemsCount = lstInventory.Items.Count;
            pPlayer.Inventory.Clear();

            for (int i = 0; i != lstInventory.Items.Count; i++)
            {
                Sog_Player.Item iitem = new Sog_Player.Item((Sog_Items)Enum.Parse(typeof(Sog_Items), lstInventory.Items[i].SubItems[0].Text),
                                                                                         Int32.Parse(lstInventory.Items[i].SubItems[1].Text),
                                                                                        UInt32.Parse(lstInventory.Items[i].SubItems[2].Text));
                pPlayer.Inventory.Add(iitem);
            }

            pPlayer.Level = (Int16)numLevel.Value;
            pPlayer.Cash = (int)numGold.Value;
            pPlayer.EXPCurrent = (int)numEXPcurrent.Value;
            pPlayer.EXPUnknown0 = (int)numEXPUnknown0.Value;
            pPlayer.EXPUnknown1 = (int)numEXPUnknown1.Value;

            pPlayer.SkillTalentPoints = (Int16)numSkillTalentPoints.Value;
            pPlayer.SkillSilverPoints = (Int16)numSkillSilverPoints.Value;
            pPlayer.SkillGoldPoints = (Int16)numSkillGoldPoints.Value;

            pPlayer.PetsCount = (byte)lstPets.Items.Count;

            for (byte i = 0; i != pPlayer.PetsCount; i++)
            {
                pPlayer.Pets.Add(new Sog_Player.Pet
                {
                    Type1 = pPlayer.Pets[0].Type1,
                    Type2 = pPlayer.Pets[0].Type2,
                    Nickname = lstPets.Items[i].SubItems[1].Text,
                    Level = Byte.Parse(lstPets.Items[i].SubItems[0].Text),
                    Skin = pPlayer.Pets[0].Skin,

                    StatHealth = UInt16.Parse(lstPets.Items[i].SubItems[2].Text),
                    StatEnergy = UInt16.Parse(lstPets.Items[i].SubItems[3].Text),
                    StatDamage = UInt16.Parse(lstPets.Items[i].SubItems[4].Text),
                    StatCrit =  UInt16.Parse(lstPets.Items[i].SubItems[5].Text),
                    StatSpeed = UInt16.Parse(lstPets.Items[i].SubItems[6].Text),

                    StatProgressHealth = pPlayer.Pets[0].StatProgressHealth,
                    StatProgressEnergy = pPlayer.Pets[0].StatProgressEnergy,
                    StatProgressDamage = pPlayer.Pets[0].StatProgressDamage,
                    StatProgressCrit = pPlayer.Pets[0].StatProgressCrit,
                    StatProgressSpeed = pPlayer.Pets[0].StatProgressSpeed
                });
                pPlayer.Pets.RemoveAt(0);
            }

            pPlayer.UniquePlayerID = (UInt32)numID.Value;
            pPlayer.PlayTimeTotal = (int)(TimeSpan.Parse(txtTimePlayed.Text).TotalSeconds)*60;
            pPlayer.BirthdayDay = (int)numBirthdayDay.Value;
            pPlayer.BirthdayMonth = (int)numBirtdayMonth.Value;
        }

        private readonly Sog_Player pPlayer = new Sog_Player();

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

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sFilename = saveFileDialog1.FileName.ToString();
                if (!File.Exists(sFilename))
                {
                    FileStream fileStream = File.Create(sFilename);      //there should be a better way to do this lol
                    fileStream.Close();
                }

                WriteData(sFilename);
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
                string sColor = form.sColor;

                if (!string.IsNullOrEmpty(sColor))
                {
                    ((Control)sender).BackColor = ColorTranslator.FromHtml(sColor);
                    sColor = "_" + form.sColor.TrimStart('#');

                    if (((Control)sender) == btnHairColor)
                    {
                        pPlayer.style.HairColor = (byte)(Sog_Colors)Enum.Parse(typeof(Sog_Colors), sColor);
                    }
                    else if (((Control)sender) == btnPonchoColor)
                    {
                        pPlayer.style.PonchoColor = (byte)(Sog_Colors)Enum.Parse(typeof(Sog_Colors), sColor);
                    }
                    else if (((Control)sender) == btnShirtColor)
                    {
                        pPlayer.style.ShirtColor = (byte)(Sog_Colors)Enum.Parse(typeof(Sog_Colors), sColor);
                    }
                    else if (((Control)sender) == btnPantsColor)
                    {
                        pPlayer.style.PantsColor = (byte)(Sog_Colors)Enum.Parse(typeof(Sog_Colors), sColor);
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
            numPetHP.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text);
            numPetEnergy.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[3].Text);
            numPetDamage.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[4].Text);
            numPetCrit.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[5].Text);
            numPetSpeed.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[6].Text);

            numPetLevel.Value = Int32.Parse(lstPets.Items[lstPets.FocusedItem.Index].SubItems[0].Text);

            txtPetNickname.Text = lstPets.Items[lstPets.FocusedItem.Index].SubItems[1].Text;

			cbPetType.Text = (Sog_Pets)pPlayer.Pets[lstPets.FocusedItem.Index].Type1 + "";

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

                if (((Control)sender) == numPetHP)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[2].Text = numPetHP.Value.ToString();
                }
                else if (((Control)sender) == numPetEnergy)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[3].Text = numPetEnergy.Value.ToString();
                }
                else if (((Control)sender) == numPetDamage)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[4].Text = numPetDamage.Value.ToString();
                }
                else if (((Control)sender) == numPetCrit)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[5].Text = numPetCrit.Value.ToString();
                }
                else if (((Control)sender) == numPetSpeed)
                {
                    lstPets.Items[lstPets.FocusedItem.Index].SubItems[6].Text = numPetSpeed.Value.ToString();
                }
                else if (((Control)sender) == numPetLevel)
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

        }

        //source: https://www.programmersought.com/article/973286506/
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)  //Skills Menu, makes the Tabs go sidewards
        {
            SolidBrush _Brush = new SolidBrush(Color.Black);//monochrome brush
            RectangleF _TabTextArea = (RectangleF)tabControl1.GetTabRect(e.Index);//Drawing area
            StringFormat _sf = new StringFormat();//Package text layout format information
            _sf.LineAlignment = StringAlignment.Center;
            _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl1.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);

        }

        private void PictureBox3_Click(object sender, EventArgs e) //Cardano Icon in the top corner
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
    }
}
