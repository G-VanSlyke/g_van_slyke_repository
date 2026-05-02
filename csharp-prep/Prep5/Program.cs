using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            return Console.ReadLine();
        }
        
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            return int.Parse(Console.ReadLine());
        }

        static int PromptUserBirthYear()
        {
            Console.Write("What year were you born? ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int number, int birthYear)
        {
            int age = 2026 - birthYear;

            Console.WriteLine($"{name}, your favorite number squared is {number}.");
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }

        static void MainFunction()
        {
            DisplayWelcome();

            string name = PromptUserName();
            int number = PromptUserNumber();
            int birthYear = PromptUserBirthYear();
            int squareNumber = SquareNumber(number);

            DisplayResult(name, squareNumber, birthYear);
        }

        MainFunction();
    }
}