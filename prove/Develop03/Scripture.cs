using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the scripture text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a random number of words
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsHidden = 0;
        
        while (wordsHidden < numberToHide)
        {
            int index = rand.Next(0, _words.Count);
            Word word = _words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                wordsHidden++;
            }
        }
    }

    // Get the text of the scripture with hidden words replaced by underscores
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    // Check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
