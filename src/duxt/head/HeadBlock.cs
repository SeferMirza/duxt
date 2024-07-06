using duxt.component;

namespace duxt.head;

public class HeadBlock
{
    public List<Link> Links { get; }
    public List<Meta> Metas { get; }
    public Title Title { get; set;}

    public HeadBlock()
    {
        Links = [];
        Metas = [];
        Title = new("Duxt");
    }
}
