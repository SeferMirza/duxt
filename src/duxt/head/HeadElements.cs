namespace duxt.head;

public class HeadElements
{
    public LinkElements Links { get; }
    public MetaELements Metas { get; }
    public TitleElement Title { get; set;}

    public HeadElements()
    {
        Links = new();
        Metas = new();
        Title = new("Duxt");
    }
}
