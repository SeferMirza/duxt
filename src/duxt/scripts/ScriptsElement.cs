using duxt.component;

namespace duxt.scripts;

public class ScriptsElement
{
    public readonly List<Script> Scripts;

    public ScriptsElement()
    {
        Scripts = [];
    }

    public void Add(Script script)
    {
        Scripts.Add(script);
    }

    public void Add(List<Script> scripts)
    {
        scripts.ForEach(s => Scripts.Add(s));
    }
}
