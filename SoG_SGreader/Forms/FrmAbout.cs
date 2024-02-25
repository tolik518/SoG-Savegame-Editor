using SoG_SGreader.Wrapper;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace SoG_SGreader
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            lblBuild.Text = lblBuild.Text.Replace("0.0.000.000", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);      //AssemblyFileVersion
            lblVersion.Text = lblVersion.Text.Replace("0.0.0", Application.ProductVersion);
            lblCurrentPatch.Text = lblCurrentPatch.Text.Replace("0.000a", FrmMain.SupportedPatch);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/tolik518/SoG_SGreader");
        }

        private void lblVersion_Click(object sender, System.EventArgs e)
        {

        }

        private async void FrmAbout_Load(object sender, System.EventArgs e)
        {
            ITextBoxWrapper txtConsoleWrapped = new FakeTextBox();

            try
            {
                var patchVersion = await GamePatchReader.GetCurrentGamePatchAsync(txtConsoleWrapped);
                lblYourPatch.Text = lblYourPatch.Text.Replace("0.000a", patchVersion);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                lblYourPatch.Text = "Error fetching patch version.";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
