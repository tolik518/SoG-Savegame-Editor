using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoG_Savegame_Editor
{
    public partial class FrmColorSelect : Form
    {
        public FrmColorSelect()
        {
            InitializeComponent();
        }
        public string Color;
        private void ColorSelect(object sender, EventArgs e)
        {
            Color = ColorTranslator.ToHtml(((Control)sender).BackColor);
            Close();
        }
    }
}
