namespace duxt;

public class Head(Dictionary<string, string> _elements)
{
    public string Display()
    {
        return @$"
        <head>
            {string.Join("\n", _elements)}
        </head>
        ";
    }
}
