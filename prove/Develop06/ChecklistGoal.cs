public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Implement GetPoints for ChecklistGoal
    public override int GetPoints()
    {
        if (IsComplete())
        {
            return _points + _bonus; // Return base points + bonus if complete
        }
        return _points;
    }

    // RecordEvent for ChecklistGoal (increments the completion counter)
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    // Check if the goal is complete (if the target is reached)
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Override GetDetailsString for ChecklistGoal (show progress)
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_amountCompleted}/{_target} completed - {_points} points";
    }

    // Override GetStringRepresentation to save data
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}
