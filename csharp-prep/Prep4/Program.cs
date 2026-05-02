using System;

class Program
{
    static void Main(string[] args)
    {
        int numToAdd = -1;
        List<int> numbers = new List<int>();

        while (numToAdd != 0)
        {
            Console.Write("What number would you like to add to the list? (0 to quit): ");
            numToAdd = int.Parse(Console.ReadLine());
            
            if (numToAdd != 0)
            {
                numbers.Add(numToAdd);
            }
        
        }

        int total = 0;
        int greatest = 0;

        foreach (int number in numbers)
        {
            if (number > greatest)
            {
                greatest = number;
            }

            total += number;
            
        }

        double average = total / numbers.Count;

        Console.WriteLine($"The total is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The greatest number is {greatest}");
    }
}
