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
            GetSaveGameFiles(GetGamePath());
        }
         //proabbly better to have 2 buttons. One that loads the savegame and one that starts the tool without loading
        private void BtnLoadSaveGame_Click(object sender, EventArgs e)
        {
            if(lstSaveGames.SelectedIndex != -1)
            {
                sFilePath = sFilePath + lstSaveGames.SelectedItem.ToString();
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
                if (File.Exists(sFilePath + i +".cha")) 
                {
                    lstSaveGames.Items.Add(i + ".cha");
                }
            }
        }

        private string GetGamePath()
        {
            return sFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/Secrets of Grindea/Characters/";
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
                }
            }
        }
    }
}
