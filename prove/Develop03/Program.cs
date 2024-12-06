using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // Load scriptures from the .txt file
        List<Scripture> scriptures = LoadScripturesFromTextFile("scriptures.txt");

        // Select a random scripture from the list
        Random random = new Random();
        Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

        // Display the scripture and interact with the user
        Console.WriteLine($"Memorize this scripture: {randomScripture.Reference.Text}");
        randomScripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            randomScripture.HideRandomWord();
            Console.Clear();
            randomScripture.DisplayScripture();

            if (randomScripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! You've completed memorizing the scripture.");
                break;
            }
        }
    }

    // Method to load scriptures from a .txt file
    public static List<Scripture> LoadScripturesFromTextFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                // Split each line into reference and text
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    // Create a new Scripture object with reference and text
                    scriptures.Add(new Scripture(parts[0], parts[1]));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }

        return scriptures;
    }
}

// Scripture class
public class Scripture
{
    public Reference Reference { get; set; }
    public string Text { get; set; }
    private List<Word> _words; // List of Word objects to handle hiding functionality

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Text = text;
        _words = new List<Word>();

        // Split the text into words and create Word objects for each word
        string[] words = Text.Split(' ');
        foreach (var word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        // Display the reference
        Console.WriteLine($"Reference: {Reference.Text}");

        // Display the text with hidden words as underscores
        foreach (var word in _words)
        {
            Console.Write(word.IsHidden ? new string('_', word.Text.Length) : word.Text);
            Console.Write(" ");
        }

        Console.WriteLine(); // Move to next line after displaying scripture
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> hiddenWords = _words.FindAll(w => !w.IsHidden);

        if (hiddenWords.Count > 0)
        {
            // Choose a random word that is not yet hidden
            Word randomWord = hiddenWords[random.Next(hiddenWords.Count)];
            randomWord.IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden); // Check if all words are hidden
    }
}

// Reference class
public class Reference
{
    public string Text { get; set; }

    public Reference(string text)
    {
        Text = text;
    }
}

// Word class
public class Word
{
    public string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
}
