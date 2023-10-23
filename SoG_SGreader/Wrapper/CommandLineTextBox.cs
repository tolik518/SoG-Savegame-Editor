using System;

namespace SoG_SGreader.Wrapper
{
    public class CommandLineTextBox : ITextBoxWrapper
    {
        public void AppendText(string text)
        {
            Console.Write(text);
        }
 
        bool ITextBoxWrapper.InvokeRequired => throw new NotImplementedException();

        public void Invoke(Action action)
        {
        }
    }
}