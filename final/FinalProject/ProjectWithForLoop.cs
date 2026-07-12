using System.Reflection;

class ProjectWithForLoop : Project
{
    public override string WriteCode()
    {
        throw new NotImplementedException();
    }
    protected override void ProjectCheck()
    {
        throw new NotImplementedException();
    }
    public ProjectWithForLoop(string title) : base(title)
    {
        
    }
}