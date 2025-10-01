using System;

namespace SoG_Savegame_Editor.Wrapper
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