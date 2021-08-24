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
            Clipboard.SetData(DataFormats.Text, "addr1q8lscf0hrrf883q3ztdlpafge8vp8g6n2mjexhwg5m2nylk48l93aamzj4h9kw6yxpwca2dnkgmf2whqlaw0cym7mzwsrn5hch");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cardano.org/");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/cardano/");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/cardano_ELI5");
        }
    }
}
