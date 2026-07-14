class ChecklistGoal : Goal
{
    int _iterations;
    int _bonusPoints;
    int _threshold;

    public ChecklistGoal(string title, string description, int points, int iterations, int bonusPoints, int threshold) : base(title, description, points)
    {
        _iterations = iterations;
        _bonusPoints = bonusPoints;
        _threshold = threshold;
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal~{_title}~{_description}~{_points}~{_bonusPoints}~{_threshold}~{_iterations}";
    }

    public override int GetPoints()
    {
        if (_iterations == _threshold)
        {
            return _points + _bonusPoints;
        }
        else
        {
            return _points;
        }
    }

    public override void Completed()
    {
     _iterations += 1; 
    }

    public override void Display()
    {
        if (_iterations >= _threshold)
        {
            Console.WriteLine($"[X] {_title} ({_description}) -- Currently Completed: {_iterations}/{_threshold}");
        }
        else
        {
            Console.WriteLine($"[ ] {_title} ({_description}) -- {_iterations}/{_threshold}");
        }
    }
}