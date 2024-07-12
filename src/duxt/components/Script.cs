namespace duxt.component;

public class Script(string src)
    : Component
{
    public override string Tag { get; } = "script";
    public override List<IComponent>? Slot { get; set; } = [];

    public override string Display() => @$"<script src=""{src}""></script>";
}
