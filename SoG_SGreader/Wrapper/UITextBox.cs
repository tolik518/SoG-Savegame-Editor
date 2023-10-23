using System;
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
            if (_textBox.InvokeRequired)
            {
                _textBox.Invoke(new Action(() => _textBox.AppendText(text)));
            }
            else
            {
                _textBox.AppendText(text);
            }
        }


        public bool InvokeRequired => _textBox.InvokeRequired;

        public void Invoke(Action action)
        {
            _textBox.Invoke(action);
        }
    }
}