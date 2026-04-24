using System;

class Program
{
    static void Main(string[] args)
    {
      
      Console.WriteLine("What is your grade (percentage)?");
      string testScore = Console.ReadLine();  
      float testScoreAsNumber = float.Parse(testScore);
      string letterGrade = "";
      if (testScoreAsNumber >= 90)
        {
            letterGrade = "A";
        }

      else if (testScoreAsNumber >= 80)
        {
            letterGrade = "B";
        }

      else if (testScoreAsNumber >= 70)
        {
            letterGrade = "C";
        }

      else if (testScoreAsNumber >= 60)
        {
            letterGrade = "D";
        }

      else
        {
            letterGrade = "F";
        }

        string gradeSign = "";
        if (testScoreAsNumber % 10 >= 7 && (letterGrade != "A" && letterGrade != "F"))
        {
            gradeSign = "+";
        }
        else if (testScoreAsNumber % 10 < 3 && letterGrade != "F")
        {
            gradeSign = "-";
        }

        Console.WriteLine($"Your grade is {letterGrade}{gradeSign}.");


      if (testScoreAsNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");

        }
      else
        {
            Console.WriteLine("I'm sorry, but you did not pass the class, but you'll get it next time!");
        }
    }
}