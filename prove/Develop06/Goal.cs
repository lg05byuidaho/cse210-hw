public abstract class Goal
{
    // Private member variables (encapsulation)
    private string _name;
    private int _points;
    private bool _isComplete;

    // Public property for Name (Encapsulation)
    public string Name 
    { 
        get => _name; 
        set => _name = value; 
    }
    
    // Public property for Points (Encapsulation)
    public int Points 
    { 
        get => _points; 
        protected set => _points = value; 
    }
    
    // Public property for IsComplete (Encapsulation)
    public bool IsComplete 
    { 
        get => _isComplete; 
        protected set => _isComplete = value; 
    }

    // Constructor to initialize goal with name
    public Goal(string name)
    {
        _name = name;
        _isComplete = false;
        _points = 0;
    }

    // Abstract method for recording progress (Polymorphism)
    public abstract void RecordProgress();

    // Abstract method for displaying goal status (Polymorphism)
    public abstract void DisplayStatus();

    // Method to get the total points for a goal
    public virtual int GetPoints()
    {
        return _points;
    }
}
