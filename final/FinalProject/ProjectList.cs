using System.IO.Enumeration;

class ProjectList
{
    List<Project> _projectList = [];

    public void AddProject(Project project)
    {
        _projectList.Add(project);
    }

    public void SaveToFile(string fileName, int index)
    {
        using (StreamWriter toSave = new StreamWriter(fileName))
        {
            toSave.Write(_projectList[index].GetCode());
        }
    }
    public List<Project> GetProjectList()
    {
        return _projectList;
    }
}