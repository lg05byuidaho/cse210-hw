// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Display menu and get user input for activity selection
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Example menu with options
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listing Activity");
        Console.WriteLine("3. Reflecting Activity");
        Console.WriteLine("Please select an activity by typing the number:");

        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;
            case "2":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;
            case "3":
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}
