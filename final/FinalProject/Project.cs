using System.Reflection;
using System.Xml.Linq;

abstract class Project
{
    string _code;
    string _title;
    bool _completed;

    public Project(string title)
    {
        _title = title;
        _completed = false;
    }

    public void Save()
    {
        _completed = true;
    }

    public string GetCodeInfo()
    {
        return $"_title, _code";
    }

    public abstract string WriteCode();
    
    protected abstract void ProjectCheck();

}