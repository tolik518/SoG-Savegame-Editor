using System.Windows.Forms;

namespace Sog_SGreader
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            lblBuild.Text = "Build: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tolik518/SoG_SGreader");
        }

        private void Label6_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, "DUEm64pPyZi4V9XF7mFE6v2YahGhcURk1F");
        }
    }
}
