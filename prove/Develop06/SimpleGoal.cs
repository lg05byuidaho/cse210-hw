public class SimpleGoal : Goal
{
    // Constructor to initialize SimpleGoal with a name and points
    public SimpleGoal(string name, int points) : base(name)
    {
        Points = points;
    }

    // Override RecordProgress method (Polymorphism)
    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Points += 100; // Fixed points for completion
        }
    }

    // Override DisplayStatus method (Polymorphism)
    public override void DisplayStatus()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Points} points");
    }
}
