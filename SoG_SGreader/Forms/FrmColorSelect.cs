using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sog_SGreader
{
    public partial class FrmColorSelect : Form
    {
        public FrmColorSelect()
        {
            InitializeComponent();
        }
        public string sColor;
        private void ColorSelect(object sender, EventArgs e)
        {
         
            sColor = ColorTranslator.ToHtml(((Control)sender).BackColor);
            this.Close();
        }
    }
}
