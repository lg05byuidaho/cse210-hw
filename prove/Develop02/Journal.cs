// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    private readonly List<string> _prompts;

    public Journal()
    {
        _entries = new List<Entry>();
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Add a new entry to the journal
    public void AddEntry(string response)
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Entry newEntry = new Entry(prompt, response, date);
        _entries.Add(newEntry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries available.");
            return;
        }

        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    // Save journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Load journal entries from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    _entries.Add(new Entry(prompt, response, date));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
