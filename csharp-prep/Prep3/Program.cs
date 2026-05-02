using System;

class Program
{
    static void Main(string[] args)
    {
        static void Game()
        {
        string playAgain = "y";
        while (playAgain == "y")
            {
                Console.WriteLine("Welcome to the number guessing game!");
                Console.Write("What is the magic number? (1 - 20): ");
                int magicNumber = int.Parse(Console.ReadLine());
                int playerGuess = -1;
                int guessCount = 0;
                while (playerGuess != magicNumber)
                {
                    Console.Write("What is your guess? (1 - 20): ");
                    playerGuess = int.Parse(Console.ReadLine());

                    if (playerGuess > magicNumber)
                    {
                        Console.WriteLine("Not quite. Lower.");
                    }

                    if (playerGuess < magicNumber)
                    {
                        Console.WriteLine("Not quite. Higher.");
                    }

                    guessCount += 1;

                }

                if (guessCount == 1)
                {
                    Console.WriteLine("Congratulations! You got it in 1 guess!");
                }

                else
                {
                    Console.WriteLine($"Congratulations! You got it in {guessCount} guesses!");
                }

                Console.Write("Would you like to play again? (y/n): ");
                playAgain = Console.ReadLine();
            }
        }  
        Game();  
    }
}