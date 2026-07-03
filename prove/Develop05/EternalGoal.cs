class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {
        
    }

    public override string GetSaveString()
    {
        return $"EternalGoal~{_title}~{_description}~{_points}";
    }

    public override int GetPoints()
    {
        return _points;
    }
    public override void Completed()
    {
        
    }
}