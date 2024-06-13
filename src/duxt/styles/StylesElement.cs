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
        Styles.AddRange(styleList);
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
