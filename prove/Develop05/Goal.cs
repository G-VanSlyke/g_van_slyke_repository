using System.Reflection;
using System.Runtime.CompilerServices;

abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    public abstract string GetSaveString();
    public abstract int GetPoints();
    public virtual void Display()
    {
        Console.WriteLine($"[ ] {_title} ({_description})");
    }

    public abstract void Completed();
    
}