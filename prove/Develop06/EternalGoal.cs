// EternalGoal.cs
public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points) { }

    // Override to record the event (Eternal goals don't technically complete)
    public override void RecordEvent()
    {
        // Implement specific logic for eternal goals if necessary
    }

    // Override to return that eternal goals never complete
    public override bool IsComplete()
    {
        return false; // Eternal goals never complete
    }

    // Override to provide a string representation for saving to a file
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}
