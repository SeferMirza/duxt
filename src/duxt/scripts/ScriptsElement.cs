using duxt.component;

namespace duxt.scripts;

public class ScriptsElement
{
    public readonly List<Script> Scripts;

    public ScriptsElement()
    {
        Scripts = [];
    }

    public void Add(string filePath)
    {
        Scripts.Add(new(filePath));
    }

    public void Add(List<string> filePaths)
    {
        filePaths.ForEach(f => Scripts.Add(new(f)));
    }
}
