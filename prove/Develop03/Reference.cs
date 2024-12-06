// File: Reference.cs
public class Reference
{
    public string Text { get; private set; }

    // Constructor for a single verse
    public Reference(string reference)
    {
        Text = reference;
    }

    // Constructor for a verse range
    public Reference(string startVerse, string endVerse)
    {
        Text = $"{startVerse}-{endVerse}";
    }
}
