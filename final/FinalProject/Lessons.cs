using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Lessons
{
    string _name;
    int _progress = 0;

    public Lessons()
    {

    }

    public void SetProgress(int prog)
    {
        _progress = prog;
    }
    public void LoadProgress()
    {
        if (File.Exists("progress.txt"))
        {
            string[] file = File.ReadAllLines("progress.txt");
            _progress = int.Parse(file[1]);
        }
    }

    public void SaveProgress()
    {
        if (File.Exists("progress.txt"))
        {
            File.Delete("progress.txt");
        }
        DateTime dateTime = DateTime.Now;
        using (StreamWriter toSave = new StreamWriter("progress.txt"))
        {
            toSave.Write(dateTime.ToShortDateString() + $"\n{_progress}");
        }

        
    }

    public Project LessonSelect()
    {
        Console.Clear();
        int lessonChoice = 0;
        Console.WriteLine("Which lesson would you like to do?\n1\n2\n3\n4\n(5 to quit)");
        lessonChoice = int.Parse(Console.ReadLine());
        if (lessonChoice == 1)
        {
            return Lesson1();
        }
        if (lessonChoice == 2)
        {
            return Lesson2();
        }
        if (lessonChoice == 3)
        {
            return Lesson3();
        }
        if (lessonChoice == 4)
        {
            return Lesson4();
        }
        else
        {
            Project empty = new SimpleProject("", []);
            return empty;
        }
        
    }

    public int GetProgress()
    {
        return _progress;
    }
    public Project Lesson1()
    {
        Console.Clear();
        Console.Write("Welcome to your digital Python tutor! The objective of this program is to teach you the basics of programming through interactive activities that test what you have learned.\n\nWhat is your name? ");
        _name = Console.ReadLine();
        Console.Write("In addition to teaching, this program will also generate code compatible with the Python language. In order to run this code, however, you will need to download Python onto your device.\n\nAre you ready to begin? ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Without any further ado, we are ready to begin! The most basic principle of programming is input and output. This in particular is a specialty of Python: its ability to create interactive code that takes in and returns information.");
        Console.WriteLine("\nThe command used to display information to the user is 'print.' It's used as follows:");
        Console.WriteLine("\nInput: print('Hello World!')");
        Console.WriteLine("\nOutput: Hello World!");
        Console.Write("\nGive it a try: ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("So, now you know how to display text for the user to see, but how do you receive information from the user? This is done by using the 'input' command as follows:");
        Console.WriteLine("\nInput: input('Insert number: ')");
        Console.Write("Output: Insert number: ");
        string number = Console.ReadLine();
        Console.WriteLine($"\nNow the computer will remember '{number}' so we can make use of it later.");
        Console.Write("Ready to continue? ");
        Console.Read();
        Console.Clear();
        Console.WriteLine("A lot of the time, you will want to modify or use the variables that you enter in some way. Let's take a look at creating and modifying variables in Python.\n\nDefining a variable is quite simple. All you need to do is enter the name of your variable followed by an equals sign and the value you would like to set it to.");
        Console.WriteLine("For example:");
        Console.WriteLine("\nprice = 2.50");
        Console.WriteLine("item_name = 'bread'");
        Console.WriteLine("in_stock = 12");
        Console.WriteLine("Did you notice that our variable 'item_name' had quotes around the value? This has to do with the types of variables that exist in Python. There are three types that we will learn about now:");
        Console.WriteLine("1. Integer\n2. String\n3. Float");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("1. Integer:\nAn integer is a whole number.");
        Console.WriteLine("2. String:\nA string is a variable that contains text.");
        Console.WriteLine("3. Float:\nA float is a decimal number.");
        Console.WriteLine("\nClearly, all of these variable types have a different purpose, and sometimes we need to convert between them, but there are a few things to remember:\n1. In order to be transformed into a different type of variable, a value must be something that meets the criteria for the desired type. In other words, 2.5 can't be changed to an int, and 'Hello World!' Cannot be changed into a float or int.\n2. Certain operations can only be performed with specific variable types. For example 'num * 3,' where 'num' is an integer of value 3, results in 9, but if 'num' is a string, the result is 333, the combination of 3 identical strings. This is done as follows:");
        Console.WriteLine("\nTo convert to string:\nstr(variable)\n\nTo convert to integer:\nint(variable)\n\nTo convert to float:\nfloat(variable)");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Why don't we practice a bit?");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Let's make a simple program that takes the asks the user for a name and age and tells them how old they will be in five years.\nIt should work as follows:");
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("\nHow old are you? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nHello, {name}. In five years, you will be {age + 5} years old.");
        Console.WriteLine("\nGot it?");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Oh. One more thing before we begin: In order to print a variable for the user to see, you can use one of two methods.\n\nThe long method:\nprint('Hello,' + name + '. In five years, you will be' + str(age + 5) + 'years old.')");
        Console.WriteLine("It is much easier, however, using what's called a format string as follows:\nprint(f'Hello, {name}. In five years, you will be {age + 5} years old.')");
        Console.WriteLine("A format string is indicated by placing an 'f' before the quotes of what you want to print. For this reason, it is commonly referred to as an f string.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("When writing code, you can type it as you would if you were writing directly to a file, but after you submit a line, you can't go back. When you are done, type 'QUIT.'");
        Project lesson1 = new SimpleProject("Lesson 1", ["You can set a variable equal to a user input as follows: variable = input()", "Make sure you make the variable for age an integer. It's a string by default--int(input()).", "Don't forget the f string."]);
        lesson1.WriteCode();
        if (_progress < 1)
        {
            _progress = 1;
            SaveProgress();
        }
        return lesson1;
    }

    public Project Lesson2()
    {
        Console.Clear();
        if (_progress < 1)
        {
            Console.WriteLine("It doesn't look like you are ready for this lesson yet.");
            Project empty = new SimpleProject("", []);
            return empty;
        }
        else
        {
            Console.WriteLine("Congratulations on your mastery of lesson 1!\nIn this lesson, we will cover conditions. If you have prior experience with programming, you are probably familiar with what we call 'Boolean terms.' These are 'and', 'or', and 'not.' All of these exist in Python, and they are used to create conditions.");
            Console.WriteLine("\nExample:\nif bug and has_stripes:\nprint('It's a bumblebee.')");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In this example, 'bug' and 'has_stripes' are Boolean variables, meaning their value is either 'True' or 'False.' 'and' makes it so that if both variables equal true, the program will tell you that it's a bumblebee. Let's take a closer look at 'and', 'or', and 'not'.");
            Console.WriteLine("and:\nThe job of 'and' is to make sure that both conditions are true.\n\nor:\nThe job of 'or' is to make sure that one of the conditions is true.\n\nnot:\nThe job of 'not' is to make sure a condition is false.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("There are also other operators that aid in making comparisons. They are '==', '!=', '>=', '<=', '>', '<'. It looks like a lot, but it's easy to get the hang of.\n\nEqual vs. Not equal:\nIn comparisons, '==' is used to check if two values are equal while '!=' is used to make sure they are not equal.\n\nGreater than or equal to vs. Less than or equal to:\nAs one might expect, '>=' checks if a first value is greater than or equal to a second value. '<=' checks if a first value is less than or equal to a second value.\n\nGreater than vs. Less than.\nJust like in math, '<' means less than, and '>' means greater than. Remember, the alligator eats the bigger number.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now, for an example. Here is the code that will be demonstrated:\n\nnumber = int(input('Guess my favorite number: '))\nif number == 7:\n\tprint('You guessed it!')\nif number != 7:\n\tprint('Not quite')\nif number > 7:\n\tprint('Too high.')\nif number < 7:\n\tprint('Too low.')");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now, let's see how it works.");
            Console.Write("Guess my favorite number: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 7)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Not quite.");
            }
            if (number > 7)
            {
                Console.WriteLine("Too high.");
            }
            if (number < 7)
            {
                Console.WriteLine("Too low.");
            }
            Console.WriteLine("\nGot it?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now that you know how conditions work, what do you do when you have multiple? This is where 'else' and 'elif' come in.\nIf you had a series of if statements, the program would check all of them to see if they were true, but what if you only want them to get checked if the first condition was false? Here's an example:");
            Console.WriteLine("\nExample:\n\nif grade >= 90:\n\tprint('You get an A')\nelif grade >= 80:\n\tprint('You get a B')\nelif grade >= 70:\n\tprint('You get a C')");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In the example you just saw, the program first checks if the number 'grade' is 90 or higher, and if it is, the grade is an A. 'elif' is short for 'else if' and makes it so that the program only checks if the grade is a C or a B if it is not an A.\nSimilarly, 'else' is used to prescribe a course of action if none of the prior if statements are true.");
            Console.WriteLine("Now, for this lesson's project you will place numbers within a range. The user will provide a number from 0-100, and your program will determine in what range that number falls. The ranges will be '1-25', '26-50', '51-75', and '76-100'. It should work as follows:");
            Console.WriteLine("Select a number (1-100): ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 25)
            {
                Console.WriteLine("0-25");
            }
            else if (num <= 50)
            {
                Console.WriteLine("26-50");
            }
            else if (num <= 75)
            {
                Console.WriteLine("51-75");
            }
            else
            {
                Console.WriteLine("76-100");
            }
            Console.WriteLine("It's that simple. Ready to give it a try?\nThe way you write this program will be similar to the last. 'QUIT' to end and 'HINT' to receive a hint. In Python, the instructions of an if statement need to be indented. This will be taken care of automatically. To remove an indent, type 'EXIT'.");
            Console.ReadLine();
            Console.Clear();
            Project lesson2 = new ProjectWithIfStatement("Lesson 2", ["Make sure you convert the user input into an integer.", "If you forget to use 'elif' or 'else', your program will output multiple ranges. That said, if the first if statement is true, the rest should also be true.", "Since these ranges are inclusive, you are going to want to use '<=' or '>='."]);
            lesson2.WriteCode();
            if (_progress < 2)
            {
                _progress = 2;
                SaveProgress();
            }
            return lesson2;
        }
    }
    public Project Lesson3()
    {
        Console.Clear();
        if (_progress < 2)
        {
            Console.WriteLine("It doesn't look like you are ready for this lesson yet.");
            Project empty = new SimpleProject("", []);
            return empty;
        }
        else
        {
            Console.WriteLine("Congratulations! You are now halfway through the course! So far you have learned input and output and conditional statements.\nWhile these form a good basis, programs are often expected to run continuously rather than just once. This is achieved using loops. In this lesson, we will cover the use of a 'while' loop.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("To demonstrate this principle, let's take a look at our 'Say yes' program.\n\nHere is the code:\nresponse = ''\nwhile response.lower() != 'yes':\n\tresponse = input('Say yes.')\nNow, let's see how it works.\n\n");
            string response = "";
            while (response.ToLower() != "yes")
            {
                Console.WriteLine("Say yes.");
                response = Console.ReadLine();
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This program is quite simple. It keeps asking the user to say yes until they eventually do. This is done using a while loop. A 'while' loop is similar to an 'if' statement in the fact that it executes code based on a condition, but a 'while' loop continues until the condition becomes false.\nDid you notice the .lower()? This is a way of modifying a string so all of its letters become lowercase. This way, the capitalization the user chooses does not effect the output of the function. I use the same thing in this program.\nAlso, did you notice that the variable 'response' was defined before the loop? This is not the only way of doing it, but a program will crash if it is forced to evaluate a condition involving an undefined variable.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Something that you may want to include in a while loop is a counter. This is done by adding one to a variable every time a while loop runs. This is demonstrated in the following 'number guess program'.\n\n");
            int guess = 0;
            int numberOfGuesses = 0;
            while (guess != 7)
            {
                Console.Write("Guess my number (1-10): ");
                guess = int.Parse(Console.ReadLine());
                if (guess > 7)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                if (guess < 7)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                numberOfGuesses += 1;
            }
            Console.WriteLine($"Congratualations! You guessed it in {numberOfGuesses} guesses!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here's the code that makes it work:\n\nguess = 0\nguess_count = 0\nwhile guess != 7:\n\tguess = int(input('Guess my number (1-10): '))\n\tif guess > 7:\n\t\tprint('Too high. Try again.)\n\tif guess < 7:\n\t\tprint('Too low. Try again.)\n\tguess_count += 1\nprint(f'Congratulations! You guessed it in {guess_count} guesses!)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's that '+=' all about? 'variable += 1' is shorthand for 'variable = variable + 1'. In other words, the value of 'variable is increased by 1.");
            Console.WriteLine("Without any further ado, it looks like you are ready to do the project. For this project, you will make a number guessing program, similar to the one shown earlier in the lesson, but yours will have the user guess a number from 1-100, and after each guess, you will tell the user if they are above or below and if they are hot or cold. In addition, the program will count the number of guesses. Here's a demonstration:");
            int num = 0;
            int secretNum = 72;
            int guessCount = 0;
            while (num != secretNum)
            {
                Console.Write("\nGuess the number (1-100): ");
                num = int.Parse(Console.ReadLine());
                if (num > secretNum)
                {
                    Console.WriteLine("Too high.");
                    if (num - secretNum <= 20)
                    {
                        Console.WriteLine("Hot!");
                    }
                    else
                    {
                        Console.WriteLine("Cold.");
                    }
                }
                if (num < secretNum)
                {
                    Console.WriteLine("Too low.");
                    if (secretNum - num <= 20)
                    {
                        Console.WriteLine("Hot!");
                    }
                    else
                    {
                        Console.WriteLine("Cold.");
                    }
                }
                guessCount += 1;
            }
            Console.WriteLine($"Congratulations! You got it in {guessCount} guesses.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Now it's your turn. Earlier, we learned that an if statement has to be followed by a colon and an indent. The same is true for loops, but I'll take care of the indentation for you. To remove an indent, type 'EXIT'. For a hint, type 'HINT' and type 'QUIT' to end. Note that 'QUIT' only works if you are not indented.");
            Project lesson3 = new ProjectWithWhileLoop("Lesson 3", ["This project will require 'if' statements inside of loops. Remember, be careful with indentation.", "How do you tell how close a guess is? Subtraction works, but it requires you to know which number is bigger. If only you had a condition to tell which number is bigger (;", "You can choose any number to be the threshold for hot and cold. I chose 20.", "Make sure you initially define your 'guess_count' variable outside of the loop. I might be speaking from experience."]);
            lesson3.WriteCode();
            if (_progress < 3)
            {
                _progress = 3;
                SaveProgress();
            }
            return lesson3;
        }
    }

    public Project Lesson4()
    {
        Console.Clear();
        if (_progress < 3)
        {
            Console.WriteLine("It doesn't look like you are ready for this lesson yet.");
            Project empty = new SimpleProject("", []);
            return empty;
        }
        else
        {
            Console.WriteLine("Give yourself a pat on the back. You've made it to the last lesson. I want to thank you for coming this far. It means a lot to me. Our final lesson is on lists and for loops. We begin with lists.\nIn lesson 1, we learned about different types of values. Do you remember what they were?");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("If you said string, integer, and float, you are correct, but what if I told you there was more? What if you wanted to store multiple of a single data type? This is where lists come in handy. Lists are created in the following format:\n\n[\n\tvalue1, value2, value3\n]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("In the previous example, the list was on three different lines. This is not necessary, but it's considered better programming etiquette not having lines of code that extend super far horizontally for readability's sake (don't look at the source code for this program).\n\nNow, how do you access the information stored in a list? This is done using the index system. Each member of a list has an index. You can think of it as an address of sorts. The first element in a list is 0, the next is 1, etc.\n\nIf we take another look at the list we made...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("our_list = [\n\tvalue1, value2, value3\n]\n\nThe index of 'value1' is 0, that of 'value2' is 1, and that of 'value3' is 2. To get any particular member of the list, we just need the name of the list followed by the index in brackets, like so:\n\nour_list[0]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("To add to a list, we use the .append() command. The following program shows how this works.\n\nfriends = []\nfriend = ''\nwhile friend.lower() != quit:\n\tfriend = input('Who would you like to invite to your party ('QUIT' to exit)?')\n\tif friend.lower() != 'quit':\n\t\tfriends.append(friend)\nfor friend in friends:\n\tprint(friend)");
            Console.WriteLine("This program contains something you haven't learned yet. We'll get to that in just a bit, but let's see how this program runs.");
            Console.ReadLine();
            Console.Clear();
            List<string> friends = [];
            string friend = "";
            while (friend.ToLower() != "quit")
            {
                Console.Write("Who would you like to invite to your party ('QUIT' to exit)?");
                friend = Console.ReadLine();
                if (friend.ToLower() != "quit")
                {
                    friends.Add(friend);
                }
            }
            foreach (string person in friends)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The tool that was used to print the names of each person in the list is called a 'for' loop. More often than not, a for loop is used to iterate through the contents of a list. This helps us to print strings, but it can also be applied with other types of values. The following example shows a for loop being used to add together a list of numbers:");
            Console.WriteLine("\nnumber_list = []\nnumber = -1\nwhile number != 0:\n\tnumber = int(input('What number will you add (0 to quit)?'))\n\tnumber_list.append(number)\ntotal = 0\nfor number in numbers:\n\ttotal += number\nprint(total)\n\nNow, let's see how it works.");
            Console.ReadLine();
            Console.Clear();
            List<int> numberList = [];
            int number = -1;
            while (number != 0)
            {
                Console.Write("What number will you add (0 to quit)? ");
                number = int.Parse(Console.ReadLine());
                numberList.Add(number);
            }
            float total = 0;
            foreach (int entry in numberList)
            {
                total += entry;
            }
            Console.WriteLine(total);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("While it has been great, it appears our journey is nearing its end, as you are now prepared to take on the final project. Your code will be similar to that you just saw, but your program will need to compute the average of a list of numbers. Remember, the average is the total divided by how many numbers there are. When your project is done, it should work like this:");
            numberList = [];
            number = -1;
            while (number != 0)
            {
                Console.Write("What number will you add (0 to quit)? ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    numberList.Add(number);
                }
            }
            total = 0;
            int entries = 0;
            foreach (int entry in numberList)
            {
                total += entry;
                entries += 1;
            }
            Console.WriteLine($"The average is {total/entries}");
            Console.WriteLine("Well, off you go!");
            Console.ReadLine();
            Console.Clear();
            Project lesson4 = new LoopsAndListsProject("Lesson 4", ["You are going to need to implement a counter into the 'for' loop (count += 1). Just make sure you define count outside of the 'for' loop.", "The name of the first variable that follows 'for' doesn't matter. It just acts as your variable within the loop, representing each member of the list.", "Make sure '0' doesn't get added to the list. That will mess with your final answer."]);
            lesson4.WriteCode();
            _progress = 4;
            SaveProgress();
            return lesson4;
        }
    }
}