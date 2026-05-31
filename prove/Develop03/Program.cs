using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // A scripture is selected at random and its reference and content are put into the constructors for
        // VerseReference and Scripture.
        ScriptureSelection randomVerse = new ScriptureSelection();
        string[] scriptureSelection = randomVerse.RandomScripture();
        Scripture scripture = new Scripture(scriptureSelection[1]);
        VerseReference reference = new VerseReference(scriptureSelection[0]);
        // This counter is used to ensure the program does not try to blank out words when they are
        // all already blank.
        int removals = 0;
        // This variable will be used to check if the user entered "quit."
        string response = "";
        // When I was testing, letting it go until all words were blank and then pressing Enter
        // resulted in an error, so exception handling was employed.
        try
        {
            // Making sure there are still unhidden words left in the list and that the user has not entered
            // "Quit."
            while (removals <= scripture.GetVerseAsList().Count() && response.ToLower() != "quit")
            {
                
                Console.Clear();
                // Both VerseReference and Scripture have methods Display(), since their attributes are not
                // accesible and getters are evil, or so they say.
                reference.Display();
                scripture.Display();
                Console.WriteLine();
                Console.WriteLine("Press 'Enter' to continue or type 'quit' to end.");
                response = Console.ReadLine();
                // Trying to hide more words than are left could result in an error.
                int unhiddenWordCount = scripture.UnhiddenWords().Count();
                // The default is 3 at a time.
                if (unhiddenWordCount >= 3)
                {
                    scripture.HideWords();
                    scripture.HideWords();
                    scripture.HideWords();
                    removals += 2;
                }

                else if (unhiddenWordCount >= 2)
                {
                    scripture.HideWords();
                    scripture.HideWords();
                    removals += 1;
                }

                else if (unhiddenWordCount >= 1)
                {
                    scripture.HideWords();
                }
                // I originally had += 1, 2, 3 in each of the if statements respectively, but that
                // results in a never-ending program once there are 0 words left.
                removals += 1;
        }
        
        }
        catch(System.ArgumentOutOfRangeException)
        {
            
        }
            
        
    }
}