using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class GoalList
{
    public List<Goal> _list = [];
    int _totalPoints = 0;

    public void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("What type of goal would you like to set?\n1. Simple goal\n2. Eternal goal\n3. Checklist goal");
        Console.Write("Insert number here > ");
        string goalType = Console.ReadLine();
        Console.Clear();
        
        if (goalType == "1")
        {
            Console.WriteLine("Insert title for goal:");
            string title = Console.ReadLine();
            Console.WriteLine("\nInsert goal description:");
            string description = Console.ReadLine();
            Console.WriteLine("\nInsert point value for goal:");
            int points = int.Parse(Console.ReadLine());
            
            Goal newGoal = new SimpleGoal(title, description, points, false);
            _list.Add(newGoal);
            Console.WriteLine("\nGoal successfully added.");
        }

        else if (goalType == "2")
        {
            Console.WriteLine("Insert title for goal:");
            string title = Console.ReadLine();
            Console.WriteLine("\nInsert goal description:");
            string description = Console.ReadLine();
            Console.WriteLine("\nInsert point value for goal:");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = new EternalGoal(title, description, points);
            _list.Add(newGoal);
            Console.WriteLine("\nGoal successfully added.");
        }

        else if (goalType == "3")
        {
            Console.WriteLine("Insert title for goal:");
            string title = Console.ReadLine();
            Console.WriteLine("\nInsert goal description:");
            string description = Console.ReadLine();
            Console.WriteLine("\nInsert point value for goal:");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsert number of times you want to complete the goal:");
            int threshold = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInsert bonus points for completing the goal the desired amount of times:");
            int bonusPoints = int.Parse(Console.ReadLine());
            Console.WriteLine("\nGoal successfully added.");

            Goal newGoal = new ChecklistGoal(title, description, points, 0, bonusPoints, threshold);
            _list.Add(newGoal);
        }

        else
        {
            Console.WriteLine("Invalid option. Try again.");
        }    
    }

    public void LoadGoals()
    {
        Console.Clear();
        int goalNumber = 1;
        Console.WriteLine($"Point total: {_totalPoints}");
        foreach (Goal goal in _list)
        {
            Console.Write($"{goalNumber}. ");
            goal.Display();
            goalNumber += 1;
        }
    }

    public void CompleteGoal()
    {
        Console.Clear();
        LoadGoals();
        Console.WriteLine("\nWhich goal have you completed (insert number)?");
        int goalSelection = int.Parse(Console.ReadLine());
        _list[goalSelection - 1].Completed();
        _totalPoints += _list[goalSelection - 1].GetPoints();
        Console.WriteLine($"Congratulations! You earned {_list[goalSelection - 1].GetPoints()} points!");
    }

    public void Save()
    {
        Console.WriteLine("What file would you like to save to?");
        string fileName = Console.ReadLine();
        using(StreamWriter savedGoals = new StreamWriter(fileName))
                {
                    string stringToSave = "";
                    foreach (Goal goal in _list)
                    {
                        stringToSave += goal.GetSaveString() + "\n";
                    }
                    savedGoals.Write(stringToSave);
                }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter the name of the file you would like to load from:");
        string fileName = Console.ReadLine();
        string[] goalsToLoad = File.ReadAllLines(fileName);
        foreach (string entry in goalsToLoad)
        {
            string[] elements = entry.Split("~");
            if (elements[0] == "SimpleGoal")
            {
                Goal newGoal = new SimpleGoal(elements[1], elements[2], int.Parse(elements[3]), bool.Parse(elements[4]));
                _list.Add(newGoal);
            }
            else if (elements[0] == "EternalGoal")
                {
                    Goal newGoal = new EternalGoal(elements[1], elements[2], int.Parse(elements[3]));
                    _list.Add(newGoal);
                }
            else if (elements[0] == "ChecklistGoal")
            {
                Goal newGoal = new ChecklistGoal(elements[1], elements[2], int.Parse(elements[3]), int.Parse(elements[5]), int.Parse(elements[4]), int.Parse(elements[6]));
                _list.Add(newGoal);
            }
            Console.WriteLine("\nGoal loading complete");
        }
    }
}