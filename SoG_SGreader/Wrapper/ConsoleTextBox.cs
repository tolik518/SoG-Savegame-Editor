using System;

namespace SoG_SGreader.Wrapper
{
    public class ConsoleTextBox : ITextBoxWrapper
    {
        public void AppendText(string text)
        {
            Console.Write(text);
        }
    }
}