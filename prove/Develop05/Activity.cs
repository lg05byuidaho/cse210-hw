// Activity.cs
using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        // Code to display the starting message
    }

    public void DisplayEndingMessage()
    {
        // Code to display the ending message
    }

    public void ShowSpinner(int seconds)
    {
        // Code to show a spinner for a given time
    }

    public void ShowCountDown(int seconds)
    {
        // Code to show a countdown timer for the given time
    }
}
