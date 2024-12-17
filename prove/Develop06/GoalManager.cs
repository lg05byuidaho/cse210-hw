public class GoalManager
{
    // Private list to store goals (Encapsulation)
    private List<Goal> _goals;

    // Constructor to initialize GoalManager with an empty list of goals
    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    // Method to add a goal to the list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to display all goals
    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            goal.DisplayStatus();
        }
    }

    // Method to display total score
    public void DisplayScore()
    {
        int totalPoints = _goals.Sum(g => g.GetPoints());
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    // Method to save goals to a file (Saving/Loading)
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}:{goal.Name},{goal.GetPoints()}");
            }
        }
    }

    // Method to load goals from a file (Saving/Loading)
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] goalData = parts[1].Split(",");
            string name = goalData[0];
            int points = int.Parse(goalData[1]);

            Goal goal = type switch
            {
                "SimpleGoal" => new SimpleGoal(name, points),
                "EternalGoal" => new EternalGoal(name, points),
                "ChecklistGoal" => new ChecklistGoal(name, 10, 500),
                _ => throw new Exception("Unknown goal type.")
            };

            _goals.Add(goal);
        }
    }

    // Public getter for goals
    public List<Goal> Goals => _goals;
}
