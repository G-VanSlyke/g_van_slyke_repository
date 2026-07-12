using System.IO.Enumeration;

class ProjectList
{
    List<Project> _projectList;

    public void AddProject(Project project)
    {
        _projectList.Add(project);
    }

    public void SaveToFile(string fileName, Project project)
    {
        using (StreamWriter toSave = new StreamWriter(fileName))
        {
            
        }
    }
}