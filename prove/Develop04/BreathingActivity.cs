class BreathingActivity : Activity
{
    public BreathingActivity() : base("To help you relax, you will be given prompts of when to inhale and exhale. \n\n", "Breathing Activity")
    {
        
    }
    
    public void WhatItDo()
    {
        DisplayWelcomeMessage();
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Animation(3, 250);
        Console.Write("\b ");
        DateTime timeOfCompletion = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now <= timeOfCompletion)
        {
            Console.Write("\n\nInhale...");
            CountDown(4);
            Console.Write("\nExhale...");
            CountDown(6);
        }
        Console.WriteLine("\n");
        Congratulation();

    }

}