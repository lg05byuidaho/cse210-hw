public class MathAssignment : Assignment
{
    // Private member variables specific to Math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor that calls the base class constructor and initializes Math-specific attributes
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)  // Calls the base class constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
        
    }

    // Method to return the list of homework problems for Math assignments
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
