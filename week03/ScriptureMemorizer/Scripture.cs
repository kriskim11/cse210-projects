using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;      
    private List<Word> _words;         

    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int NumberToHide)
    {
           Random rand = new Random();
    List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

    int numberToHide = Math.Min(NumberToHide, visibleWords.Count);

    for (int word = 0; word < numberToHide; word++)
    {
        int index = rand.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index); 
    }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}