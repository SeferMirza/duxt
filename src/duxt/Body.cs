namespace duxt;

public class Body(Component slot, string @class, string id, Styles styles) : Component(slot, @class, id, styles)
{

    public override string Display()
    {
        return string.Empty;
    }
}
