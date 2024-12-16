public class SimpleGoal : Goal
{
    public bool _isComplete;

    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Implement GetPoints for SimpleGoal
    public override int GetPoints()
    {
        return _points;
    }

    // RecordEvent for SimpleGoal (marks the goal as complete)
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Override GetStringRepresentation to save goal data
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }
}
