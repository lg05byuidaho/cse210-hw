// Goal.cs
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Abstract method to record an event (to be overridden by derived classes)
    public abstract void RecordEvent();

    // Abstract method to check if the goal is complete (to be overridden by derived classes)
    public abstract bool IsComplete();

    // Default method to return the goal details as a string
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }

    // Abstract method to get a string representation of the goal for saving to a file
    public abstract string GetStringRepresentation();
}
