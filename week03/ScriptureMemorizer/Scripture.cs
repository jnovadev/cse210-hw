using System;
using System.Collections.Generic;

class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = Random.Shared.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();

        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", displayedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
