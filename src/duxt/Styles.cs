namespace duxt;

public class Styles
{
    private List<(string, string)> _css = [];
    private string _alignItems = "left";
    private string _backgroundColor = "#000000";
    private string _color = "#FFFFFF";
    private string _justifyContent = "left";
    private string _textAlign = "left";

    public string AlignItems
    {
        get { return _alignItems; }
        set {
            _css.Add(("align-items", value));
            _alignItems = value;
        }
    }
    public string BackgroundColor
    {
        get { return _backgroundColor; }
        set {
            _css.Add(("background-color", value));
            _backgroundColor = value;
        }
    }
    public string Color
    {
        get { return _color; }
        set {
            _css.Add(("color", value));
            _color = value;
        }
    }
    public string JustifyContent
    {
        get { return _justifyContent; }
        set {
            _css.Add(("justify-content", value));
            _justifyContent = value;
        }
    }
    public string TextAlign
    {
        get { return _textAlign; }
        set {
            _css.Add(("text-align", value));
            _textAlign = value;
        }
    }

    public string DisplayYDirection() => Display("\n");

    public string DisplayXDirection() => Display(" ");

    private string Display(string separator)
    {
        var cssDisplay = _css.Select(css => $"{css.Item1}: {css.Item2};");
        return $"{string.Join(separator, cssDisplay)}";
    }
}
