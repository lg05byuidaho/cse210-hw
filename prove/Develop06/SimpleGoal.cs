// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Override to record the event (mark it complete)
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override to provide a string representation for saving to a file
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}
