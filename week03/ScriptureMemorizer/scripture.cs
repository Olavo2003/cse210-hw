using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference r, string text)
    {
        reference = r;
        words = new List<Word>();
        foreach (var part in text.Split(' '))
        {
            words.Add(new Word(part));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference);
        foreach (Word w in words)
            Console.Write(w + " ");
        Console.WriteLine("\n");
    }

    public bool HideRandomWords(int count)
    {
        Random rand = new Random();
        List<int> available = new List<int>();
        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].IsHidden())
                available.Add(i);
        }

        if (available.Count == 0)
            return false;

        for (int i = 0; i < count && available.Count > 0; i++)
        {
            int index = rand.Next(available.Count);
            words[available[index]].Hide();
            available.RemoveAt(index);
        }
        return true;
    }

    public bool AllHidden()
    {
        foreach (Word w in words)
            if (!w.IsHidden())
                return false;
        return true;
    }
}
