using System.Reflection;
using System.Xml.Linq;

abstract class Project
{
    protected string _code;
    protected string _title;
    protected bool _completed;
    protected List<string> _hints;

    public Project(string title, List<string> hints)
    {
        _title = title;
        _hints = hints;
        _completed = false;
    }

    public void GetHint()
    {
        if (_hints.Count() > 0)
        {
            for (int i = 0; i + 1 <= _hints.Count(); i ++)
            {
                Console.WriteLine(_hints[i]);
            }
        
        }
    }
    public bool CheckIfEmpty()
    {
        if (_hints.Count() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Save()
    {
        _completed = true;
    }

    public string GetCode()
    {
        return _code;
    }
    

    public abstract void WriteCode();
    
    protected abstract void ProjectCheck();

}