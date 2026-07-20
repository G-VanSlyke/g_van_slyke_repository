using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Lessons lessons = new Lessons();
        lessons.LoadProgress();
        ProjectList projectList = new ProjectList();
        int response = 0;
        while (response != 4)
        {
            try
            {
                Console.WriteLine("What would you like to do?\n1. Begin Lesson\n2. View Projects\n3. Save Project to File\n4. Quit");
                response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Project assignment = lessons.LessonSelect();
                    if (assignment.CheckIfEmpty())
                    {
                        projectList.AddProject(assignment);
                    }
                }
                if (response == 2)
                {
                    Console.Clear();
                    try
                    {
                        foreach (Project project in projectList.GetProjectList())
                        {
                            Console.WriteLine(project.GetCode());
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        Console.WriteLine("It doesn't look like you have any projects yet.");
                    }
                }
                if (response == 3)
                {
                    Console.Clear();
                    try
                    {
                        int selection = 0;
                        for (int i = 0; i < projectList.GetProjectList().Count(); i ++)
                        {
                            Console.WriteLine(i + 1 + ".");
                            Console.WriteLine(projectList.GetProjectList()[i].GetCode());
                            Console.Write("\nWhich project would you like to save to a file (number)? ");
                            selection = int.Parse(Console.ReadLine());
                            string fileName = "";
                            Console.Write("Enter file name to save to: ");
                            fileName = Console.ReadLine();
                            projectList.SaveToFile(fileName, selection - 1);
                        }
                    }
                    catch (System.ArgumentNullException)
                    {
                        Console.WriteLine("It doesn't look like you have any projects yet.");
                    }
                }
                if (response != 4)
                {
                    Console.ReadLine();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Goodbye for now!");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Entry must be an integer.");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    
        }
}