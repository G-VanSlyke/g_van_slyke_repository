using System;
using System.Security.Cryptography.X509Certificates;

class Program
// This program uses exception handling to prevent a crash in case a file name entry is invalid.

// Exception handling is also used to make sure the program does not crash if the user enters
// anything other than an integer.

// Likewise, it tells the user if he/she tries to save or display something when there is no information stored.
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int userSelection = 0;
        while (userSelection != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new journal entry");
            Console.WriteLine("2. View current journal entry");
            Console.WriteLine("3. Save current entry to file");
            Console.WriteLine("4. Load past journal entry from file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter number (1-5): ");
            
            try
            {
                userSelection = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {}
            // Add entry
            if (userSelection == 1)
            {
                Console.WriteLine();
                journal.AddEntry();
                Console.WriteLine();
            }
            // Display Current Entry
            else if (userSelection == 2)
            {
                Console.WriteLine();
                journal.DisplayEntries();
                Console.WriteLine();
            }
            // Save Entry
            else if (userSelection == 3)
            {
                Console.WriteLine();
                journal.Save();
                Console.WriteLine();
            }
            // Load Past Entry
            else if (userSelection == 4)
            {
                Console.WriteLine();
                journal.Load();
                Console.WriteLine();
            }
            // Quit
            else if (userSelection == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Farewell!");
                Console.WriteLine();
            }
            // In case user inputs a number other than 1-5
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Try again.");
                Console.WriteLine();
            }
        }
    }
}