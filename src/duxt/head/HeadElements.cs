namespace duxt.head;

public class HeadElements
{
    public LinkElements Links { get; }
    public PropertyElements PropertyElements { get; }

    public HeadElements()
    {
        Links = new();
        PropertyElements = new();
    }
}
