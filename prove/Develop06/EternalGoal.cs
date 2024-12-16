public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    // Implement GetPoints for EternalGoal (same as SimpleGoal)
    public override int GetPoints()
    {
        return _points;
    }

    // RecordEvent for EternalGoal (does nothing since it's eternal)
    public override void RecordEvent()
    {
        // No change in state needed for EternalGoal
    }

    // Check if the goal is complete (eternal goals are always complete)
    public override bool IsComplete()
    {
        return true; // Eternal goals are always considered complete
    }

    // Override GetStringRepresentation for saving data
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},true";
    }
}
