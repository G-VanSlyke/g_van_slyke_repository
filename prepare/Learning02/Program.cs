using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public class Job
    {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;


       public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }

    }

    public class Resume
    {
        public string _name;
        public List<string> _jobList = new List<string>();

        public void Display()
        {
            Console.WriteLine(_name);
            foreach(string occupation in _jobList)
            {
                Console.WriteLine(occupation);
            }
        }

    }

    static void Main(string[] args)
    {
       Job newJob = new Job();
       newJob._company = "Intel";
       newJob._jobTitle = "HR";
       newJob._startYear = 2009;
       newJob._endYear = 2017;

       newJob.Display();

       Resume newResume = new Resume();
       newResume._jobList.Add("Built Bar Taste Tester");
       newResume._jobList.Add("Dog Groomer");
       newResume._jobList.Add("Street Fighter Player");
       newResume._name = "Guince Varaldi";

       newResume.Display();
    }
}