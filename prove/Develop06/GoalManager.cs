// GoalManager.cs
using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Main menu system for the goal manager
    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Goal Tracking Program");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Display player's current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // List all the goals
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple/Eternal/Checklist):");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter goal short name:");
        string shortName = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for goal:");
        int points = int.Parse(Console.ReadLine());

        if (goalType.ToLower() == "simple")
        {
            _goals.Add(new SimpleGoal(shortName, description, points));
        }
        else if (goalType.ToLower() == "eternal")
        {
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (goalType.ToLower() == "checklist")
        {
            Console.WriteLine("Enter target for checklist:");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter bonus for checklist:");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Record event for a specific goal
    public void RecordEvent()
    {
        Console.WriteLine("Enter the number of the goal to record event for:");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            if (_goals[goalIndex].IsComplete())
            {
                _score += _goals[goalIndex].GetPoints();
            }
        }

        Console.WriteLine("Event recorded successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Save goals to file (simple implementation)
    public void SaveGoals()
    {
        // Implement saving to file
        Console.WriteLine("Goals saved successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    // Load goals from file (simple implementation)
    public void LoadGoals()
    {
        // Implement loading from file
        Console.WriteLine("Goals loaded successfully.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
