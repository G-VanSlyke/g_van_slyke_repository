class ListingActivity : Activity
{
    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity")
    {
        
    }

    public void GeneratePrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("Who are people that you appreciate?");
        promptList.Add("What are personal strengths of yours?");
        promptList.Add("What are your dreams?");
        promptList.Add("How have you felt the Holy Ghost this month?");
        promptList.Add("What are you most grateful for?");
        Random ran = new Random();
        _prompt = promptList[ran.Next(promptList.Count())];
    }

    public void WhatItDo()
    {
        DisplayWelcomeMessage();
        Console.WriteLine("\n");
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(3, 250);
        Console.WriteLine("\b ");
        GeneratePrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {_prompt} --");
        Console.Write("You may begin in: ");
        CountDown(3);
        Console.WriteLine();
        DateTime timeOfCompletion = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < timeOfCompletion)
        {
            Console.Write(">");
            Console.ReadLine();
            
        }
        Console.WriteLine();
        Congratulation();
    }
}