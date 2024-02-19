using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SoG_SGreader.Wrapper;

namespace SoG_SGreader
{
    public partial class FrmLoadSaveGame : Form
    {
        private string filePath = "";
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
                filePath = Path.Combine(filePath, lstvSaveGames.SelectedItems[0].Text);
            }
            FrmMain frmMain = new FrmMain(filePath);
            Hide();
            frmMain.ShowDialog();
            Close();
        }
        
        private void GetSaveGameFiles(string sFilePath)
        {
            lstvSaveGames.Items.Clear();
            for (int i = 0; i != 9; i++)
            {
                string savegame = Path.Combine(sFilePath, i + ".cha");
                if (File.Exists(savegame))
                {
                    string[] item = new string[] { i + ".cha", DataReader.GetCharName(savegame)};
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
            return filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + Path.Combine("Secrets of Grindea","Characters");
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            using (var chooseFolder = new FolderBrowserDialog()) //ANY dialog
            {
                chooseFolder.ShowNewFolderButton = false;
                if (chooseFolder.ShowDialog() == DialogResult.OK)
                {
                    filePath = chooseFolder.SelectedPath;
                    GetSaveGameFiles(chooseFolder.SelectedPath);
                    UpdateFilePathLabel();
                }
            }
        }

        private void BtnStartWithoitLoading_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain("");
            Hide();
            frmMain.ShowDialog();
            Close();
        }

        private void UpdateFilePathLabel()
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                lblFilePath.Text = Path.Combine(filePath, lstvSaveGames.SelectedItems[0].Text);
            }
            else
            {
                lblFilePath.Text = filePath;
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
