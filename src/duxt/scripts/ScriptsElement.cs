namespace duxt.scripts;

public class ScriptsElement
{
    public readonly List<string> Scripts;

    public ScriptsElement()
    {
        Scripts = [];
    }

    public void Add(string filePath)
    {
        Scripts.Add(filePath);
    }

    public void Add(List<string> filePaths)
    {
        Scripts.AddRange(filePaths);
    }

    public string HtmlView()
    {
        var stylesHtmlView = string.Join("\n", Scripts.Select(script =>
                $"<script src=\"{script}\"></script>"));

        return stylesHtmlView;
    }
}
