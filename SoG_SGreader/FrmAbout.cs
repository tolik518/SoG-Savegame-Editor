using System.Windows.Forms;

namespace SoG_SGreader
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
    }
}
