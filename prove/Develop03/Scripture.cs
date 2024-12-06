// File: Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();
        string[] textWords = text.Split(' ');

        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Display the scripture with hidden words (replacing with underscores)
    public void DisplayScripture()
    {
        StringBuilder scriptureText = new StringBuilder(_reference.Text + " ");
        foreach (Word word in _words)
        {
            scriptureText.Append(word.IsHidden ? word.HiddenText : word.Text);
            scriptureText.Append(" ");
        }
        Console.WriteLine(scriptureText.ToString().Trim());
    }

    // Hide a random word
    public void HideRandomWord()
    {
        Random rand = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count == 0) return; // No words left to hide

        Word wordToHide = visibleWords[rand.Next(visibleWords.Count)];
        wordToHide.Hide();
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
