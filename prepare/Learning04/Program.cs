using System;
using System.Dynamic;
class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"Student name: {_studentName}. Topic: {_topic}.";
    }
}
class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} problems {_problems}";
    }
}
class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetName()}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        
    }
}