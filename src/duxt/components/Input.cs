namespace duxt.component;

public class Input(string type) : Component
{
    public override string Tag => "input";

    public override string Display()
    {
        OtherProperties.TryAdd("type", type);

        return base.Display();
    }
}