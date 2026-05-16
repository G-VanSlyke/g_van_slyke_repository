using System.Security.Cryptography.X509Certificates;
using System.IO;
class Journal
{
    //Attributes
    public List<List<string>> _entries = new List<List<string>>();
    
    // Uses Entry.Display() and adds information (date, prompt and response) to Journal._entries.
    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Display();
        _entries.Add(entry._newEntry);
        
    }
    // Displays the information that has been appended to Journal._entries, but only if the list isn't
    // empty.
    public void DisplayEntries()
    {
        if (_entries.Count() == 0)
        {
            Console.WriteLine("No entry to display.");
        }
        else
        { 
            for (int i = 0; i < _entries.Count(); i++)
            {
                Console.WriteLine($"Date: {_entries[i][0]}");
                Console.WriteLine($"Prompt: {_entries[i][1]}");
                Console.WriteLine(_entries[i][2]);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~");
            
            }
            
        }   
    }
    // Saves appended information in Journal._entries to a file of the user's choosing.
    // Makes sure there is information to save and that file name entered is valid.
    // Formatted as a csv file separated by "~"
    public void Save()
    {
        if (_entries.Count() == 0)
        {
            Console.WriteLine("No entry to save.");
        }
        else
        {
            try
            {
                Console.Write("Enter name of file to save to: ");
                string fileName = Console.ReadLine();
                using(StreamWriter savedJournal = new StreamWriter(fileName))
                {
                    for (int i = 0; i < _entries.Count(); i++)
                    {
                        foreach (string element in _entries[i])
                        {
                            savedJournal.Write($"{element}~");
                        }
                        savedJournal.Write("\r\n");
                    }
                }
                _entries = [];
                Console.WriteLine("Journal entry successfully saved.");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid file name. Could not save");
            }
        }
    }
    // Loads a file, displaying the info from the csv in a more attractive format.
    // Makes sure the desired file exists.
    public void Load()
    {
        try
        {
        Console.Write("Enter name of file to load: ");
        string[] lines = File.ReadAllLines(Console.ReadLine());
        foreach (string line in lines)
        {
            string[] accounts = line.Split("\r\n");
            foreach (string account in accounts)
                {
                    string[] elementsDivided = account.Split("~");
                    Console.WriteLine($"Date: {elementsDivided[0]}");
                    Console.WriteLine($"Prompt: {elementsDivided[1]}");
                    Console.WriteLine(elementsDivided[2]);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~");
                }
        }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File does not exist.");
        }
    }
    

}