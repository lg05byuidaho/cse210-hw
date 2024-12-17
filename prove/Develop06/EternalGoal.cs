public class EternalGoal : Goal
{
    // Constructor to initialize EternalGoal with a name and points
    public EternalGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    // Override RecordProgress method (Polymorphism)
    public override void RecordProgress()
    {
        Points += 100;  // Add points each time it is recorded
    }

    // Override DisplayStatus method (Polymorphism)
    public override void DisplayStatus()
    {
        Console.WriteLine($"[ ] {Name} - {Points} points (Eternal goal, not complete)");
    }
}
