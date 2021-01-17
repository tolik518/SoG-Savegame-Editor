using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SoG_SGreader
{
    public partial class FrmMain : Form
    {
        public FrmMain(string sFilePath)
        {
            InitializeComponent();    //Initializing elements from the Designer
            InitElements(); //Initializing elements from this file
            if (File.Exists(sFilePath))
            {
                LoadSaveGame(sFilePath);
            }
            txtConsole.AppendText("\r\nlstInventory.Items.Count: " + lstInventory.Items.Count);
            txtConsole.AppendText("\r\npPlayer.InventorySize: " + pPlayer.InventorySize);
            txtConsole.AppendText("\r\npPlayer.inventory.Length: " + pPlayer._inventory.Count);
        }
        //TODO: When a file is beeing opened, we need to reset als variablesrk 
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
            try
            {
                txtConsole.AppendText(sFilePath);                
                ReadData(sFilePath);
                saveToolStripMenuItem.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
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
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(_Sog_Items.Other));
                }
                else if (cbQuickslotType[i].Text == "Sog_Spells")
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(Sog_Spells));
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
            cbHat.DataSource = Enum.GetValues(typeof(_Sog_Items.Hat));
            cbFacegear.DataSource = Enum.GetValues(typeof(_Sog_Items.Facegear));
            cbWeapon.DataSource = Enum.GetValues(typeof(_Sog_Items.Weapon));
            cbShield.DataSource = Enum.GetValues(typeof(_Sog_Items.Shield));
            cbArmor.DataSource = Enum.GetValues(typeof(_Sog_Items.Armor));
            cbShoes.DataSource = Enum.GetValues(typeof(_Sog_Items.Shoes));
            cbAccessory1.DataSource = Enum.GetValues(typeof(_Sog_Items.Accessory));
            cbAccessory2.DataSource = Enum.GetValues(typeof(_Sog_Items.Accessory));

            cbStyleHat.DataSource = Enum.GetValues(typeof(_Sog_Items.Hat));
            cbStyleFacegear.DataSource = Enum.GetValues(typeof(_Sog_Items.Facegear));
            cbStyleWeapon.DataSource = Enum.GetValues(typeof(_Sog_Items.Weapon));
            cbStyleShield.DataSource = Enum.GetValues(typeof(_Sog_Items.Shield));

            /// TODO: I need to check if the quickslotsType field changes to fill out the fields with new items
            for (int i = 0; i != 10; i++)
            {
                if (pPlayer.quickslots[i].GetType() == typeof(Sog_Items))
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(_Sog_Items.Other));
                }
                else if (pPlayer.quickslots[i].GetType() == typeof(Sog_Spells))
                {
                    cbQuickslot[i].DataSource = Enum.GetValues(typeof(Sog_Spells));
                }
                cbQuickslotType[i].DataSource = new string[] { "Sog_Items", "Sog_Spells", "Int32" };
            }
            cbSelectedItem.DataSource = Enum.GetValues(typeof(Sog_Items));
        }
        private void PopulateFileds()
        {
            txtNickname.Text = pPlayer.Nickname;

            cbHat.Text = ((_Sog_Items.Hat)pPlayer.equip.Hat).ToString();
            cbFacegear.Text = ((_Sog_Items.Facegear)pPlayer.equip.Facegear).ToString();
            cbWeapon.Text = ((_Sog_Items.Weapon)pPlayer.equip.Weapon).ToString();
            cbShield.Text = ((_Sog_Items.Shield)pPlayer.equip.Shield).ToString();
            cbArmor.Text = ((_Sog_Items.Armor)pPlayer.equip.Armor).ToString();
            cbShoes.Text = ((_Sog_Items.Shoes)pPlayer.equip.Shoes).ToString();

            cbAccessory1.Text = ((_Sog_Items.Accessory)pPlayer.equip.Accessory1).ToString();
            cbAccessory2.Text = ((_Sog_Items.Accessory)pPlayer.equip.Accessory2).ToString();

            cbStyleHat.Text = ((_Sog_Items.Hat)pPlayer.style.Hat).ToString();
            cbStyleFacegear.Text = ((_Sog_Items.Facegear)pPlayer.style.Facegear).ToString();
            cbStyleWeapon.Text = ((_Sog_Items.Weapon)pPlayer.style.Weapon).ToString();
            cbStyleShield.Text = ((_Sog_Items.Shield)pPlayer.style.Shield).ToString();

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

            for (int i = 0; i != pPlayer.InventorySize; i++)
            {
                var vItem = new ListViewItem(new[] { pPlayer._inventory[i].ItemID.ToString(), pPlayer._inventory[i].ItemCount.ToString(), pPlayer._inventory[i].ItemPos.ToString() });
                lstInventory.Items.Add(vItem);
            }

        }

        private void InitVariables()    //TODO: we need to clean all our variables before we load a new file 
        {

        }

        private void GetDataFromFields()
        {
            pPlayer.equip.Hat = (int)Enum.Parse(typeof(_Sog_Items.Hat), cbHat.Text);
            pPlayer.equip.Facegear = (int)Enum.Parse(typeof(_Sog_Items.Facegear), cbFacegear.Text);
            pPlayer.equip.Weapon = (int)Enum.Parse(typeof(_Sog_Items.Weapon), cbWeapon.Text);
            pPlayer.equip.Shield = (int)Enum.Parse(typeof(_Sog_Items.Shield), cbShield.Text);
            pPlayer.equip.Armor = (int)Enum.Parse(typeof(_Sog_Items.Armor), cbArmor.Text);
            pPlayer.equip.Shoes = (int)Enum.Parse(typeof(_Sog_Items.Shoes), cbShoes.Text);

            pPlayer.equip.Accessory1 = (int)Enum.Parse(typeof(_Sog_Items.Accessory), cbAccessory1.Text);
            pPlayer.equip.Accessory2 = (int)Enum.Parse(typeof(_Sog_Items.Accessory), cbAccessory2.Text);

            pPlayer.style.Hat = (int)Enum.Parse(typeof(_Sog_Items.Hat), cbStyleHat.Text);
            pPlayer.style.Facegear = (int)Enum.Parse(typeof(_Sog_Items.Facegear), cbStyleFacegear.Text);
            pPlayer.style.Weapon = (int)Enum.Parse(typeof(_Sog_Items.Weapon), cbStyleWeapon.Text);
            pPlayer.style.Shield = (int)Enum.Parse(typeof(_Sog_Items.Shield), cbStyleShield.Text);

            for (int i = 0; i < 10; i++)
            {

                if (cbQuickslotType[i].Text == typeof(Sog_Items).Name.ToString())
                {
                    pPlayer.quickslots[i] = Enum.Parse(typeof(Sog_Items), cbQuickslot[i].Text);
                }
                else if (cbQuickslotType[i].Text == typeof(Sog_Spells).Name.ToString())
                {
                    pPlayer.quickslots[i] = Enum.Parse(typeof(Sog_Spells), cbQuickslot[i].Text);
                }
                else
                {
                    pPlayer.quickslots[i] = (int)0;
                }
            }

            // btnHairColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.HairColor).ToString().TrimStart('_'));
            // btnSkinColor.BackColor = ColorTranslator.FromHtml("#" + ((SoG_Colors)iHairColor).ToString().TrimStart('_'));
            // btnPonchoColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.PonchoColor).ToString().TrimStart('_'));
            // btnShirtColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.ShirtColor).ToString().TrimStart('_'));
            // btnPantsColor.BackColor = ColorTranslator.FromHtml("#" + ((Sog_Colors)pPlayer.style.PantsColor).ToString().TrimStart('_'));
            pPlayer.InventorySize = lstInventory.Items.Count;

            
            
            for (int i = 0; i != lstInventory.Items.Count; i++)
            {
                Sog_Player.Inventory iitem = new Sog_Player.Inventory((Sog_Items)Enum.Parse(typeof(Sog_Items), lstInventory.Items[i].SubItems[0].Text),
                                                                                Int32.Parse(lstInventory.Items[i].SubItems[1].Text), 
                                                                               UInt32.Parse(lstInventory.Items[i].SubItems[2].Text));
                pPlayer._inventory.Add(iitem);

            }
        }

        private readonly Sog_Player pPlayer = new Sog_Player();

        private void WriteData(string fileName)
        {
            BinaryWriter writeBinary = new BinaryWriter(File.Open(fileName, FileMode.Create));
            GetDataFromFields();
            writeBinary.Write(pPlayer.magicByte);
            writeBinary.Write(pPlayer.equip.Hat);
            writeBinary.Write(pPlayer.equip.Facegear);
            writeBinary.Write(pPlayer.style.Bodytype);
            writeBinary.Write(pPlayer.style.Hair);
            writeBinary.Write(pPlayer.equip.Weapon);
            writeBinary.Write(pPlayer.equip.Shield);
            writeBinary.Write(pPlayer.equip.Armor);
            writeBinary.Write(pPlayer.equip.Shoes);
            writeBinary.Write(pPlayer.equip.Accessory1);
            writeBinary.Write(pPlayer.equip.Accessory2);
            writeBinary.Write(pPlayer.style.Hat);
            writeBinary.Write(pPlayer.style.Facegear);
            writeBinary.Write(pPlayer.style.Weapon);
            writeBinary.Write(pPlayer.style.Shield);
            writeBinary.Write(pPlayer.style.HatHidden);
            writeBinary.Write(pPlayer.style.FacegearHidden);
            writeBinary.Write(pPlayer.LastTwoHander);
            writeBinary.Write(pPlayer.LastOneHander);
            writeBinary.Write(pPlayer.LastBow);

            foreach (object quickslot in pPlayer.quickslots)
            {
                if (quickslot.GetType() == typeof(SoG_SGreader.Sog_Items))
                {
                    writeBinary.Write((byte)1);
                    writeBinary.Write((Int32)quickslot);
                }
                else if (quickslot.GetType() == typeof(SoG_SGreader.Sog_Spells))
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
            //writeBinary.Write((byte)pPlayer.nicknameLength);
            writeBinary.Write(pPlayer.Nickname);
            writeBinary.Write(pPlayer.InventorySize);
            for (int i = 0; i != pPlayer.InventorySize; i++)
            {
                writeBinary.Write((Int32)pPlayer._inventory[i].ItemID);
                writeBinary.Write((Int32)pPlayer._inventory[i].ItemCount);
                writeBinary.Write((Int32)pPlayer._inventory[i].ItemPos);
            }

            writeBinary.Write(pPlayer.scrap);
            writeBinary.Close();
        }

        private void ReadData(string fileName)
        {
            InitVariables();
            long scrapSize = new FileInfo(fileName).Length;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryReader readBinary = new BinaryReader(fileStream);

                txtConsole.AppendText("\r\nFilesize: " + scrapSize);

                pPlayer.magicByte = readBinary.ReadInt32(); //I dont know yet what the first bytes stand for tbh    
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

                pPlayer.style.HatHidden = readBinary.ReadBoolean();
                pPlayer.style.FacegearHidden = readBinary.ReadBoolean();

                pPlayer.LastTwoHander = readBinary.ReadInt32();  //last equipped onehander? 
                pPlayer.LastOneHander = readBinary.ReadInt32(); //last equipped twohander?   
                pPlayer.LastBow = readBinary.ReadInt32(); //last equipped bow?              
                scrapSize -= 71; //count of bytes that were read already

                for (int i = 0; i < 10; i++)
                {
                    int iQs_ID = readBinary.ReadByte();
                    if (iQs_ID == 1)
                    {
                        pPlayer.quickslots.Add((Sog_Items)readBinary.ReadInt32());
                        scrapSize -= 4;
                    }
                    else if (iQs_ID == 2)
                    {
                        pPlayer.quickslots.Add((Sog_Spells)readBinary.ReadUInt16());
                        scrapSize -= 2;
                    }
                    else
                    {
                        pPlayer.quickslots.Add(0);
                        scrapSize -= 2;
                    }
                }

                pPlayer.style.HairColor = readBinary.ReadByte();    
                pPlayer.style.SkinColor = readBinary.ReadByte();   
                pPlayer.style.PonchoColor = readBinary.ReadByte(); 
                pPlayer.style.ShirtColor = readBinary.ReadByte();   
                pPlayer.style.PantsColor = readBinary.ReadByte();   

                pPlayer.style.Sex = readBinary.ReadByte();         

                pPlayer.NicknameLength = readBinary.ReadByte();   
                scrapSize -= 7;

                pPlayer.Nickname = new string(readBinary.ReadChars(pPlayer.NicknameLength));
                scrapSize -= pPlayer.NicknameLength;

                pPlayer.InventorySize = readBinary.ReadInt32();
                scrapSize -= 4;

                pPlayer._inventory = new List<Sog_Player.Inventory>(pPlayer.InventorySize);
                for (int i = 0; i != pPlayer.InventorySize; i++)
                {
                    Sog_Player.Inventory iitem = new Sog_Player.Inventory((Sog_Items)readBinary.ReadInt32(), (int)readBinary.ReadInt32(), readBinary.ReadUInt32());
                    pPlayer._inventory.Add(iitem);
                   
                    scrapSize -= 12;
                }
                scrapSize -= 4;



                //TODO: ADD SERIALIZATION COUNTERPART
                /*
                readBinary.ReadInt32();   //idk
                scrapSize -= 4;

                int iItemCountMerchant = 0;
                iItemCountMerchant = readBinary.ReadInt32();     //itemscount by shady merchant
                scrapSize -= 4;
                for (int i = 0; i != iItemCountMerchant; i++)
                {
                    readBinary.ReadInt32();    //Item ID
                    readBinary.ReadInt32();     //Item Count
                    scrapSize -= 8;
                }
                txtConsole.AppendText("\r\niItemCountMerchant: " + iItemCountMerchant);

                int iCardsCount = 0;
                iCardsCount = readBinary.ReadInt32();     //How many cards do we need to count
                scrapSize -= 4;
                for (int i = 0; i != iCardsCount; i++)
                {
                    readBinary.ReadInt32();    //Card ID
                    scrapSize -= 4;
                }
                txtConsole.AppendText("\r\niCardsCount: " + iCardsCount);

                int iTreasureMapCount = 0;
                iTreasureMapCount = readBinary.ReadInt32();     //How many Treasure Maps do we need to count
                scrapSize -= 4;
                for (int i = 0; i != iTreasureMapCount; i++)
                {
                    readBinary.ReadInt16();    //Treasure Map ID
                    scrapSize -= 2;
                }
                txtConsole.AppendText("\r\niTreasureMapCount: " + iTreasureMapCount);

                int iUnknownCount = 0;
                iUnknownCount = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                for (int i = 0; i != iUnknownCount; i++)
                {
                    readBinary.ReadInt16();    //Unknown
                    scrapSize -= 2;
                }
                txtConsole.AppendText("\r\niUnknownCount: " + iUnknownCount);

                int iSkillCount = 0;
                iSkillCount = readBinary.ReadInt32();     //How many Unknown Int16 do we need to count
                for (int i = 0; i != iUnknownCount; i++)
                {
                    readBinary.ReadInt16();    //Skill ID
                    readBinary.ReadByte();    //Skill Level
                    scrapSize -= 3;
                }
                txtConsole.AppendText("\r\niSkillCount: " + iSkillCount);

                readBinary.ReadByte();         //Level
                scrapSize -= 1;


                readBinary.ReadInt32();     //currentexp
                readBinary.ReadInt32();     //something exp
                readBinary.ReadInt32();     //something exp
                scrapSize -= 12;
                readBinary.ReadInt16();    //Talent Points
                readBinary.ReadInt16();    //Silver Skill Points
                readBinary.ReadInt16();    //Gold Skill Points
                readBinary.ReadInt32();   //cash
                scrapSize -= 10;
                */



                pPlayer.scrap = new byte[(int)scrapSize];
                pPlayer.scrap = readBinary.ReadBytes((int)scrapSize);
                txtConsole.AppendText("\r\nScrapsize: " + scrapSize);

                readBinary.Close();
                fileStream.Close();
            }
        }

        private void LstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstInventory.FocusedItem == null)
            {
                return;
            }
            cbSelectedItem.Text = pPlayer._inventory[lstInventory.FocusedItem.Index].ItemID.ToString();
            numItemCount.Value = pPlayer._inventory[lstInventory.FocusedItem.Index].ItemCount;
        
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
                if(!File.Exists(sFilename))        
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
                pPlayer._inventory[lstInventory.FocusedItem.Index].ItemCount = (int)numItemCount.Value;
                lstInventory.Items[lstInventory.FocusedItem.Index].SubItems[1].Text = numItemCount.Value.ToString();
            }
        }

        //TODO: check for the position
        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            string sSelectedItem = cbSelectedItem.Text;
            if (lstInventory.FindItemWithText(cbSelectedItem.Text) == null) //look if the item already exists; 
            {
                var vItem = new ListViewItem(new[] { cbSelectedItem.Text, numItemCount.Value.ToString(), "99999" });
                lstInventory.Items.Add(vItem);
                Sog_Player.Inventory iitem = new Sog_Player.Inventory((Sog_Items)Enum.Parse(typeof(Sog_Items), lstInventory.Items[lstInventory.Items.Count - 1].SubItems[0].Text),
                                                                                 Int32.Parse(lstInventory.Items[lstInventory.Items.Count - 1].SubItems[1].Text),
                                                                                 UInt32.Parse(lstInventory.Items[lstInventory.Items.Count - 1].SubItems[2].Text));
                pPlayer._inventory.Add(iitem);
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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }



    public enum Sog_Colors : ushort
    {
        _2C1D1D,
        _2E2226,
        _574753,
        _959595,
        _CACACA,
        _E4E4E4,
        _931317,
        _CD2627,
        _DA4E3D,
        _8C3612,
        _B0521C,
        _CB6C17,
        _DE930D,
        _DDB818,
        _EFDC40,
        _3B971A,
        _6FB620,
        _9DD016,
        _255C7A,
        _42B8D3,
        _A2D2DC,
        _252C7A,
        _656CCF,
        _7D8BF4,
        _6C2191,
        _A630D4,
        _C267F2,
        _912174,
        _E320BD,
        _EC7BD9
    }
    public enum Sog_Items
    {
        Null = -1,
        Apple = 0,
        Carrot = 1,
        VegetableJuice = 2,
        _Consumable_Berries = 3,
        _Consumable_HealthPotion = 4,
        _Misc_SpeedPetFood = 5,
        _Misc_ManaPetFood = 6,
        _Misc_DefensePetFood = 7,
        _Misc_DamagePetFood = 8,
        _Usable_ButterflySummoner = 9,
        _Usable_SpringCharm = 10,
        _Usable_SnowflakeCharm = 11,
        _Usable_FaeCharm = 12,
        _Usable_GhostCharm = 13,
        _Usable_CardAlbum = 14,
        _Usable_PhaseReSequencer = 15,
        _Usable_PotionSingle = 0x10,
        _Usable_PotionDuo = 0x11,
        _Usable_PotionTrio = 0x12,
        _Usable_PotionSingleDISPLAY = 0x13,
        _Usable_SpiderCharm = 20,
        _PotionType_Health = 250,
        _PotionType_Crit = 0xfb,
        _PotionType_Damage = 0xfc,
        _PotionType_Spirit = 0xfd,
        _PotionType_Arrow = 0xfe,
        _PotionType_Speed = 0xff,
        _PotionType_Chicken = 0x100,
        _PotionType_LOCKED = 0x101,
        _PotionType_Wealth = 0x102,
        _PotionType_Loot = 0x103,
        _PotionType_EMPTY = 260,
        _PotionType_UNKNOWN = 0x105,
        _PotionType_HealthDISABLED = 0x106,
        _Consumable_FirstItem = 300,
        StickyMucus = 0x2710,
        _Misc_Branch = 0x2711,
        _Misc_Trunk = 0x2712,
        _Misc_Steel = 0x2713,
        _Misc_MickySucus = 0x2714,
        _Misc_Honey = 0x2715,
        _Misc_Fur = 0x2716,
        _Misc_Stinger = 0x2717,
        _Misc_Stick = 0x2718,
        _Misc_Button = 0x2719,
        _Misc_Ectoplasm = 0x271a,
        _Misc_Fabric = 0x271b,
        _Misc_Hay = 0x271c,
        _Misc_Lantern = 0x271d,
        _Misc_PetalBlue = 0x271e,
        _Misc_PetalPurple = 0x271f,
        _Misc_Pollen = 0x2720,
        _Misc_PumpkinMeat = 0x2721,
        _Misc_PumpkinSeeds = 0x2722,
        _Misc_Root = 0x2723,
        _Misc_Sheet = 0x2724,
        _Misc_BagLol = 0x2725,
        _Misc_Tusk = 0x2726,
        _Misc_ToughSkin = 0x2727,
        _Misc_CrystalCrumbs = 0x2728,
        _Misc_PowerCore = 0x2729,
        _Misc_MetalPiece = 0x272a,
        _Misc_Turkey = 0x272b,
        _Misc_PeckoDoll = 0x272c,
        _Misc_PeckoFeather = 0x272d,
        _Misc_GuardianCrystal = 0x272e,
        _Misc_ChickenPlushie = 0x272f,
        _Misc_BasicJarShard = 0x2730,
        _Misc_CyberJarShard = 0x2731,
        _Misc_EmitterMatrix = 0x2732,
        _Misc_SlimeCube = 0x2733,
        _Misc_GiftBox_Consumable = 0x2734,
        _Misc_Icicle = 0x2735,
        _Misc_Orange = 0x2736,
        _Misc_Pinecone = 0x2737,
        _Misc_CandyCane = 0x2738,
        _Misc_IcyGoo = 0x2739,
        _Misc_YetiDoll = 0x273a,
        _Misc_YetiFur = 0x273b,
        _Misc_Season_ArmorScrap = 0x273c,
        _Misc_Season_BrokenGreave = 0x273d,
        _Misc_Season_ShieldPiece = 0x273e,
        _Misc_Season_EmblemAutumn = 0x273f,
        _Misc_Season_EmblemSummer = 0x2740,
        _Misc_Season_EmblemWinter = 0x2741,
        _Misc_Season_MagicalSeasoning = 0x2742,
        _Misc_Season_SeasonShard = 0x2743,
        _Misc_MtBloom_LargeCrystal = 0x2744,
        _Misc_MtBloom_LarvaBall = 0x2745,
        _Misc_MtBloom_LarvaAcid = 0x2746,
        _Misc_MtBloom_CaveMoss = 0x2747,
        _Misc_MtBloom_SmallMushroom = 0x2748,
        _Misc_MtBloom_Silk = 0x2749,
        _Misc_MtBloom_SpinsectLeg = 0x274a,
        _Misc_MtBloom_SpinsectCarapacePart = 0x274b,
        _Misc_MtBloom_MushroomSpores = 0x274c,
        _Misc_RedEmitterMatrix = 0x274d,
        _Misc_PhaseResequencer_Part1 = 0x274e,
        _Misc_PhaseResequencer_Part2 = 0x274f,
        _Misc_PhaseResequencer_Part3 = 0x2750,
        _Misc_TaiMing_AncientRocks = 0x2751,
        _Misc_Bamboo = 0x2752,
        _Misc_UNUSED = 0x2753,
        _Misc_TaiMing_Dandelion = 0x2754,
        _Misc_TaiMing_Dirt = 0x2755,
        _Misc_TaiMing_FabricOfTime = 0x2756,
        _Misc_TaiMing_MossFlower = 0x2757,
        _Misc_TaiMing_Lettuce = 0x2758,
        _Misc_TaiMing_MagicalCore = 0x2759,
        _Misc_TaiMing_MonkeyFur = 0x275a,
        _Misc_TaiMing_WormTeeth = 0x275b,
        _Misc_TaiMing_WormThorn = 0x275c,
        _Misc_TaiMing_PorcelainShard = 0x275d,
        _Misc_TaiMing_WornSoldierDoll = 0x275e,
        _Misc_TaiMing_SwordPiece = 0x275f,
        _Misc_TaiMing_MikiPlushie = 0x2760,
        _Misc_TaiMing_Banana = 0x2761,
        _Misc_CritPetFood = 0x2762,
        _Misc_MtBloom_MagmaSpore = 0x2763,
        _Misc_Desert_Beak = 0x2764,
        _Misc_Desert_CactusFlesh = 0x2765,
        _Misc_Desert_CactusFlower = 0x2766,
        _Misc_Desert_CactusNeedle = 0x2767,
        _Misc_Desert_Orange = 0x2768,
        _Misc_Desert_OrangeGoo = 0x2769,
        _Misc_Desert_Quill = 0x276a,
        _Misc_Desert_FineSand = 0x276b,
        _Misc_Desert_CoarseSand = 0x276c,
        _Misc_Desert_Onion = 0x276d,
        _Misc_Desert_Tomato = 0x276e,
        _Misc_Desert_RecipePage = 0x276f,
        _Misc_GhostShip_Bone = 0x2770,
        _Misc_GhostShip_WarriorCloth = 0x2771,
        _Misc_GhostShip_WizardCloth = 0x2772,
        _Misc_GhostShip_HauntiePurpleEctoplasm = 0x2773,
        _Misc_GhostShip_HauntieFabric = 0x2774,
        _Misc_GhostShip_HauntieTwilightCore = 0x2775,
        _Misc_GhostShip_CrabbyShellPiece = 0x2776,
        INVISIBLE = 0x2903,
        _Furniture_FlyingFortressPainting_OBSOLETE = 0x2904,
        _Furniture_LampCrystal_OBSOLETE = 0x2905,
        _Furniture_LampLantern_OBSOLETE = 0x2906,
        _Furniture_LampGreenSlime_OBSOLETE = 0x2907,
        _Furniture_GigaSlimeBeanbag_OBSOLETE = 0x2908,
        _Furniture_Fireplace_OBSOLETE = 0x2909,
        _Furniture_Clock01_OBSOLETE = 0x290a,
        _Furniture_Plant01_OBSOLETE = 0x290b,
        _Furniture_SlimeCarpet_OBSOLETE = 0x290c,
        _Furniture_BeerBarrel_OBSOLETE = 0x290d,
        _Furniture_FishDisplay_OBSOLETE = 0x290e,
        _Furniture_ChristmasTree_OBSOLETE = 0x290f,
        _Furniture_SeasonTemplePainting_OBSOLETE = 0x2910,
        _Furniture_CatScreen = 0x2911,
        _Furniture_Bonsai_OBSOLETE = 0x2912,
        _Furniture_TaiMingLantern_OBSOLETE = 0x2913,
        _Furniture_WallPlanks_OBSOLETE = 0x2914,
        _Furniture_Carpet_MasterHQBlue = 0x3e8,
        _Furniture_Carpet_MasterHQRed = 0x3e9,
        _Furniture_Carpet_MasterHQGreen = 0x3ea,
        _Furniture_Carpet_FlyingFortressHoleWithGlass = 0x3eb,
        _Furniture_Carpet_HalloweenModular = 0x3ec,
        _Furniture_Carpet_HalloweenBig = 0x3ed,
        _Furniture_Carpet_Seasonne = 0x3ee,
        _Furniture_Carpet_MtBloom = 0x3ef,
        _Furniture_Carpet_TaiMing = 0x3f0,
        _Furniture_Carpet_RedGigaSlimeCarpet = 0x3f1,
        _Furniture_Carpet_DesertunoRed = 0x3f2,
        _Furniture_Carpet_DesertunoGreen = 0x3f3,
        _Furniture_Carpet_DesertunoOrange = 0x3f4,
        _Furniture_Carpet_DesertunoPurple = 0x3f5,
        _Furniture_Carpet_DesertidosRed = 0x3f6,
        _Furniture_Carpet_DesertidosGreen = 0x3f7,
        _Furniture_Carpet_DesertidosOrange = 0x3f8,
        _Furniture_Carpet_DesertidosPurple = 0x3f9,
        _Furniture_Table_BasicLongBlack = 0x5dc,
        _Furniture_Table_BasicLongWhite = 0x5dd,
        _Furniture_Table_BasicLongWood = 0x5de,
        _Furniture_Table_BasicShortWood = 0x5df,
        _Furniture_Table_BasicShortBlack = 0x5e0,
        _Furniture_Table_BasicRoundDark_OBSOLETE = 0x5e1,
        _Furniture_Table_BasicRoundWhite_OBSOLETE = 0x5e2,
        _Furniture_Table_BasicRoundWood_OBSOLETE = 0x5e3,
        _Furniture_Table_BasicBigWood = 0x5e4,
        _Furniture_Table_BedsideHalloween = 0x5e5,
        _Furniture_Table_BedsideFlyingFortress = 0x5e6,
        _Furniture_Table_BedsideTempleOfSeasons = 0x5e7,
        _Furniture_Table_BedsideWhite = 0x5e8,
        _Furniture_Table_BedsideSeasonne = 0x5e9,
        _Furniture_Table_LongTempleOfSeasons = 0x5ea,
        _Furniture_Table_BigTempleOfSeasons = 0x5eb,
        _Furniture_Table_BigFlyingFortress = 0x5ec,
        _Furniture_Table_BigWhite_OBSOLETE = 0x5ed,
        _Furniture_Table_LongWhite_OBSOLETE = 0x5ee,
        _Furniture_Table_RoundWhite_OBSOLETE = 0x5ef,
        _Furniture_Table_LongFlyingFortress = 0x5f0,
        _Furniture_Table_BigSeasonne = 0x5f1,
        _Furniture_Table_LongSeasonne = 0x5f2,
        _Furniture_Table_LongHalloween = 0x5f3,
        _Furniture_Table_BigHalloween = 0x5f4,
        _Furniture_Table_BedsideTaiMing = 0x5f5,
        _Furniture_Table_BedsideMtBloom = 0x5f6,
        _Furniture_Table_LongTaiMing = 0x5f7,
        _Furniture_Table_LongMtBloom = 0x5f8,
        _Furniture_Table_BigTaiMing = 0x5f9,
        _Furniture_Table_BigMtBloom = 0x5fa,
        _Furniture_Table_BasicBigBlack = 0x5fb,
        _Furniture_Table_BasicBigWhite = 0x5fc,
        _Furniture_Table_BedsideDesert = 0x5fd,
        _Furniture_Table_BigDesert = 0x5fe,
        _Furniture_Table_LongDesert = 0x5ff,
        _Furniture_Table_LongShip = 0x600,
        _Furniture_Table_BedsideShip = 0x601,
        _Furniture_Table_BigShip = 0x602,
        _Furniture_Table_Funstack_Gold_OBSOLETE = 0x7b2,
        _Furniture_Table_Funstack_Silver_OBSOLETE = 0x7b3,
        _Furniture_Chair_BasicDark = 0x7d0,
        _Furniture_Chair_BasicWhite = 0x7d1,
        _Furniture_Chair_BasicWood = 0x7d2,
        _Furniture_Chair_BenchDark = 0x7d3,
        _Furniture_Chair_BenchWhite = 0x7d4,
        _Furniture_Chair_BenchWood = 0x7d5,
        _Furniture_Chair_CouchRed = 0x7d6,
        _Furniture_Chair_CouchGreen = 0x7d7,
        _Furniture_Chair_CouchBlue = 0x7d8,
        _Furniture_Chair_CouchDark = 0x7d9,
        _Furniture_Chair_CouchWhite = 0x7da,
        _Furniture_Chair_StoolDark = 0x7db,
        _Furniture_Chair_StoolWhite = 0x7dc,
        _Furniture_Chair_StoolWood = 0x7dd,
        _Furniture_Chair_BasicHalloween = 0x7de,
        _Furniture_Chair_BenchHalloween = 0x7df,
        _Furniture_Chair_StoolSeasonne = 0x7e0,
        _Furniture_Chair_BenchSeasonne = 0x7e1,
        _Furniture_Chair_StoolFlyingFortress = 0x7e2,
        _Furniture_Chair_BenchFlyingFortress = 0x7e3,
        _Furniture_Chair_StoolTempleOfSeasons = 0x7e4,
        _Furniture_Chair_BenchTempleOfSeasons = 0x7e5,
        _Furniture_Chair_StoolMtBloom = 0x7e6,
        _Furniture_Chair_BenchMtBloom = 0x7e7,
        _Furniture_Chair_StoolTaiMing = 0x7e8,
        _Furniture_Chair_BenchTaiMing = 0x7e9,
        _Furniture_Chair_SlimeBeanBag = 0x7ea,
        _Furniture_Chair_StoolDesert = 0x7eb,
        _Furniture_Chair_BenchDesert = 0x7ec,
        _Furniture_Chair_ChairShip = 0x7ed,
        _Furniture_Chair_BenchShip = 0x7ee,
        _Furniture_Decoration_Bonsai = 0xbb8,
        _Furniture_Decoration_CandleStick = 0xbb9,
        _Furniture_Decoration_Papers = 0xbba,
        _Furniture_Decoration_BookGreen = 0xbbb,
        _Furniture_Decoration_BookRed = 0xbbc,
        _Furniture_Decoration_BookPile_OBSOLETE = 0xbbd,
        _Furniture_Decoration_SakuraBonsai = 0xbbe,
        _Furniture_Decoration_ClothSmallSeasonne_OBSOLETE = 0xbbf,
        _Furniture_Decoration_PresentPile = 0xbc0,
        _Furniture_Decoration_CavePick = 0xbc1,
        _Furniture_Decoration_CaveFigurine = 0xbc2,
        _Furniture_Decoration_TaiMingBottle = 0xbc3,
        _Furniture_Decoration_SwordStand = 0xbc4,
        _Furniture_Decoration_Knife = 0xbc5,
        _Furniture_Decoration_ClothSmallTaiMing_OBSOLETE = 0xbc6,
        _Furniture_Decoration_JarTaiMing = 0xbc7,
        _Furniture_Decoration_CardInGlass = 0xbc8,
        _Furniture_Decoration_FlyingFortressFloorDetails = 0xbc9,
        _Furniture_Decoration_PhasePlate = 0xbca,
        _Furniture_Decoration_CatFoodBowl = 0xbcb,
        _Furniture_Decoration_FakeCardAlbum = 0xbcc,
        _Furniture_Decoration_SkullAndBones = 0xbcd,
        _Furniture_Decoration_SmallBone = 0xbce,
        _Furniture_Decoration_BigBone = 0xbcf,
        _Furniture_Decoration_HauntedBucket = 0xbd0,
        _Furniture_Decoration_Spider = 0xbd1,
        _Furniture_Decoration_LampCrystal = 0xdac,
        _Furniture_Decoration_LampLantern = 0xdad,
        _Furniture_Decoration_LampLava = 0xdae,
        _Furniture_Decoration_LampCandles = 0xdaf,
        _Furniture_Decoration_LampFlyingFortressCrystal = 0xdb0,
        _Furniture_Decoration_PlantGreen = 0xe10,
        _Furniture_Decoration_PlantPurple = 0xe11,
        _Furniture_Decoration_PlantPurpleSmall = 0xe12,
        _Furniture_Decoration_PlantSeasonneFlowers = 0xe13,
        _Furniture_Decoration_WeaponDisplayStanding1H = 0xe14,
        _Furniture_Decoration_WeaponDisplayStanding2H = 0xe15,
        _Furniture_Decoration_DesertCarrots = 0xe16,
        _Furniture_Decoration_DesertBag = 0xe17,
        _Furniture_Decoration_DesertLamp = 0xe18,
        _Furniture_Decoration_DesertGrindeaFigurine = 0xe19,
        _Furniture_Decoration_DesertModelship = 0xe1a,
        _Furniture_Decoration_DecorativeSkull = 0xe1b,
        _Furniture_WallDecor_Painting_Flowers = 0xfa0,
        _Furniture_WallDecor_Painting_FlyingFortress = 0xfa1,
        _Furniture_WallDecor_Painting_Sky = 0xfa2,
        _Furniture_WallDecor_Painting_TempleOfSeasons = 0xfa3,
        _Furniture_WallDecor_Painting_LostShip = 0xfa4,
        _Furniture_WallDecor_Window_ShortBlue = 0x1068,
        _Furniture_WallDecor_Window_ShortGreen = 0x1069,
        _Furniture_WallDecor_Window_ShortRed = 0x106a,
        _Furniture_WallDecor_Window_TempleOfSeasons = 0x106b,
        _Furniture_WallDecor_Window_Halloween = 0x106c,
        _Furniture_WallDecor_Window_FlyingFortress = 0x106d,
        _Furniture_WallDecor_Window_Seasonne = 0x106e,
        _Furniture_WallDecor_Window_MtBloom = 0x106f,
        _Furniture_WallDecor_Window_TaiMing = 0x1070,
        _Furniture_WallDecor_Window_Desert = 0x1071,
        _Furniture_WallDecor_Banner_Blue = 0x10a4,
        _Furniture_WallDecor_Banner_BlueThin = 0x10a5,
        _Furniture_WallDecor_Banner_Green = 0x10a6,
        _Furniture_WallDecor_Banner_GreenThin = 0x10a7,
        _Furniture_WallDecor_Banner_Red = 0x10a8,
        _Furniture_WallDecor_Banner_RedThin = 0x10a9,
        _Furniture_WallDecor_Banner_Collector = 0x10aa,
        _Furniture_WallDecor_Banner_DesertStyle = 0x10ab,
        _Furniture_WallDecor_Decor_Clock = 0x10cc,
        _Furniture_WallDecor_Decor_RedFish = 0x10cd,
        _Furniture_WallDecor_Decor_LampCandle = 0x10ce,
        _Furniture_WallDecor_Decor_LampOil = 0x10cf,
        _Furniture_WallDecor_Decor_LampTorch = 0x10d0,
        _Furniture_WallDecor_Decor_CollectorEmblem = 0x10d1,
        _Furniture_WallDecor_Decor_CollectorEmblem_Dark = 0x10d2,
        _Furniture_WallDecor_Decor_SeasonEmblem = 0x10d3,
        _Furniture_WallDecor_Decor_FlyingFortressLamps = 0x10d4,
        _Furniture_WallDecor_Decor_FlyingFortressGiantScreen = 0x10d5,
        _Furniture_WallDecor_Decor_FlyingFortressSmallScreen = 0x10d6,
        _Furniture_WallDecor_Decor_FlyingFortressMediumScreen = 0x10d7,
        _Furniture_WallDecor_Decor_SeasonneSock = 0x10d8,
        _Furniture_WallDecor_Decor_TempleOfSeasonsVines = 0x10d9,
        _Furniture_WallDecor_Decor_SeasonneGarland = 0x10da,
        _Furniture_WallDecor_Decor_CaveCrystalSmall = 0x10db,
        _Furniture_WallDecor_Decor_CaveCrystalBig = 0x10dc,
        _Furniture_WallDecor_Decor_CaveVines = 0x10dd,
        _Furniture_WallDecor_Decor_Mirror = 0x10de,
        _Furniture_WallDecor_Decor_TaiMing_Spears = 0x10df,
        _Furniture_WallDecor_Decor_TaiMing_SkyPainting = 0x10e0,
        _Furniture_WallDecor_Decor_TaiMing_FlowerPaintingSmall = 0x10e1,
        _Furniture_WallDecor_Decor_TaiMing_MoonPainting = 0x10e2,
        _Furniture_WallDecor_Decor_TaiMing_WallDecor = 0x10e3,
        _Furniture_WallDecor_Decor_TaiMing_Lantern = 0x10e4,
        _Furniture_WallDecor_Decor_TaiMing_SwordBig = 0x10e5,
        _Furniture_WallDecor_Decor_TaiMing_SwordMedium = 0x10e6,
        _Furniture_WallDecor_Decor_TaiMing_FlowerPaintingSquare = 0x10e7,
        _Furniture_WallDecor_Decor_TaiMing_FlowerPaintingMedium = 0x10e8,
        _Furniture_WallDecor_Decor_TaiMing_MountainPainting = 0x10e9,
        _Furniture_WallDecor_Decor_TaiMing_Wallflower = 0x10ea,
        _Furniture_WallDecor_Decor_WeaponDisplayHanging = 0x10eb,
        _Furniture_WallDecor_Decor_ToyTrain = 0x10ec,
        _Furniture_WallDecor_Decor_PhotoPainting_SmashingGiga = 0x10ed,
        _Furniture_WallDecor_Decor_PhotoPainting_BoarKillWhiteRabby = 0x10ee,
        _Furniture_WallDecor_Decor_PhotoPainting_PumpkinMixer = 0x10ef,
        _Furniture_WallDecor_Decor_DesertPoster = 0x10f0,
        _Furniture_WallDecor_Decor_PuzzleCounter = 0x10f1,
        _Furniture_WallDecor_Decor_DeadFish = 0x10f2,
        _Furniture_WallDecor_Decor_HauntedBag = 0x10f3,
        _Furniture_WallDecor_Decor_WallSpider = 0x10f4,
        _Furniture_WallDecor_Decor_HauntedVines = 0x10f5,
        _Furniture_WallDecor_Decor_SmallShipShelf = 0x10f6,
        _Furniture_WallDecor_Decor_BigShipShelf = 0x10f7,
        _Furniture_WallDecor_Decor_ShipWindow = 0x10f8,
        _Furniture_WallDecor_Decor_HauntedPainting = 0x10f9,
        _Furniture_BigStuff_BeerBarrel = 0x1388,
        _Furniture_BigStuff_BookCaseDark = 0x1389,
        _Furniture_BigStuff_BookCaseWhite = 0x138a,
        _Furniture_BigStuff_BookCaseWood = 0x138b,
        _Furniture_BigStuff_CandleStick = 0x138c,
        _Furniture_BigStuff_Fireplace = 0x138d,
        _Furniture_BigStuff_PlantBig = 0x138e,
        _Furniture_BigStuff_PlantSmall = 0x138f,
        _Furniture_BigStuff_ShelfDark_OBSOLETE = 0x1390,
        _Furniture_BigStuff_ShelfWhite_OBSOLETE = 0x1391,
        _Furniture_BigStuff_ShelfWood_OBSOLETE = 0x1392,
        _Furniture_BigStuff_WaterThingyTempleOfSeasons = 0x1393,
        _Furniture_BigStuff_BushTempleOfSeasons = 0x1394,
        _Furniture_BigStuff_TripleBushTempleOfSeasons = 0x1395,
        _Furniture_BigStuff_FaeStatue = 0x1396,
        _Furniture_BigStuff_Pumpkin = 0x1397,
        _Furniture_BigStuff_FlyingBroom = 0x1398,
        _Furniture_BigStuff_Cauldron = 0x1399,
        _Furniture_BigStuff_BigCrystalFlyingFortress = 0x139a,
        _Furniture_BigStuff_CrystalPillarFlyingFortress = 0x139b,
        _Furniture_BigStuff_ChristmasTree = 0x139c,
        _Furniture_BigStuff_SeasonOrb = 0x139d,
        _Furniture_BigStuff_FlyingFortressWisp = 0x139e,
        _Furniture_BigStuff_HugeMushroomBlue = 0x139f,
        _Furniture_BigStuff_HugeMushroomPurple = 0x13a0,
        _Furniture_BigStuff_MediumMushroomBlue = 0x13a1,
        _Furniture_BigStuff_MediumMushroomPurple = 0x13a2,
        _Furniture_BigStuff_SmallMushroomBlue_OBSOLETE = 0x13a3,
        _Furniture_BigStuff_SmallMushroomPurple_OBSOLETE = 0x13a4,
        _Furniture_BigStuff_CavePlantSmall = 0x13a5,
        _Furniture_BigStuff_CavePlantBig = 0x13a6,
        _Furniture_BigStuff_CavePlantThin = 0x13a7,
        _Furniture_BigStuff_FluffyFeathers = 0x13a8,
        _Furniture_BigStuff_CaveSpear = 0x13a9,
        _Furniture_BigStuff_CaveBag = 0x13aa,
        _Furniture_BigStuff_CaveHugeCrystal = 0x13ab,
        _Furniture_BigStuff_CaveRock = 0x13ac,
        _Furniture_BigStuff_CaveStatue = 0x13ad,
        _Furniture_BigStuff_TaiMingBoxes = 0x13ae,
        _Furniture_BigStuff_TaiMingBoxThin = 0x13af,
        _Furniture_BigStuff_TaiMingBookCase = 0x13b0,
        _Furniture_BigStuff_TaiMingBottleShelf = 0x13b1,
        _Furniture_BigStuff_TaiMingFlowerBox = 0x13b2,
        _Furniture_BigStuff_TaiMingFlowerCrate = 0x13b3,
        _Furniture_BigStuff_TaiMingWeaponStand = 0x13b4,
        _Furniture_BigStuff_FlyingFortressHole = 0x13b5,
        _Furniture_BigStuff_BedWhite = 0x14b4,
        _Furniture_BigStuff_BedBlack = 0x14b5,
        _Furniture_BigStuff_BedWood = 0x14b6,
        _Furniture_BigStuff_BedHalloween = 0x14b7,
        _Furniture_BigStuff_BedSeasonne = 0x14b8,
        _Furniture_BigStuff_BedFlyingFortress = 0x14b9,
        _Furniture_BigStuff_BedTaiMing = 0x14ba,
        _Furniture_BigStuff_BedCave = 0x14bb,
        _Furniture_BigStuff_BedTempleOfSeasons = 0x14bc,
        _Furniture_BigStuff_AncientStatue = 0x14bd,
        _Furniture_BigStuff_Palm = 0x14be,
        _Furniture_BigStuff_ExquisitePlant = 0x14bf,
        _Furniture_BigStuff_DeadPlant = 0x14c0,
        _Furniture_BigStuff_CrateOfDirt = 0x14c1,
        _Furniture_BigStuff_WateringCan = 0x14c2,
        _Furniture_BigStuff_DesertBed = 0x14c3,
        _Furniture_BigStuff_DesertBookcase = 0x14c4,
        _Furniture_BigStuff_LargeGrayJar = 0x14c5,
        _Furniture_BigStuff_LargeBlueJar = 0x14c6,
        _Furniture_BigStuff_LargeBeigeJar = 0x14c7,
        _Furniture_BigStuff_LargeBrownJar = 0x14c8,
        _Furniture_BigStuff_LargeGreenJar = 0x14c9,
        _Furniture_BigStuff_Cutout_Chicken = 0x14ca,
        _Furniture_BigStuff_Cutout_WeddingPair = 0x14cb,
        _Furniture_BigStuff_Cutout_Snowbacca = 0x14cc,
        _Furniture_BigStuff_GhostBed = 0x14cd,
        _Furniture_BigStuff_Cannon = 0x14ce,
        _Furniture_BigStuff_CannonBallPile = 0x14cf,
        _Furniture_BigStuff_HauntedBookcase = 0x14d0,
        _Furniture_BigStuff_HauntedGhostBag = 0x14d1,
        _Furniture_WallType00 = 0x1b58,
        _Furniture_WallType01 = 0x1b59,
        _Furniture_WallType02 = 0x1b5a,
        _Furniture_WallType03_Halloween = 0x1b5b,
        _Furniture_WallType04_FlyingFortress = 0x1b5c,
        _Furniture_WallType05_Seasonne = 0x1b5d,
        _Furniture_WallType06_TempleOfSeasons_Autumn = 0x1b5e,
        _Furniture_WallType07_MtBloom = 0x1b5f,
        _Furniture_WallType08_TaiMing = 0x1b60,
        _Furniture_WallType09_TempleOfSeasons_Summer = 0x1b61,
        _Furniture_WallType10_TempleOfSeasons_Winter = 0x1b62,
        _Furniture_WallType11_GreenFlowers = 0x1b63,
        _Furniture_WallType12_Desert = 0x1b64,
        _Furniture_WallType13_LostShip = 0x1b65,
        _Furniture_FloorType00 = 0x1c20,
        _Furniture_FloorType01 = 0x1c21,
        _Furniture_FloorType02 = 0x1c22,
        _Furniture_FloorType03_Halloween = 0x1c23,
        _Furniture_FloorType04_FlyingFortress = 0x1c24,
        _Furniture_FloorType05_Seasonne = 0x1c25,
        _Furniture_FloorType06_TempleOfSeasons_Autumn = 0x1c26,
        _Furniture_FloorType07_MtBloom = 0x1c27,
        _Furniture_FloorType08_TaiMing = 0x1c28,
        _Furniture_FloorType09_TempleOfSeasons_Summer = 0x1c29,
        _Furniture_FloorType10_TempleOfSeasons_Winter = 0x1c2a,
        _Furniture_FloorType11_Desert = 0x1c2b,
        _Furniture_FloorType12_LostShip = 0x1c2c,
        _Misc_Fish_Fishie = 0x2af8,
        _Misc_Fish_FishieGreen = 0x2af9,
        _Misc_Fish_Clam = 0x2afa,
        _Misc_Fish_Crabby = 0x2afb,
        _Misc_Fish_DeadFish = 0x2afc,
        _Misc_Fish_Eel = 0x2afd,
        _Misc_Fish_EelDisplay = 0x2afe,
        _Misc_Fish_Fatty = 0x2aff,
        _Misc_Fish_FattyDisplay = 0x2b00,
        _Misc_Fish_Mes = 0x2b01,
        _Misc_Fish_Moray = 0x2b02,
        _Misc_Fish_MorayDisplay = 0x2b03,
        _Misc_Fish_Octopus = 0x2b04,
        _Misc_Fish_OctopusDisplay = 0x2b05,
        _Misc_Fish_Salmon = 0x2b06,
        _Misc_Fish_SeaHorse = 0x2b07,
        _Misc_Fish_Shrimp = 0x2b08,
        _Misc_Fish_Squid = 0x2b09,
        _Misc_Fish_Starfish = 0x2b0a,
        _Misc_Fish_Stingray = 0x2b0b,
        _Misc_Fish_StingrayDisplay = 0x2b0c,
        _Misc_Fish_Ghostfish = 0x2b0d,
        _Misc_Fish_Zombiefish = 0x2b0e,
        _Misc_Fish_Vampirefish = 0x2b0f,
        _Misc_Fish_FrankenFish = 0x2b10,
        _Misc_Fish_FrankenFishDisplay = 0x2b11,
        _Misc_Fish_RedFatty_Token = 0x2b12,
        _Misc_Fish_RedFatty = 0x2b13,
        _Misc_Fish_RedFattyDisplay = 0x2b14,
        _Misc_Fish_Fishstick = 0x2b15,
        _Misc_Fish_Icefish = 0x2b16,
        _Misc_Fish_Penguish = 0x2b17,
        _Misc_Fish_PenguishDisplay = 0x2b18,
        _Misc_Fish_SnowFish = 0x2b19,
        _Misc_Fish_Yetish = 0x2b1a,
        _Misc_Fish_YetishDisplay = 0x2b1b,
        _Misc_Fish_Rockfish = 0x2b1c,
        _Misc_Fish_Anglerfish = 0x2b1d,
        _Misc_Fish_AnglerfishDisplay = 0x2b1e,
        _Misc_Fish_Crystalfish = 0x2b1f,
        _Misc_Fish_Goldfish = 0x2b20,
        _Misc_Fish_Mossfish = 0x2b21,
        _Misc_Fish_Bottle = 0x2b22,
        _Misc_Fish_SandShark = 0x2b23,
        _Misc_Fish_Cactish = 0x2b24,
        _Misc_Fish_LASTFISH = 0x2b25,
        Card = 0x4650,
        _Coin_SmallSilver = 0x4a38,
        _Coin_BigSilver = 0x4a39,
        _Coin_SmallGold = 0x4a3a,
        _Coin_BigGold = 0x4a3b,
        _Orb_Health_Medium = 0x4a9c,
        _Shield_WoodenShield = 0x4e20,
        _Shield_TestShield = 0x4e21,
        _Shield_Barrel = 0x4e22,
        _Shield_Crystal = 0x4e23,
        _Shield_Iron = 0x4e24,
        _Shield_Wisp = 0x4e25,
        _Shield_WintersGuard = 0x4e26,
        _Shield_GiftBoxShield = 0x4e27,
        _Shield_MushroomShield = 0x4e28,
        _Shield_Polished = 0x4e29,
        _Shield_Shiidu = 0x4e2a,
        _Shield_ThornWormShield = 0x4e2b,
        _Shield_SuperCrystal = 0x4e2c,
        _Shield_CameraShield = 0x4e2d,
        _Shield_SolemShield = 0x4e2e,
        _Shield_CalculatorShield = 0x4e2f,
        _Shield_RobustShield = 0x4e30,
        _Shield_CrabShield = 0x4e31,
        _Hat_Strawboater = 0x7530,
        _Hat_BabyDevilHorns = 0x7531,
        _Hat_Halo = 0x7532,
        _Hat_SlimeHat = 0x7533,
        _Hat_AppleHat = 0x7534,
        _Hat_PumpkinMask = 0x7535,
        _Hat_Bandana = 0x7536,
        _Hat_Can = 0x7537,
        _Hat_GuardHat = 0x7538,
        _Hat_Keps = 0x7539,
        _Hat_Mossa = 0x753a,
        _Hat_Rosett_Blue = 0x753b,
        _Hat_Rosett_Green = 0x753c,
        _Hat_Rosett_Pink = 0x753d,
        _Hat_Rosett_Red = 0x753e,
        _Hat_Garland_BluePetals = 0x753f,
        _Hat_Garland_PurplePetals = 0x7540,
        _Hat_Ushanka = 0x7541,
        _Hat_ChickenHat = 0x7542,
        _Hat_Chimney = 0x7543,
        _Hat_ArchersApple = 0x7544,
        _Hat_Crown = 0x7545,
        _Hat_Eggshell = 0x7546,
        _Hat_Fish = 0x7547,
        _Hat_PopeHat = 0x7548,
        _Hat_WitchHat = 0x7549,
        _Hat_Phaseface = 0x754a,
        _Hat_LeatherCap = 0x754b,
        _Hat_IronCap = 0x754c,
        _Hat_BrawlerHelmet = 0x754d,
        _Hat_GoblinHat = 0x754e,
        _Hat_SlimeHat_Blue = 0x754f,
        _Hat_Paperbag = 0x7550,
        _Hat_Earmuffs = 0x7551,
        _Hat_CatEars = 0x7552,
        _Hat_Turban = 0x7553,
        _Hat_ChefHat = 0x7554,
        _Hat_ValkyrieHat_Neutral = 0x7555,
        _Hat_SlimeHat_Red = 0x7556,
        _Hat_SeasonKnight_Summer = 0x7557,
        _Hat_SeasonKnight_Winter = 0x7558,
        _Hat_SeasonKnight_Autumn = 0x7559,
        _Hat_SeasonMage_Summer = 0x755a,
        _Hat_SeasonMage_Winter = 0x755b,
        _Hat_SeasonMage_Autumn = 0x755c,
        _Hat_SantaHat = 0x755d,
        _Hat_RedSlimeKingHat = 0x755e,
        _Hat_BoarHat = 0x755f,
        _Hat_PeckoHat = 0x7560,
        _Hat_SnowbaccaHat = 0x7561,
        _Hat_HoodOfDarkness = 0x7562,
        _Hat_BunnyEars = 0x7563,
        _Hat_Beret = 0x7564,
        _Hat_HornedCap = 0x7565,
        _Hat_Crystal = 0x7566,
        _Hat_CrystalMulti = 0x7567,
        _Hat_Mushroom = 0x7568,
        _Hat_MushroomMulti = 0x7569,
        _Hat_AnglerFish = 0x756a,
        _Hat_Helmet = 0x756b,
        _Hat_OrnateHelmet = 0x756c,
        _Hat_StatueMask = 0x756d,
        _Hat_BananaHat = 0x756e,
        _Hat_SideBow_Red = 0x756f,
        _Hat_SideBow_Green = 0x7570,
        _Hat_SideBow_Purple = 0x7571,
        _Hat_SideBow_Blue = 0x7572,
        _Hat_FancyHat = 0x7573,
        _Hat_BigBandana = 0x7574,
        _Hat_PowerFlower = 0x7575,
        _Hat_Wormy = 0x7576,
        _Hat_DojoHeadbelt_White = 0x7577,
        _Hat_DojoHeadbelt_Yellow = 0x7578,
        _Hat_DojoHeadbelt_Blue = 0x7579,
        _Hat_DojoHeadbelt_Purple = 0x757a,
        _Hat_DojoHeadbelt_Brown = 0x757b,
        _Hat_DojoHeadbelt_Black = 0x757c,
        _Hat_DojoHeadbelt_Red = 0x757d,
        _Hat_FaeWings_Summer = 0x757e,
        _Hat_FaeWings_Autumn = 0x757f,
        _Hat_FaeWings_Spring = 0x7580,
        _Hat_FaeWings_Winter = 0x7581,
        _Hat_SailorHat = 0x7582,
        _Hat_SlimeHat_Orange = 0x7583,
        _Hat_BarrelHat = 0x7584,
        _Hat_Fez = 0x7585,
        _Hat_JesterHat = 0x7586,
        _Hat_Pan = 0x7587,
        _Hat_Pyramid = 0x7588,
        _Hat_Partyhat_Blue = 0x7589,
        _Hat_Partyhat_Red = 0x758a,
        _Hat_Partyhat_Green = 0x758b,
        _Hat_CrabHelm = 0x758c,
        _Hat_PirateHat = 0x758d,
        _Hat_RoboticEars = 0x758e,
        _Facegear_Blindfold = 0x9c40,
        _Facegear_Glasses = 0x9c41,
        _Facegear_Beard = 0x9c42,
        _Facegear_Cigarr = 0x9c43,
        _Facegear_Masque = 0x9c44,
        _Facegear_ScreamMask = 0x9c45,
        _Facegear_Scar = 0x9c46,
        _Facegear_EyebrowsAngry = 0x9c47,
        _Facegear_FancyBeard = 0x9c48,
        _Facegear_SkiGoggles = 0x9c49,
        _Facegear_SantaBeard = 0x9c4a,
        _Facegear_SpinsectFeelers = 0x9c4b,
        _Facegear_GasMask = 0x9c4c,
        _Facegear_NohMask = 0x9c4d,
        _Facegear_OniMask = 0x9c4e,
        _Facegear_MonkeyEars = 0x9c4f,
        _Facegear_BlindfoldWhite = 0x9c50,
        _Facegear_HybridGlasses = 0x9c51,
        _Facegear_SpectralBlindfold = 0x9c52,
        _OneHanded_WoodenSword = 0xc350,
        _OneHanded_CarrotSword = 0xc351,
        _OneHanded_Morningstar = 0xc352,
        _OneHanded_IronSword = 0xc353,
        _OneHanded_Stinger = 0xc354,
        _OneHanded_Rod = 0xc355,
        _OneHanded_RubyRod = 0xc356,
        _OneHanded_SteelSword = 0xc357,
        _OneHanded_LaserSword = 0xc358,
        _OneHanded_RedFlowerWhip = 0xc359,
        _OneHanded_ToyWand = 0xc35a,
        _OneHanded_AutumnSword = 0xc35b,
        _OneHanded_Pickaxe = 0xc35c,
        _OneHanded_RedLaserSword = 0xc35d,
        _OneHanded_Scimitar = 0xc35e,
        _OneHanded_AncientFan = 0xc35f,
        _OneHanded_BambooSword = 0xc360,
        _OneHanded_MarinoRapier = 0xc361,
        _OneHanded_EggstraDeliciousRecipes = 0xc362,
        _OneHanded_TheQuill = 0xc363,
        _OneHanded_Mace = 0xc364,
        _OneHanded_WarlockRod = 0xc365,
        _OneHanded_BestOfEggstraDeliciousRecipes = 0xc366,
        _OneHanded_CrabClaw = 0xc367,
        _OneHanded_SkeletonHand = 0xc368,
        _OneHanded_WoodenLeg = 0xc369,
        _OneHanded_EmptyBottle = 0xc36a,
        _TwoHanded_Claymore = 0xea60,
        _TwoHanded_Stick = 0xea61,
        _TwoHanded_Lantern = 0xea62,
        _TwoHanded_Club = 0xea63,
        _TwoHanded_SpikedClub = 0xea64,
        _TwoHanded_GreatAxe = 0xea65,
        _TwoHanded_LumberAxe = 0xea66,
        _TwoHanded_SlimeHammer = 0xea67,
        _TwoHanded_WinterSpear = 0xea68,
        _TwoHanded_SummerHammer = 0xea69,
        _TwoHanded_BirchBranch = 0xea6a,
        _TwoHanded_Icicle = 0xea6b,
        _TwoHanded_Staff = 0xea6c,
        _TwoHanded_Mushroom = 0xea6d,
        _TwoHanded_Broadsword = 0xea6e,
        _TwoHanded_AngelsThirst = 0xea6f,
        _TwoHanded_BladeOfEchoes = 0xea70,
        _TwoHanded_CactusClub = 0xea71,
        _TwoHanded_CurvedSpear = 0xea72,
        _TwoHanded_GiantScimitar = 0xea73,
        _TwoHanded_LaserClaymore = 0xea74,
        _Bow_WoodenBow = 0x1_1170,
        _Bow_Level2 = 0x1_1171,
        _Bow_Level3 = 0x1_1172,
        _Bow_Level4 = 0x1_1173,
        _Bow_Level5 = 0x1_1174,
        _Bow_Level6 = 0x1_1175,
        _Bow_Arrows = 0x1_1238,
        _Accessory_RabbitsFoot = 0x1_3880,
        _Accessory_Scarf = 0x1_3881,
        _Accessory_VoodooDoll = 0x1_3882,
        _Accessory_Amulet01Blue = 0x1_3883,
        _Accessory_Amulet01Red = 0x1_3884,
        _Accessory_Amulet01Yellow = 0x1_3885,
        _Accessory_Ring01Yellow = 0x1_3886,
        _Accessory_Ring01Blue = 0x1_3887,
        _Accessory_Ring01Red = 0x1_3888,
        _Accessory_SlimeRing = 0x1_3889,
        _Accessory_PlasmaBracelet = 0x1_388a,
        _Accessory_MissileControlUnit = 0x1_388b,
        _Accessory_Gloves = 0x1_388c,
        _Accessory_EarringsOfBalance = 0x1_388d,
        _Accessory_IceCrystalPendant = 0x1_388e,
        _Accessory_LarvaArmband = 0x1_388f,
        _Accessory_LightningGlove = 0x1_3890,
        _Accessory_Ring02Yellow = 0x1_3891,
        _Accessory_Ring02Blue = 0x1_3892,
        _Accessory_Ring02Red = 0x1_3893,
        _Accessory_ButterflyBrooch = 0x1_3894,
        _Accessory_RibbonBroochRed = 0x1_3895,
        _Accessory_RibbonBroochGreen = 0x1_3896,
        _Accessory_RibbonBroochBlue = 0x1_3897,
        _Accessory_AncientPendant = 0x1_3898,
        _Accessory_MagicBattery = 0x1_3899,
        _Accessory_CameraLens = 0x1_389a,
        _Accessory_LuckyNumberSeven = 0x1_389b,
        _Accessory_GoldenEarrings = 0x1_389c,
        _Accessory_CaptainBonesHead = 0x1_389d,
        _Accessory_SkullRing = 0x1_389e,
        _Accessory_RestlessSpirit = 0x1_389f,
        _Armor_Shawl = 0x1_5f90,
        _Armor_AdventureShirt = 0x1_5f91,
        _Armor_Vest = 0x1_5f92,
        _Armor_Shirt = 0x1_5f93,
        _Armor_KnittedShirt = 0x1_5f94,
        _Armor_BrawlerPlate = 0x1_5f95,
        _Armor_SlimeArmor = 0x1_5f96,
        _Armor_AdventureVest = 0x1_5f97,
        _Armor_ChainMail = 0x1_5f98,
        _Armor_GoblinJacket = 0x1_5f99,
        _Armor_ArmorOfAutumn = 0x1_5f9a,
        _Armor_ApprenticeRobe = 0x1_5f9b,
        _Armor_RobeOfEnergy = 0x1_5f9c,
        _Armor_RobeOfFocus = 0x1_5f9d,
        _Armor_SpinsectArmor = 0x1_5f9e,
        _Armor_LabCoat = 0x1_5f9f,
        _Armor_PurpleKimono = 0x1_5fa0,
        _Armor_RedKimono = 0x1_5fa1,
        _Armor_Breastplate = 0x1_5fa2,
        _Armor_WornCropTop = 0x1_5fa3,
        _Armor_BarbarianStrap = 0x1_5fa4,
        _Armor_FightingVest = 0x1_5fa5,
        _Armor_WizardArmor = 0x1_5fa6,
        _Armor_WarriorArmor = 0x1_5fa7,
        _Armor_CrabbyArmor = 0x1_5fa8,
        _Shoes_MountainBoots = 0x1_86a0,
        _Shoes_Sandals = 0x1_86a1,
        _Shoes_BirdFeet = 0x1_86a2,
        _Shoes_Socks = 0x1_86a3,
        _Shoes_GoblinShoes = 0x1_86a4,
        _Shoes_PhasemanBoots = 0x1_86a5,
        _Shoes_SummerGreaves = 0x1_86a6,
        _Shoes_Rollerblades = 0x1_86a7,
        _Shoes_CrystalPumps = 0x1_86a8,
        _Shoes_SturdyBoots = 0x1_86a9,
        _Shoes_Geta = 0x1_86aa,
        _Shoes_TaiMingShoes = 0x1_86ab,
        _Shoes_FancySandals = 0x1_86ac,
        _Shoes_VeryOrdinaryShoes = 0x1_86ad,
        _Hairdo_Gay = 0x2_7100,
        _Hairdo_Ron = 0x2_7101,
        _Hairdo_Random = 0x2_7102,
        _Hairdo_Ful = 0x2_7103,
        _Hairdo_Trist = 0x2_7104,
        _Hairdo_Struts = 0x2_7105,
        _Hairdo_Saiya = 0x2_7106,
        _Hairdo_Afro = 0x2_7107,
        _Hairdo_Samurai = 0x2_7108,
        _Hairdo_Long01 = 0x2_7109,
        _Hairdo_Mohawk = 0x2_710a,
        _Hairdo_Baldie = 0x2_710b,
        _Hairdo_Sephina = 0x2_72f4,
        _Hairdo_Ponytail = 0x2_72f5,
        _Hairdo_Buns = 0x2_72f6,
        _Hairdo_FemGay = 0x2_72f7,
        _Hairdo_Quistis = 0x2_72f8,
        _Hairdo_Short01 = 0x2_72f9,
        _Hairdo_Short02 = 0x2_72fa,
        _Hairdo_Sidetails = 0x2_72fb,
        _Hairdo_Buns02 = 0x2_72fc,
        _Hairdo_Buns02Single = 0x2_72fd,
        _Hairdo_Short03 = 0x2_72fe,
        _Hairdo_BaldieFem = 0x2_72ff,
        _SpecialPickup_DiggingToken = 0x2_9810,
        _Special_TeleportDevice = 0x2_9811,
        _Special_TeleportPlate = 0x2_9812,
        _Special_SlimeRing = 0x2_9813,
        _Special_CarrotSwordPickup = 0x2_9814,
        _Special_CoinPurseA = 0x2_9815,
        _Special_OneArrow = 0x2_9816,
        _Special_SomeArrows = 0x2_9817,
        _Special_CarpenterHammer = 0x2_9818,
        _Special_StonecutterMaterials = 0x2_9819,
        _Special_GiantSlimeEssence = 0x2_981a,
        _Special_BloomoSeed = 0x2_981b,
        _Special_FatfishToken = 0x2_981c,
        _Special_EternalFlame = 0x2_981d,
        _Special_GhastlyVeil = 0x2_981e,
        _Special_LastStraw = 0x2_981f,
        _Special_RootOfEvil = 0x2_9820,
        _Special_SeedOfDoubt = 0x2_9821,
        _Special_GrinchPresentA = 0x2_9822,
        _Special_GrinchPresentB = 0x2_9823,
        _Special_GrinchPresentC = 0x2_9824,
        _Special_GrinchPresentD = 0x2_9825,
        _Special_RoyalJelly = 0x2_9826,
        _Special_BakingSoda = 0x2_9827,
        _Special_CavelingRelic01 = 0x2_9828,
        _Special_CavelingRelic02 = 0x2_9829,
        _Special_CavelingRelic03 = 0x2_982a,
        _Special_LurifixReward01 = 0x2_982b,
        _Special_LurifixReward02 = 0x2_982c,
        _Special_LurifixReward03 = 0x2_982d,
        _Special_TimekeeperCrown = 0x2_982e,
        _Special_Chicken = 0x2_982f,
        _Special_ThousandYearAle = 0x2_9830,
        _Special_TaiMingBottle = 0x2_9831,
        _Special_EmblemOfValor = 0x2_9832,
        _Special_EmblemOfLoyalty = 0x2_9833,
        _Special_EmblemOfFaith = 0x2_9834,
        _Special_ZhamlasCrown_Untainted = 0x2_9835,
        _Special_AngelsThirstPickup = 0x2_9836,
        _Special_RabbyDisplay = 0x2_9837,
        _Special_TalentOrbPickup = 0x2_9838,
        _Special_ChestIcon_FlyingFortress = 0x2_9839,
        _Special_SilverSkillPointPickup = 0x2_983a,
        _Special_GoldSkillPointPickup = 0x2_983b,
        _Special_SpawnPin = 0x2_983c,
        _ArcadiaBlessings_ThreeTalents = 0x2_9bf8,
        _ArcadiaBlessings_GoldSkillPoint = 0x2_9bf9,
        _ArcadiaBlessings_Level = 0x2_9bfa,
        _ArcadiaBlessings_TonsOfGold = 0x2_9bfb,
        _ArcadiaBlessings_Heal = 0x2_9bfc,
        _ArcadiaBlessings_LoodGold = 0x2_9bfd,
        _ChaosModeUpgrade_HPUp = 0x2_9fe0,
        _ChaosModeUpgrade_ATKUp = 0x2_9fe1,
        _ChaosModeUpgrade_CSPDUp = 0x2_9fe2,
        _ChaosModeUpgrade_EPRegUp = 0x2_9fe3,
        _ChaosModeUpgrade_MaxEPUp = 0x2_9fe4,
        _ChaosModeUpgrade_TalentPoints = 0x2_9fe5,
        _ChaosModeUpgrade_LastDroppableGeneric = 0x2_9fe6,
        _ChaosModeUpgrade_SpellStart = 0x2_a3c8,
        _ChaosModeUpgrade_SpellEnd = 0x2_af7f,
        _KeyItem_FishingRod = 0x2_bf20,
        _KeyItem_GoldenCarrot = 0x2_bf21,
        _KeyItem_JuicyApple = 0x2_bf22,
        _KeyItem_CandyCane = 0x2_bf23,
        _KeyItem_Quiver = 0x2_bf24,
        _KeyItem_Key = 0x2_bf25,
        _KeyItem_FFAmulet = 0x2_bf26,
        _KeyItem_RoguelikeEssence = 0x2_bf27,
        _KeyItem_STGauntlet = 0x2_bf28,
        _KeyItem_SantaCookie = 0x2_bf29,
        _KeyItem_MiniSantaTruffles = 0x2_bf2a,
        _KeyItem_GiftBand = 0x2_bf2b,
        _KeyItem_FriedEel = 0x2_bf2c,
        _KeyItem_GiftBand_Display = 0x2_bf2d,
        _KeyItem_BeeTamingFlower = 0x2_bf2e,
        _KeyItem_LotsOfHoney = 0x2_bf2f,
        _KeyItem_CavelingKey = 0x2_bf30,
        _KeyItem_CavelingFlute = 0x2_bf31,
        _KeyItem_StevesFathersPickaxe = 0x2_bf32,
        _KeyItem_CrystalChisel = 0x2_bf33,
        _KeyItem_TaiMingResidenceKey = 0x2_bf34,
        _KeyItem_MikiBall = 0x2_bf35,
        _KeyItem_MikiBall_Cursed = 0x2_bf36,
        _KeyItem_PuzzleWorldMonkeyKey = 0x2_bf37,
        _KeyItem_ZhamlaCrown = 0x2_bf38,
        _KeyItem_ZhamlaBraazlet = 0x2_bf39,
        _KeyItem_ZhamlaSword = 0x2_bf3a,
        _KeyItem_PlayerHomeKey = 0x2_bf3b,
        _KeyItem_Lumber = 0x2_bf3c,
        _KeyItem_TimeshiftCrystal = 0x2_bf3d,
        _KeyItem_CursedRedApple = 0x2_bf3e,
        _KeyItem_WhiteCarrot = 0x2_bf3f,
        _KeyItem_LifeInsuranceStep1 = 0x2_bf40,
        _KeyItem_LifeInsuranceStep2 = 0x2_bf41,
        _KeyItem_LifeInsuranceStep3 = 0x2_bf42,
        _KeyItem_LifeInsuranceStep4 = 0x2_bf43,
        _KeyItem_Camera = 0x2_bf44,
        _KeyItem_BirdFeedSack = 0x2_bf45,
        _KeyItem_TranslationTome = 0x2_bf46,
        _KeyItem_RedSunRuby = 0x2_bf47,
        _KeyItem_PennAutograph = 0x2_bf48,
        _KeyItem_VegetableTamingItem = 0x2_bf49,
        _KeyItem_KnotsHat = 0x2_bf4a,
        _KeyItem_KingweedRoot = 0x2_bf4b,
        _KeyItem_StatueHairOrnament = 0x2_bf4c,
        _KeyItem_KatarinaSunscreen = 0x2_bf4d,
        _KeyItem_MalletIceCream = 0x2_bf4e,
        _KeyItem_CatLocket = 0x2_bf4f,
        _KeyItem_FinderStuff_PlateShard = 0x2_bf50,
        _KeyItem_FinderStuff_Comb = 0x2_bf51,
        _KeyItem_FinderStuff_Fork = 0x2_bf52,
        _KeyItem_GhostShipKey = 0x2_bf53,
        _KeyItem_Gunpowder = 0x2_bf54,
        _KeyItem_SheetMusic = 0x2_bf55,
        _KeyItem_BouncerTShirt = 0x2_bf56,
        _KeyItem_BarbackCleaningRag = 0x2_bf57,
        _KeyItem_Psychosis_Obsession = 0x2_bf58,
        _KeyItem_Psychosis_Expectations = 0x2_bf59,
        _KeyItem_Psychosis_Deceit = 0x2_bf5a,
        _KeyItem_TwiSight = 0x2_bf5b,
        _KeyItem_DrBorisBook = 0x2_bf5c,
        _KeyItem_DivaMirror = 0x2_bf5d,
        _KeyItem_TanniesTicket = 0x2_bf5e,
        _KeyItem_BrulesHead = 0x2_bf5f,
        _KeyItem_AgedRum = 0x2_bf60,
        _Egg_Chicken = 0x2_c308,
        _Egg_MiniChicken = 0x2_c309,
        _Egg_FluffyFeathers = 0x2_c30a,
        _Egg_HealthLood = 0x2_c30b,
        _Egg_TalentLood = 0x2_c30c,
        _Egg_GoldenLood = 0x2_c30d,
        _Egg_TreasureLood = 0x2_c30e,
        _Egg_PinLood = 0x2_c30f,
        _Icon_PhaseShape_Orb = 0x2_e630,
        _Icon_PhaseShape_Cube = 0x2_e631,
        _Icon_PhaseShape_Heart = 0x2_e632,
        _Icon_PhaseShape_Star = 0x2_e633,
        _TreasureMap_Special_TrialPlayer01 = 0x3_0d40,
        _TreasureMap_TaiMing_TessensMap = 0x3_0d41,
        _TreasureMap_001 = 0x3_1128,
        _TreasureMap_002 = 0x3_1129,
        _TreasureMap_003 = 0x3_112a,
        _TreasureMap_004 = 0x3_112b,
        _TreasureMap_005 = 0x3_112c,
        _TreasureMap_006 = 0x3_112d,
        _TreasureMap_007 = 0x3_112e,
        _TreasureMap_008 = 0x3_112f,
        _TreasureMap_009 = 0x3_1130,
        _TreasureMap_010 = 0x3_1131,
        _TreasureMap_011 = 0x3_1132,
        _TreasureMap_Last = 0x3_344f,
        _RogueLikeArcadiaReward_TavernTent = 0x4_93e0,
        _RogueLikeArcadiaReward_Roads = 0x4_93e1,
        _RogueLikeArcadiaReward_Well = 0x4_93e2,
        _RogueLikeArcadiaReward_FarmField = 0x4_93e3,
        _RogueLikeArcadiaReward_NoticeBoard = 0x4_93e4,
        _RogueLikeArcadiaReward_StartingtonHouses = 0x4_93e5,
        _RogueLikeArcadiaReward_ChickenCoop = 0x4_93e6,
        _RogueLikeArcadiaReward_GrindeaRenewed = 0x4_93e7,
        _RogueLikeArcadiaReward_PavedRoads = 0x4_93e8,
        _RogueLikeArcadiaReward_BetterFarmsAndFlowers = 0x4_93e9,
        _RogueLikeArcadiaReward_StreetLights = 0x4_93ea,
        _RogueLikeArcadiaReward_Fountain = 0x4_93eb,
        _RogueLikeArcadiaReward_EvergrindHouses = 0x4_93ec,
        _RogueLikeArcadiaReward_StatueObtained = 0x4_93ed,
        _RogueLikeArcadiaReward_IntroCutsceneWatched = 0x4_93ee,
        _RogueLikeArcadiaReward_BloomoFound = 0x4_93ef,
        _RogueLikeArcadiaReward_NPC_RobinHood = 0x4_93f0,
        _RogueLikeArcadiaReward_NPC_PapaGuard = 0x4_93f1,
        _RogueLikeArcadiaReward_PidgysBirds = 0x4_93f2
    }
    public enum Sog_Spells : ushort
    {
        NULL = 0,
        _Basic_HealthBoost = 1,
        _Basic_ManaBoost = 2,
        _Basic_AttackDamage = 3,
        _Basic_AttackSpeed = 4,
        _Basic_MagicDamage = 5,
        _Basic_CastSpeed = 6,
        _Skill_Bow_ShootArrow = 7,
        _Skill_Bow_SplittingArrow = 8,
        _Skill_Bow_MachineBow = 9,
        _Magic_Ice_IceSpikes = 100,
        _Magic_Ice_IceNova = 0x65,
        _Magic_Ice_FrostyFriend = 0x66,
        _Magic_Ice_FreezeControlInstance = 0x67,
        _Magic_Fire_Fireball = 200,
        _Magic_Fire_Meteor = 0xc9,
        _Magic_Fire_Flamethrower = 0xca,
        _Magic_Fire_BurnControlInstance = 0xcb,
        _Magic_Fire_Fireball_PhoenixTrail = 0xcc,
        _Magic_Fire_MeteorBurningGround = 0xcd,
        _Magic_Earth_EarthSpike = 300,
        _Magic_Earth_SummonPlant = 0x12d,
        _Magic_Earth_InsectSwarm = 0x12e,
        _Magic_Earth_SummonPlant_NutShot = 0x12f,
        _Magic_Wind_SummonCloud = 400,
        _Magic_Wind_ChainLightning = 0x191,
        _Magic_Wind_StaticTouch = 0x192,
        _Magic_Wind_WindSlice = 0x193,
        _Magic_Wind_StaticTouchProjectile = 0x194,
        _Magic_Light_Heal = 500,
        _Magic_Light_Protect = 0x1f5,
        _Magic_Support_Haste = 0x1f6,
        _Magic_Support_Defensive3 = 0x1f7,
        _Magic_Support_Offensive1 = 0x1f8,
        _Magic_Support_Offensive2 = 0x1f9,
        _Magic_Support_Offensive3 = 0x1fa,
        _Magic_Support_BuffATK = 0x1fb,
        _Magic_Support_BuffSPD = 0x1fc,
        _Magic_Support_BuffDEF = 0x1fd,
        _Magic_Support_Blink = 510,
        _Magic_Support_Focus = 0x1ff,
        _Magic_Support_Barrier = 0x200,
        _Magic_Support_DeathMark = 0x201,
        _Magic_Support_Stasis = 0x202,
        _Magic_Support_Taunt = 0x203,
        _Magic_OneHandProjectile_Basic = 0x204,
        _Magic_TwoHandProjectile_Basic = 0x205,
        _Skill_TwoHanded_Overhead = 0x3e8,
        _Skill_TwoHanded_Spin = 0x3e9,
        _Skill_TwoHanded_Throw = 0x3ea,
        _Skill_TwoHanded_Smash = 0x3eb,
        _Skill_TwoHanded_BerserkMode = 0x3ec,
        _Skill_TwoHanded_Smash_TravelInstance = 0x3ed,
        _Skill_OneHanded_Stinger = 0x4b0,
        _Skill_OneHanded_MillionStabs = 0x4b1,
        _Skill_OneHanded_SpiritSlash = 0x4b2,
        _Skill_OneHanded_QuickCounter = 0x4b3,
        _Skill_OneHanded_ShadowClone = 0x4b4,
        _Skill_OneHanded_StingerPostDamage = 0x4b5,
        _Skill_CombatPassive1 = 0x514,
        _Skill_CombatPassive2 = 0x515,
        _Skill_CombatPassive3 = 0x516,
        _Talent_QuickReflexes = 0x7d0,
        _Talent_ShieldBearer = 0x7d1,
        _Talent_Multitasking = 0x7d2,
        _Talent_Adaptable = 0x7d3,
        _Talent_Tenacious = 0x7d4,
        _Talent_LastStand = 0x7d5,
        _Talent_Surgeon = 0x7d6,
        _Talent_Brutality = 0x7d7,
        _Talent_Endurance = 0x7d8,
        _Talent_FineTaste = 0x7d9,
        _Talent_Strength = 0x7da,
        _Talent_Brawler = 0x7db,
        _Talent_SecondWind = 0x7dc,
        _Talent_Wit = 0x7dd,
        _Talent_BurningWeapon = 0x7de,
        _Talent_ChillyTouch = 0x7df,
        _Talent_StaticField = 0x7e0,
        _Talent_Fencer = 0x7e1,
        _Talent_LastBreath = 0x7e2,
        _Talent_OBSOLETE1 = 0x7e3,
        _Talent_Intelligence = 0x7e4,
        _Talent_ArcaneCharge = 0x7e5,
        _Talent_Prismatic = 0x7e6,
        _Talent_Battlemage = 0x7e7,
        _Talent_Turtle = 0x7e8,
        _Talent_LastSpark = 0x7e9,
        _Talent_ArcaneCollar = 0x7ea,
        _Talent_Backhander = 0x7eb,
        _Talent_InsultToInjury = 0x7ec,
        _Talent_Manaburn = 0x7ed,
        _Talent_SnapCast = 0x7ee,
        _Talent_CripplingBlast = 0x7ef,
        _Talent_Magic_FastTalker = 0x7f0,
        _Talent_Magic_SoulEater = 0x7f1,
        _Talent_Magic_Concentration = 0x7f2,
        _Talent_Magic_Specialist = 0x7f3,
        _Talent_Magic_WandMaster = 0x7f4,
        _Talent_Melee_BloodThirst = 0x7f5,
        _Talent_Melee_Riposte = 0x7f6,
        _Talent_Melee_ComboStarter = 0x7f7,
        _Talent_Melee_KnowledgeIsPower = 0x7f8,
        _Talent_Melee_SuddenStrike = 0x7f9,
        _Talent_General_GotYouCovered = 0x7fa,
        _Talent_General_Metabolism = 0x7fb,
        _Talent_General_HealthInsurance = 0x7fc,
        _Talent_General_LadyLuck = 0x7fd,
        _Talent_General_UtilityFlow = 0x7fe,
        _Talent_General_KineticEnergy = 0x7ff,
        _Talent_General_EfficientCounter = 0x800,
        _Talent_General_AmmoScavenger = 0x801,
        _Talent_General_QuickShot = 0x802,
        _Talent_General_Alchemist = 0x803,
        _Talent_General_SteadyDefense = 0x804,
        _Talent_Last = 0xbb7,
        _Misc_PotionBuffControl = 0xbb8,
        _Misc_SolemShieldBeam = 0xbb9,
        _Misc_PlayerCacuteProjectile = 0xbba,
        _Misc_BonesSummonProjectile = 0xbbb,
        _Misc_BadgeShadowClone = 0xbbc,
        _Misc_BadgeLightningConduit = 0xbbd,
        _Misc_BadgeCritDMGOnBasicAttackHit = 0xbbe,
        _Misc_BadgeASPDOnBasicAttackHit = 0xbbf,
        _Misc_BadgeSpinningFan = 0xbc0,
        _Misc_BadgeQuickBomb = 0xbc1,
        _Misc_BadgeFireTrail = 0xbc2,
        _Misc_BadgeCloud = 0xbc3,
        _Misc_BadgeNova = 0xbc4,
        _Hidden_MaxHPPenalty1 = 0xfa0,
        _Hidden_MaxHPPenalty10 = 0xfa1,
        _Hidden_Last = 0x1387,
        _Ridiculon_ButterflySwarm = 0x7530,
        _Ridiculon_SnowCharm = 0x7531,
        _Ridiculon_SpringFlowerCharm = 0x7532,
        _Ridiculon_GhostThingy = 0x7533,
        _Ridiculon_FaeTrinket = 0x7534,
        _Ridiculon_SpiderTrinket = 0x7535,
        _EnemySkill_JackLantern_Flame = 0x9c40,
        _EnemySkill_Halloweed_Root = 0x9c41,
        _EnemySkill_BallSpark_HomingSpark = 0x9c42,
        _EnemySkill_Pumpking_CrowSwarm = 0x9c43,
        _EnemySkill_Crystal_ShieldProjectile = 0x9c44,
        _EnemySkill_PGTest_GuardableProjectile = 0x9c45,
        _EnemySkill_PGTest_RoguelikeGuardableProjectile = 0x9c46,
        _EnemySkill_BulletHellKnockbackBullet = 0x9c47,
        _EnemySkill_PhasemanRedBullet = 0x9c48,
        _EnemySkill_PhasemanSpecial = 0x9c49,
        _EnemySkill_PhasemanMegaBullet = 0x9c4a,
        _EnemySkill_GundamRocket = 0x9c4b,
        _EnemySkill_ArbitraryCircularDamage = 0x9c4c,
        _EnemySkill_OrbitBullet = 0x9c4d,
        _EnemySkill_OrbitBullet_Fat = 0x9c4e,
        _EnemySkill_DelayedHomingBullet = 0x9c4f,
        _EnemySkill_GundamMegaBullet = 0x9c50,
        _EnemySkill_GundamMegaBullet_SpawnsHoming = 0x9c51,
        _EnemySkill_ScoundrelSnowBall_Small = 0x9c52,
        _EnemySkill_ScoundrelSnowBall_Big = 0x9c53,
        _EnemySkill_SteamPipeSteam = 0x9c54,
        _EnemySkill_Tornado = 0x9c55,
        _EnemySkill_SummerElder_Root = 0x9c56,
        _EnemySkill_LinearShockwave = 0x9c57,
        _EnemySkill_SpinningShieldThing = 0x9c58,
        _EnemySkill_AutumnMageProjectile = 0x9c59,
        _EnemySkill_WinterMageProjectile = 0x9c5a,
        _EnemySkill_SummerMageProjectile = 0x9c5b,
        _EnemySkill_SummerHydraFire = 0x9c5c,
        _EnemySkill_WinterHydraFrost = 0x9c5d,
        _EnemySkill_AutumnHydraShot = 0x9c5e,
        _EnemySkill_AutumnHydraShot_Poison = 0x9c5f,
        _EnemySkill_AutumnHydraShot_Slowing = 0x9c60,
        _EnemySkill_AutumnHydraShot_InstaBlind = 0x9c61,
        _EnemySkill_WinterElder_IceSpike = 0x9c62,
        _EnemySkill_WinterElder_Tremor = 0x9c63,
        _EnemySkill_WinterElder_Wind = 0x9c64,
        _EnemySkill_GasCloud_Blind = 0x9c65,
        _EnemySkill_GasCloud_Burn = 0x9c66,
        _EnemySkill_GasCloud_Poison = 0x9c67,
        _EnemySkill_GasCloud_Acid = 0x9c68,
        _EnemySkill_QueenBee_Stinger = 0x9c69,
        _EnemySkill_TeddyFreddy_Throw = 0x9c6a,
        _EnemySkill_BossFlower_StraightShotSeed = 0x9c6b,
        _EnemySkill_AcidControlInstance = 0x9c6c,
        _EnemySkill_TempleGuardian_MainOrbitFan = 0x9c6d,
        _EnemySkill_TempleGuardian_SideFan = 0x9c6e,
        _EnemySkill_TempleGuardian_LightspeedFan = 0x9c6f,
        _EnemySkill_TempleGuardian_HomingFan = 0x9c70,
        _EnemySkill_TempleGuardian_BendingFan = 0x9c71,
        _EnemySkill_MossClumpSporeAndVine = 0x9c72,
        _EnemySkill_GiantWormOstkrok = 0x9c73,
        _EnemySkill_GiantWormOstkrok_Recolor = 0x9c74,
        _EnemySkill_GiantWormTail = 0x9c75,
        _EnemySkill_GiantWormTail_Recolor = 0x9c76,
        _EnemySkill_Statue_CrackAndExplode = 0x9c77,
        _EnemySkill_ZhamlaTaiMing_MeteorRain = 0x9c78,
        _EnemySkill_ZhamlaTaiMing_Meteor = 0x9c79,
        _EnemySkill_ZhamlaTaiMing_MeteorBurnedGround = 0x9c7a,
        _EnemySkill_ZhamlaTaiMing_DelayedLightningBolt = 0x9c7b,
        _EnemySkill_ZhamlaTaiMing_SwordThrow = 0x9c7c,
        _EnemySkill_Mimic_Coin_Regular = 0x9c7d,
        _EnemySkill_Mimic_FireSpit = 0x9c7e,
        _EnemySkill_Echo_CurseOfTheBlade = 0x9c7f,
        _EnemySkill_CacuteProjectile = 0x9c80,
        _EnemySkill_BirdSwarm = 0x9c81,
        _EnemySkill_HomingTwilightSpark = 0x9c82,
        _EnemySkill_DashingTwilightMask = 0x9c83,
        _EnemySkill_MarinoShadowDash = 0x9c84,
        _EnemySkill_TwilightDeathSkull = 0x9c85,
        _EnemySkill_TwilightMiniSkull = 0x9c86,
        _EnemySkill_HauntieEctoplasmDrop = 0x9c87,
        _EnemySkill_EliteProjectile = 0x9c88,
        _EnemySkill_CaptainBonesSword = 0x9c89,
        _EnemySkill_KitchenBullet_Knife = 0x9c8a,
        _EnemySkill_KitchenBullet_ExplodingPlate = 0x9c8b,
        _EnemySkill_KitchenBullet_HomingThing = 0x9c8c,
        _EnemySkill_SmallWaterProjectile = 0x9c8d,
        _EnemySkill_BulletSpawningOtherBullets = 0x9c8e,
        _EnemySkill_LukeSmashBall = 0x9c8f,
        _EnemySkill_LukeWeaponThrow_Straight = 0x9c90,
        _EnemySkill_LukeWeaponThrow_Path = 0x9c91
    }
}
