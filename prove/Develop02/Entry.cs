using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    // Attributes
    public string _date;
    public string _prompt;
    public string _response;
    public List<string> _newEntry;

    // Methods
    //Display(): gives the user a prompt and sets the value of _newEntry to a list containing date, prompt and response.
    public void Display()
    {
        _date = GetDate();
        _prompt = PromptGen();
        Console.Write($"{_date}\n{_prompt}\n>");
        _response = Console.ReadLine();

        List<string> entry = new List<string>();
        entry.Add(_date);
        entry.Add(_prompt);
        entry.Add(_response);
        _newEntry = entry;
        

    }
        // One of 7 prompts is selected at random using a number from 0 to the length of the list
        // as an index to call a certain prompt.
        public string PromptGen()
    {
        List<string> prompts = new List<string>();
        prompts.Add("What are you most grateful for today?");
        prompts.Add("What of what happened today are you most likely to remember next year?");
        prompts.Add("What challenges were you able to overcome today?");
        prompts.Add("What are you most proud of today?");
        prompts.Add("Were you able to do anything today that you couldn't do yesterday, last week or last month?");
        prompts.Add("If you had one wish, what would it be?");
        prompts.Add("What's one thing you would rather had gone differently?");

        Random rnd = new Random();
        int randomNumber = rnd.Next(0, prompts.Count());
        return prompts[randomNumber];
    }
    // Gets the current date and returns it as a string.
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        return theCurrentTime.ToShortDateString();
    }
}