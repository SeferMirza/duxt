namespace duxt.styles;

public class StylesElement
{
    public readonly List<(string styleName, Styles styles)> Styles;

    public StylesElement()
    {
        Styles = [];
    }

    public void Add(string styleName, Styles styles)
    {
        Styles.Add((styleName, styles));
    }

    public void Add(List<(string styleName, Styles styles)> styleList)
    {
        foreach(var style in styleList)
        {
            Styles.Add((style.styleName, style.styles));
        }
    }

    public string HtmlView()
    {
        var stylesHtmlView = Styles != default
            ? string.Join("\n", Styles.Select(style =>
                @$"{style.styleName} {{
                {style.styles.DisplayYDirection()}
            }}"))
            : string.Empty;

        return stylesHtmlView;
    }
}
