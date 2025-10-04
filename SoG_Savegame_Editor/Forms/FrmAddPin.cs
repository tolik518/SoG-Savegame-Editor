using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoG_Savegame_Editor
{
    public class FrmAddPin : Form
    {
        private ComboBox cbPin;
        private ComboBox cbTarget;
        private Button btnOK;
        private Button btnCancel;

        public SogPin SelectedPin { get; private set; }
        public string TargetList { get; private set; }

        public FrmAddPin()
        {
            Text = "Add Pin";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(360, 140);
            MaximizeBox = false;
            MinimizeBox = false;

            var lblPin = new Label { Text = "Pin:", Location = new Point(12, 18), AutoSize = true };
            cbPin = new ComboBox { Location = new Point(80, 14), Size = new Size(260, 21), DropDownStyle = ComboBoxStyle.DropDownList };
            cbPin.DataSource = System.Enum.GetNames(typeof(SogPin));

            var lblTarget = new Label { Text = "Add to:", Location = new Point(12, 54), AutoSize = true };
            cbTarget = new ComboBox { Location = new Point(80, 50), Size = new Size(260, 21), DropDownStyle = ComboBoxStyle.DropDownList };
            cbTarget.Items.AddRange(new object[] { "PinsSeen", "PinsOnShelf", "PinsEquipped", "PinsLatest" });
            cbTarget.SelectedIndex = 0;

            btnOK = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new Point(176, 92), Size = new Size(75, 25) };
            btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new Point(258, 92), Size = new Size(75, 25) };

            btnOK.Click += BtnOK_Click;

            Controls.Add(lblPin);
            Controls.Add(cbPin);
            Controls.Add(lblTarget);
            Controls.Add(cbTarget);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);

            AcceptButton = btnOK;
            CancelButton = btnCancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbPin.Text) || string.IsNullOrEmpty(cbTarget.Text))
            {
                MessageBox.Show("Please select a pin and a target list.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            SelectedPin = (SogPin)System.Enum.Parse(typeof(SogPin), cbPin.Text);
            TargetList = cbTarget.Text;
            // DialogResult remains OK, form will close
        }
    }
}
