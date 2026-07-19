class SimpleProject : Project
{
    public override void WriteCode()
    {
        while (! _completed)
        {
            _code = $"# {_title}\n";
            string line = "";
            while (line.ToLower() != "quit")
            {
                Console.Write(_code);
                line = Console.ReadLine();
                if (line.ToLower() != "quit" & line.ToLower() != "hint")
                {
                    _code += line + "\n";
                    Console.Clear();
                    
                }
                if (line.ToLower() == "hint")
                {
                    Console.Clear();
                    GetHint();
                    Console.ReadLine();
                    Console.Clear();
                }
                

            }
            ProjectCheck();
        }
    }
    protected override void ProjectCheck()
    {
        if (_code.Contains("print(") & _code.Contains("input(") & (_code.Contains("+ 5") || _code.Contains("+5")))
        {
            Console.WriteLine("It looks like you have all the basics. Why don't you compare to the sample solution?");
            Console.WriteLine($"Your code:\n{_code}");
            Console.WriteLine("Sample code:\nname = input('What is your name?')\nage = input('How old are you?')\nprint(f'Hello, {name}. In five years, you will be {age + 5} years old.)");
            string answer = "";
            while (answer.ToLower() != "y" & answer.ToLower() != "n")
            {
                Console.Write("Does your code have all the essential elements included in the sample? (Y/N)");
                answer = Console.ReadLine();
            }
            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Congratulations! You've completed lesson 1!");
                _completed = true;
            }
            else
            {
                Console.WriteLine("Why don't you give it another try?");
                
            }
            
        }
        if (! _code.Contains("input("))
        {
            Console.WriteLine("It looks like your missing a way to get a variable from the user.");
        }
        if (! _code.Contains("print("))
        {
            Console.WriteLine("It doesn't look like you have a way of displaying to the user.");
        }
        if (! _code.Contains("+ 5") & ! _code.Contains("+5"))
        {
            Console.WriteLine("It looks like you're missing a way to add to the 'age' variable");
        }
        Console.ReadLine();
        Console.Clear();
    }
    public SimpleProject(string title, List<string> list) : base(title, list)
    {
        
    }

}