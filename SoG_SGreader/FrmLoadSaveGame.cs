using System;
using System.IO;
using System.Windows.Forms;                 

namespace SoG_SGreader
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
            if(lstSaveGames.SelectedIndex != -1)
            {
                sFilePath = sFilePath + "\\" + lstSaveGames.SelectedItem.ToString();
            }
            FrmMain frmMain = new FrmMain(sFilePath);
            this.Hide();
            frmMain.ShowDialog();
            this.Close();
        }

        private void GetSaveGameFiles(string sFilePath)
        {
            lstSaveGames.Items.Clear();
            for(int i = 0; i != 10; i++)
            { 
                if (File.Exists(sFilePath + "\\" + i +".cha")) 
                {
                    lstSaveGames.Items.Add(i + ".cha");
                }
            }
        }

        private string GetSaveGamePath()
        {
            return sFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Secrets of Grindea/Characters";
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

        private void LstSaveGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSaveGames.SelectedIndex != -1)
            {
                btnLoadSaveGame.Enabled = true;
            }
            UpdateFilePathLabel();
        }

        private void UpdateFilePathLabel()
        {
            if (lstSaveGames.SelectedIndex != -1)
            {
                lblFilePath.Text = sFilePath + "\\" + lstSaveGames.SelectedItem.ToString();
            }
            else
            {
                lblFilePath.Text = sFilePath;
            }
        }
    }
}
