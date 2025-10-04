using System;

class Word
{
    private string text;
    private bool hidden;

    public Word(string t)
    {
        text = t;
        hidden = false;
    }

    public void Hide()
    {
        hidden = true;
    }

    public bool IsHidden()
    {
        return hidden;
    }

    public override string ToString()
    {
        if (!hidden)
            return text;

        string result = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
                result += "_";
            else
                result += c;
        }
        return result;
    }
}
