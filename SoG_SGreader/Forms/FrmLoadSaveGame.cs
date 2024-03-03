using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            ForwardSelectedSavegameToMain();
        }

        private void GetSaveGameFiles(string sFilePath)
        {
            lstvSaveGames.Items.Clear();
            for (int i = 0; i != 9; i++)
            {
                string savegame = Path.Combine(sFilePath, i + ".cha");
                if (File.Exists(savegame))
                {
                    PlayerPreview player = DataReader.GetCharName(savegame);
                    string[] item = new string[] { i.ToString(), player.GetSex(), player.Nickname };
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
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return filePath = appDataPath + Path.DirectorySeparatorChar + Path.Combine("Secrets of Grindea", "Characters");
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + Path.Combine("Secrets of Grindea", "Characters"),
                Filter = "SoG Savegame (*.cha)|*.cha",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FrmMain frmMain = new FrmMain(openFileDialog.FileName);
                Hide();
                frmMain.ShowDialog();
                Close();
            }
        }

        private void UpdateFilePathLabel()
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                lblFilePath.Text = Path.Combine(filePath, lstvSaveGames.SelectedItems[0].Text + ".cha");
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

        private void ForwardSelectedSavegameToMain()
        {
            if (lstvSaveGames.SelectedItems.Count != 0)
            {
                filePath = Path.Combine(filePath, lstvSaveGames.SelectedItems[0].Text + ".cha");
            }
            FrmMain frmMain = new FrmMain(filePath);
            Hide();
            frmMain.ShowDialog();
            Close();
        }

        private void lstvSaveGames_DoubleClick(object sender, EventArgs e)
        {
             ForwardSelectedSavegameToMain();
        }

        private void FrmLoadSaveGame_Load(object sender, EventArgs e)
        {

        }
    }
}
