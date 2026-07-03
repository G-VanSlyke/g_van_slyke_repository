using System;

class Program
{
    static void Main(string[] args)
    {
        GoalList goalList = new GoalList();
        int selection = 0;
        while (selection != 6)
        {
            Console.WriteLine("Select an option:\n1. Create goal\n2. Load goals\n3. Complete goal\n4. Save goals to file\n5. Load goals from file\n6. Quit");
            Console.Write("(1-5) > ");
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                goalList.AddGoal();
                Console.ReadLine();
                Console.Clear();
            }
            else if (selection == 2)
            {
                goalList.LoadGoals();
                Console.ReadLine();
                Console.Clear();
            }
            else if (selection == 3)
            {
                goalList.CompleteGoal();
                Console.ReadLine();
                Console.Clear();
            }
            else if (selection == 4)
            {
                goalList.Save();
                Console.ReadLine();
                Console.Clear();
            }
            else if (selection == 5)
            {
                goalList.LoadFromFile();
                Console.ReadLine();
                Console.Clear();
            }
            else if (selection == 6)
            {
                Console.WriteLine("See you next time!");
            }
            else
            {
                Console.WriteLine("Invalid response. Try again.");
                Console.ReadLine();
                Console.Clear();
            }
        }     
    }
}