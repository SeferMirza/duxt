using duxt.component;

namespace duxt.head;

public class Heads
{
    public List<Link> Links { get; }
    public List<Meta> Metas { get; }
    public Title Title { get; set;}

    public Heads()
    {
        Links = [];
        Metas = [];
        Title = new("Duxt");
    }
}
