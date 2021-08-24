using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sog_SGreader
{
    public partial class FrmLoadSaveGame : Form
    {
        public string sFilePath = "";
        public FrmLoadSaveGame()
        {
            InitializeComponent();
            string sSaveGamePath = GetSaveGamePath();
            GetSaveGameFiles(sSaveGamePath);
            UpdateFilePathLabel();
        }

        private void BtnLoadSaveGame_Click(object sender, EventArgs e)
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                sFilePath = sFilePath + "\\" + lstvSaveGames.SelectedItems[0].Text;
            }
            FrmMain frmMain = new FrmMain(sFilePath);
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private string GetCharName(string fileName)
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
                    int iQs_ID = readBinary.ReadByte();
                    if (iQs_ID == 1)
                    {
                        readBinary.ReadInt32(); //pPlayer.quickslots.Add((Sog_Items)
                }
                    else if (iQs_ID == 2)
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

        private void GetSaveGameFiles(string sFilePath)
        {
            lstvSaveGames.Items.Clear();
            for (int i = 0; i != 9; i++)
            {
                if (File.Exists(sFilePath + "\\" + i + ".cha"))
                {
                    string[] item = new string[] { i + ".cha", GetCharName(sFilePath + "\\" + i + ".cha")};
                    lstvSaveGames.Items.Add(new ListViewItem(item, 0));
                }
            }
            if (lstvSaveGames.Items.Count != 0)
            {
                lblSaveGameCount.ForeColor = Color.Black;
                lblSaveGameCount.Text = lstvSaveGames.Items.Count + " Savegames found.";
            }
            else
            {
                lblSaveGameCount.ForeColor = Color.Red;
                lblSaveGameCount.Text = "No Savegames found!";
            }
        }

        private string GetSaveGamePath()
        {
            return sFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Secrets of Grindea\Characters";
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            using (var chooseFolder = new FolderBrowserDialog()) //ANY dialog
            {
                chooseFolder.ShowNewFolderButton = false;
                if (chooseFolder.ShowDialog() == DialogResult.OK)
                {
                    sFilePath = chooseFolder.SelectedPath;
                    GetSaveGameFiles(chooseFolder.SelectedPath);
                    UpdateFilePathLabel();
                }
            }
        }

        private void BtnStartWithoitLoading_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain("");
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void UpdateFilePathLabel()
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                lblFilePath.Text = sFilePath + "\\" + lstvSaveGames.SelectedItems[0].Text;
            }
            else
            {
                lblFilePath.Text = sFilePath;
            }
        }

        private void LstvSaveGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                btnLoadSaveGame.Enabled = true;
            }
            UpdateFilePathLabel();

        }
    }
}
