public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetTimes;
    private int _bonusPoints;

    // Constructor to initialize ChecklistGoal with a name, target count, and bonus points
    public ChecklistGoal(string name, int targetTimes, int bonusPoints) : base(name)
    {
        _timesCompleted = 0;
        _targetTimes = targetTimes;
        _bonusPoints = bonusPoints;
    }

    // Override RecordProgress method (Polymorphism)
    public override void RecordProgress()
    {
        if (_timesCompleted < _targetTimes)
        {
            _timesCompleted++;
            Points += 50; // 50 points each time the goal is recorded

            // Add bonus points when target is met
            if (_timesCompleted == _targetTimes)
            {
                Points += _bonusPoints;
            }
        }
    }

    // Override DisplayStatus method (Polymorphism)
    public override void DisplayStatus()
    {
        string status = (_timesCompleted >= _targetTimes) ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - Completed {_timesCompleted}/{_targetTimes} times. {Points} points.");
    }
}
