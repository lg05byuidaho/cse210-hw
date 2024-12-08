using System;
using System.Threading;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    // Constructor to initialize the activity
    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    // Set the duration for the activity
    public void SetDuration(int durationInSeconds)
    {
        duration = durationInSeconds;
    }

    // Display the start message for the activity
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {name}...");
        Console.WriteLine(description);
        Console.WriteLine($"Please set the duration (in seconds): ");
        int durationInput = int.Parse(Console.ReadLine());
        SetDuration(durationInput);

        // Countdown before starting
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display a common ending message for all activities
    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine($"Well done! You completed {name} for {duration} seconds.");
        ShowSpinner(3);
    }

    // Show a spinner animation during pauses
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b/");
            Thread.Sleep(500);
            Console.Write("\b-");
            Thread.Sleep(500);
            Console.Write("\b\\");
            Thread.Sleep(500);
            Console.Write("\b|");
            Thread.Sleep(500);
        }
    }

    // Abstract method to be implemented by derived classes
    public abstract void ExecuteActivity();
}
