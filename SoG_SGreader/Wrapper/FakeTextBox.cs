using System;

namespace SoG_SGreader.Wrapper
{
    public class FakeTextBox : ITextBoxWrapper
    {
        public void AppendText(string text)
        {
            // Do nothing   
        }
        bool ITextBoxWrapper.InvokeRequired => throw new NotImplementedException();

        public void Invoke(Action action)
        {
            //
        }
    }
}