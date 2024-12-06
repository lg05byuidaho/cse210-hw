// File: Word.cs
public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }
    public string HiddenText => new string('_', Text.Length);

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    // Hide the word by marking it as hidden
    public void Hide()
    {
        IsHidden = true;
    }
}
