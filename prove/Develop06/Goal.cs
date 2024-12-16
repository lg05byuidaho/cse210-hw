public abstract class Goal
{
    // Shared attributes across all goal types
    public string _shortName;
    public string _description;
    public int _points;

    // Constructor for common goal attributes
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Abstract method for getting points (must be implemented by derived classes)
    public abstract int GetPoints();

    // Abstract method to record an event (must be implemented by derived classes)
    public abstract void RecordEvent();

    // Abstract method to check if the goal is complete (must be implemented by derived classes)
    public abstract bool IsComplete();

    // Method to get details for display (common implementation)
    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points";
    }

    // Abstract method to get a string representation of the goal for saving
    public abstract string GetStringRepresentation();
}
