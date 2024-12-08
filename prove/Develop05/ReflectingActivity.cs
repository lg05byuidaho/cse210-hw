// ReflectingActivity.cs
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on specific prompts with questions", 50)
    {
        _prompts = new List<string>();  // Initialize with prompts
        _questions = new List<string>();  // Initialize with questions
    }

    public string GetRandomPrompt()
    {
        // Return a random prompt for reflection
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        // Return a random question for the reflection
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        // Display the random prompt to the user
    }

    public void DisplayQuestions()
    {
        // Display questions related to the prompt and collect answers
    }

    public void Run()
    {
        // Run the Reflecting Activity
    }
}
