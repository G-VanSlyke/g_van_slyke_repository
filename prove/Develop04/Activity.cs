using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    protected int _duration;
    protected string _description;
    protected string _name;
    protected string _prompt;

    public Activity(string description, string name)
    {
        _description = description;
        _name = name;
        
    }

    public void SetTime()
    {
        Console.Write("Enter desired duration of exercise in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.Write(_description);

    }

    public void Animation(int iterations, int speed)
    {
        Console.Write("/");
        for (int i = 0; i < iterations; i ++)
        {
            Thread.Sleep(speed);
            Console.Write($"\b-");
            Thread.Sleep(speed);
            Console.Write($"\b" + @"\");
            Thread.Sleep(speed);
            Console.Write($"\b|");
            Thread.Sleep(speed);
            Console.Write($"\b/");
        }
    }

    public void CountDown(int startingNumber)
    {  
        Console.Write(startingNumber);
        Thread.Sleep(1000);
        for (int i = startingNumber - 1; i > 0; i --)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Console.Write($"\b ");

    }

    public void Congratulation()
    {
        Console.WriteLine("Well Done!");
        Animation(3, 250);
        Console.WriteLine("\b ");
        Console.WriteLine($"You completed {_duration} seconds of {_name}!");
        Thread.Sleep(5000);
        Console.Clear();
    }
    
}