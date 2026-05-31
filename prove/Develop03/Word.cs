class WordState
{
    private string _word;
    // The constructor used by the Scripture class to basically send the word over.
    public WordState(string word)
    {
        _word = word;
    }
    // Transforms any word to a series of "_" of equal length and updates _word.
    public void ChangeState()
    {
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i ++)
        {
            hiddenWord += "_";
        }
        _word = hiddenWord;
    }
    // The method used to send the word back to Scripture after it has been hidden.
    public string GetWord()
    {
        return _word;
    }
}