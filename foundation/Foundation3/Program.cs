using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity
        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling bike = new Cycling(new DateTime(2022, 11, 3), 45, 15.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 40, 20);

        // Create a list of activities
        List<Activity> activities = new List<Activity> { run, bike, swim };

        // Iterate through the activities and display their summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

