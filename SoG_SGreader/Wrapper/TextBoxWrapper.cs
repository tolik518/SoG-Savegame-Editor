using System.Windows.Forms;

namespace SoG_SGreader.Wrapper
{

    public class TextBoxWrapper : ITextBoxWrapper
    {
        private TextBox _textBox;

        public TextBoxWrapper(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void AppendText(string text)
        {
            _textBox.AppendText(text);
        }
    }
}