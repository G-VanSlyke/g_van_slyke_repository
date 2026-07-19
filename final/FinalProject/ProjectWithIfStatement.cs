using System.Runtime.CompilerServices;

class ProjectWithIfStatement : Project
{
    public override void WriteCode()
    {
        while (! _completed)
        {
            _code = $"# {_title}\n";
            string line = "";
            int layer = 0;
            while (line.ToLower() != "quit")
            {
                Console.Write(_code);
                line = Console.ReadLine();
                if (line.ToLower() != "quit" & line.ToLower() != "hint")
                {
                    _code += line + "\n";
                    Console.Clear();
                }
                if (char.ToString(line[^1]) == ":")
                {
                    _code += "\t";
                    Indent(layer + 1);
                }
                if (line.ToLower() == "hint")
                {
                    Console.Clear();
                    GetHint();
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write(_code);
                }
            }
            ProjectCheck();
        }
    }
    protected override void ProjectCheck()
    {
        if (_code.Contains("if") & (_code.Contains("elif") || _code.Contains("else")) & (_code.Contains("<=") || _code.Contains(">=")))
        {
            Console.WriteLine("It looks like you have all the basics. Why don't you compare to the sample solution?");
            Console.WriteLine($"\nYour code:\n{_code}\n\nSample code:\nnum = int(input('Select a number (1-100): '))\nif num <= 25:\n\tprint('0-25')\nelif num <= 50:\n\tprint('26-50')\nelif num <= 75:\n\tprint('51-75')\nelse:\n\tprint('76-100')");
            string answer = "";
            while (answer.ToLower() != "y" & answer.ToLower() != "n")
            {
                Console.Write("Does your code have all the essential elements found in the sample?(Y/N) ");
                answer = Console.ReadLine();
            }
            if (answer.ToLower() == "y")
            {
               Console.WriteLine("Congratulations! You've completed lesson 2!");
                _completed = true;
            }
            else
            {
                Console.WriteLine("Why don't you give it another try?");
                
            }
        }
        if (! _code.Contains("if"))
        {
            Console.WriteLine("It looks like you're missing if statements.");
        }
        if (! _code.Contains("elif") & ! _code.Contains("else"))
        {
            Console.WriteLine("It looks like you are missing 'else'/'elif' statements.");
        }
        if (! _code.Contains("<=") & ! _code.Contains(">="))
        {
            Console.WriteLine("It looks like you're missing comparison operators (<=/>=).");
        }
        Console.ReadLine();
        Console.Clear();
    }
    public ProjectWithIfStatement(string title, List<string> hints) : base(title, hints)
    {
        
    }

    public void Indent(int tabs)
    {
        string line = "";
        while (line.ToLower() != "exit" & line.ToLower() != "quit")
        {
            Console.Write(_code);
            line = Console.ReadLine();
            if (line.ToLower() != "exit" & line.ToLower() != "hint" & line.ToLower() != "quit")
            {
                _code += line + "\n";
                for (int i = 0; i < tabs; i++)
                {
                    _code += "\t";
                }
                Console.Clear();
            }
            if (char.ToString(line[^1]) == ":")
            {
                _code += "\t";
                Indent(tabs + 1);
            }
            if (line.ToLower() == "hint")
            {
                Console.Clear();
                GetHint();
                Console.ReadLine();
                Console.Clear();
                Console.Write(_code);
            }
            if (line.ToLower() == "exit")
            {
                _code += "\b\b\b\b\b\b\b\b";
            }
            Console.Clear();
        }
    }
}