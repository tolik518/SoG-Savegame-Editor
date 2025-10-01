using System;

public interface ITextBoxWrapper
{
    bool InvokeRequired { get; }
    void Invoke(Action action);
    void AppendText(string text);
}