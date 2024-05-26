namespace duxt;

public class HtmlPage
{
    public string Build(Func<Builder, string> tool) => tool(new());
}