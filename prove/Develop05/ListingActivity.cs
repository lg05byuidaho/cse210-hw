// ListingActivity.cs
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "A listing activity to help you reflect on certain topics", 60)
    {
        _prompts = new List<string>();  // Initialize with a set of prompts
        _count = 0;  // Initialize count to 0
    }

    public string GetRandomPrompt()
    {
        // Return a random prompt from the list
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        // Collect responses from the user for the current prompt
        List<string> responses = new List<string>();
        // Logic for gathering user input would go here
        return responses;
    }

    public void Run()
    {
        // Run the Listing Activity
    }
}
