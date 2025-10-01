using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoG_Savegame_Editor.CustomControls
{
    /// <summary>
    /// A PictureBox with configurable interpolation mode.
    /// Copy-Pasted from https://www.codeproject.com/Articles/717312/PixelBox-A-PictureBox-with-configurable-Interpolat
    /// </summary>
    public class NumericUpDownWrap : NumericUpDown
    {
        #region Initialization
        public NumericUpDownWrap()
        {
            // Set default.
            Wrap = true;
        }
        #endregion

        #region Properties
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool Wrap { get; set; }
        #endregion

        protected override void UpdateEditText()
        {
            // Wrap logic
            if (Value < Minimum)
            {
                Value = Maximum;  // Wrap to maximum if the value goes below minimum
            }
            else if (Value > Maximum)
            {
                Value = Minimum;  // Wrap to minimum if the value exceeds maximum
            }
            else
            {
                base.UpdateEditText();  // Use default behavior otherwise
            }
        }

        public override void DownButton()
        {
            // Need to handle wrapping when the down button is clicked
            if (Value == Minimum)
            {
                Value = Maximum;  // Wrap to maximum
            }
            else
            {
                base.DownButton();
            }
        }

        public override void UpButton()
        {
            // Need to handle wrapping when the up button is clicked
            if (Value == Maximum)
            {
                Value = Minimum;  // Wrap to minimum
            }
            else
            {
                base.UpButton();
            }
        }
    }
}
