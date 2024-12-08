public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor that calls the base class constructor and initializes Writing-specific attributes
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Calls the base class constructor
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }
    
    // Method to return the writing assignment information
    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
