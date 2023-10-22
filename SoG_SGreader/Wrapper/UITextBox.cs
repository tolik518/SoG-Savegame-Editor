using System.Windows.Forms;

namespace SoG_SGreader.Wrapper
{
    public class UITextBox : ITextBoxWrapper
    {
        private TextBox _textBox;

        public UITextBox(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void AppendText(string text)
        {
            _textBox.AppendText(text);
        }
    }
}