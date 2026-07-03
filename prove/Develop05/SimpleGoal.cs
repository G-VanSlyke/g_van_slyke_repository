class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points, bool completed) : base(title, description, points)
    {
       _completed = completed;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal~{_title}~{_description}~{_points}~{_completed}";
    }

    public override void Completed()
    {
        _completed = true;
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override void Display()
    {
        if (_completed)
        {
            Console.WriteLine($"[X] {_title} ({_description})");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description})");
        }

    }
    
}