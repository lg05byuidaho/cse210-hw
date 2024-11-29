// Entry.cs
using System;

public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; }

    // Constructor for the Entry class
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Override ToString() to display the entry in a readable format
    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response}";
    }
}
