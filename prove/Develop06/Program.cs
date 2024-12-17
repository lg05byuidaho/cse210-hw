public class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Eternal Quest Program!");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record progress");
            Console.WriteLine("3. View goals");
            Console.WriteLine("4. View total score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(goalManager);
                    break;
                case "2":
                    RecordProgress(goalManager);
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "6":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private static void CreateGoal(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine();
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        
        Goal goal = type.ToLower() switch
        {
            "simple" => new SimpleGoal(name, 1000),
            "eternal" => new EternalGoal(name, 100),
            "checklist" => new ChecklistGoal(name, 10, 500),
            _ => null
        };

        if (goal != null)
        {
            goalManager.AddGoal(goal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private static void RecordProgress(GoalManager goalManager)
    {
        Console.WriteLine("Enter goal name to record progress: ");
        string name = Console.ReadLine();

        Goal goal = goalManager.Goals.FirstOrDefault(g => g.Name == name);

        if (goal != null)
        {
            goal.RecordProgress();
            Console.WriteLine($"Progress recorded for {goal.Name}!");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}
