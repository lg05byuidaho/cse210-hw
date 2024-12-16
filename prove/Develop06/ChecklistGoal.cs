// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Override to record the event (increment amount completed)
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    // Override to check if the goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override to provide details including amount completed
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_amountCompleted}/{_target})";
    }

    // Override to provide a string representation for saving to a file
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
