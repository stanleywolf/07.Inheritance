using System;
using System.Collections.Generic;
using System.Text;

public class StackOfStrings
{
    List<string> data = new List<string>();

    public string Pop()
    {
        string result = String.Empty;
        if (!IsEmpty())
        {
            var lastIndex = data.Count - 1;
            result = data[lastIndex];
            data.RemoveAt(lastIndex);
        }
        return result;
    }
    public string Peek()
    {
        string result = String.Empty;
        var lastIndex = data.Count - 1;

        if (!IsEmpty())
        {
            result = data[lastIndex];
        }
        return result;
    }
    public void Push(string newElement)
    {
        data.Add(newElement);
    }
    public bool IsEmpty()
    {
        return data.Count == 0;
    }
}