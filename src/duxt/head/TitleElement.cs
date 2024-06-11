namespace duxt.head;

public class TitleElement(string title)
{
    string _value = title;

    public string HtmlView() => $"<title>{_value}</title>";

    public static implicit operator string(TitleElement title)
    {
        return title._value;
    }

    public static implicit operator TitleElement(string title)
    {
        return new TitleElement(title);
    }
}
