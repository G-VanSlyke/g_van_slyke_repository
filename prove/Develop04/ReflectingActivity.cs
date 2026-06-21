class ReflectingActivity : Activity
{
    public ReflectingActivity() : base("This activity gives you a chance to reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "ReflectingActivity")
    {
        
    }
    public void GeneratePrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("When have you not been sure how to proceed but things turned out alright in the end?");
        promptList.Add("When have you had help from someone you look up to?");
        promptList.Add("What is something that you have done that only you were able to?");
        promptList.Add("When was a time you reached out and it benefited you or someone else?");
        promptList.Add("Think of a trial you had last year.");
        Random ran = new Random();
        _prompt = promptList[ran.Next(promptList.Count())];
    }

    public void WhatItDo()
    {
        DisplayWelcomeMessage();
        Console.WriteLine("\n");
        GeneratePrompt();
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(3, 250);
        Console.Write("\b ");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompt} ---\n");
        Console.WriteLine("When you have something in mind, hit 'Enter.'");
        Console.ReadLine();
        Console.Clear();
        DateTime timeOfCompletion = DateTime.Now.AddSeconds(_duration);
        List<string> questions = new List<string>();
        questions.Add("How did you feel after it happened?");
        questions.Add("How has it helped you to become the person you are today?");
        questions.Add("If you could tell your past self going through that experience one thing, what would it be?");
        questions.Add("How could this experience apply to something you are going through now?");
        int index = 0;
        while (DateTime.Now < timeOfCompletion && index < 4)
        {
            Console.Write($"{questions[index]}  ");
            Animation(_duration / 4, 250);
            Console.WriteLine("\b ");
            index += 1;
        }
        Console.WriteLine("\n\n");
        Congratulation();


    }
}