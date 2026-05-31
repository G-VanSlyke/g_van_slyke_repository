using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Scripture
{
    private string[] _scripture;
    // Constructor 1. Designed to convert a string into an easier-to-work-with array.
    public Scripture(string verse)
    {
        _scripture = verse.Split(" ");
    }
    // Allows the Scripture class to be constructed using an array of strings.
    public Scripture(string[] verse)
    {
        _scripture = verse;
    }
    // Converts string[] to string. Important for displaying scriptures that are stored in arrays.
    public string VerseAsString()
    {
        string verse = "";
        foreach (string word in _scripture)
        {
            verse += word + " ";
        }
        return verse;
    }
    // Returns _scripture
    public string[] GetVerseAsList()
    {
        return _scripture;
    }
    public void HideWords()
    {
        // Generates a list of the indexes of letters that have not been hidden.
        List<int> unhiddenWords = UnhiddenWords();
        // An entry in the list of indexes is chosen at random.
        Random random = new Random();
        int rand = random.Next(0, unhiddenWords.Count());
        // The random index is entered into _scripture, randomly selecting a word that hasn't been hidden.
        WordState toHide = new WordState(_scripture[unhiddenWords[rand]]);
        // Selected word is hidden using the word class.
        toHide.ChangeState();

        _scripture[unhiddenWords[rand]] = toHide.GetWord();
    }
    
    public void Display()
    {
        Console.WriteLine(VerseAsString());
    }
    // This is the method that generates a list of the indexes that pertain to unhidden words.
    // It was originally contained within another method, but it became needed elsewhere in the program,
    // so I made it a method.
    public List<int> UnhiddenWords()
    {
        List<int> unhiddenWords = [];
        for (int i = 0; i < _scripture.Count(); i ++)
        {
            if (! _scripture[i].Contains("_"))
            {
                unhiddenWords.Add(i);
            }
        }
        return unhiddenWords;
    }
}