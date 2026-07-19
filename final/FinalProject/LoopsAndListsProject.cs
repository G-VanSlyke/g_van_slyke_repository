using System.Reflection;

class LoopsAndListsProject : Project
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
                }
            }
            ProjectCheck();
        }
    }
    protected override void ProjectCheck()
    {
        if (_code.Contains("while") & _code.Contains("for") & _code.Contains(".append(") & _code.Contains("/"))
        {
            Console.WriteLine("It looks like you have all the basics. Why don't you compare to the sample solution?");
            Console.WriteLine($"\nYour code:\n{_code}" + "\n\nSample code:\nnumber_list = []\nnumber = -1\nwhile number != 0:\n\tnumber = int(input('What number will you add (0 to quit)?'))\n\tif number != 0:\n\t\tnumber_list.append(number)\ntotal = 0\ncount = 0\nfor number in numbers:\n\ttotal += number\n\tcount += 1\nprint(f'The average is {total/count}.)");
            string answer = "";
            while (answer.ToLower() != "y" & answer.ToLower() != "n")
            {
                Console.Write("Does your code have all the essential elements found in the sample?(Y/N) ");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Congratulations! You've completed the final lesson!");
                    _completed = true;
                }
                if (answer.ToLower() == "n")
                {
                    Console.WriteLine("Why don't we try again?");
                }
            }
        }
        if (! _code.Contains("while"))
        {
            Console.WriteLine("It looks like you're missing a 'while' loop");
        }
        if (! _code.Contains("for"))
        {
            Console.WriteLine("It looks like you're missing a 'for' loop.");
        }
        if (! _code.Contains(".append("))
        {
            Console.WriteLine("It looks like you're missing a way to append to your list (list.append()).");
        }
        if (! _code.Contains("/"))
        {
            Console.WriteLine("It looks like you're missing a way to calculate the average (average = total/count).");
        }
        Console.ReadLine();
        Console.Clear();
    }
    public LoopsAndListsProject(string title, List<string> hints) : base(title, hints)
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