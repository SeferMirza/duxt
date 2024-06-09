namespace duxt;

public sealed class Builder
{
    private static readonly HtmlPage page = new();

    public static HtmlPage CreateHtml() => page;
}
