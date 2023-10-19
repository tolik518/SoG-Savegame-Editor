using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoG_SGreader
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
