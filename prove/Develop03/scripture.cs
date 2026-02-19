using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word w = new Word(part);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int amount)
    {
        // hides 3 random words each time
        for (int i = 0; i < amount; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].HideWord();
        }
    }

    public bool AllHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetScriptureText()
    {
        string text = "";

        foreach (Word w in _words)
        {
            text += w.GetWord() + " ";
        }

        return _reference.GetReference() + "\n" + text;
    }
}
