class VerseReference
{
    private string _verseReference;
    // Constructor for VerseReference. I did not understand how to incorporate an alternative,
    // as the reference will be entered as a string either way, and thus functions with both
    // individual verses (e.g. John 3:16) and multiple (e.g. John 3:16-17).
    public VerseReference(string reference)
    {
        _verseReference = reference;
    }

    public void Display()
    {
        Console.WriteLine(_verseReference);
    }
}