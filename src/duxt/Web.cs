namespace duxt;

public static class Web
{
    public static string Create()
    {
        Html html= new();
        return html.Display();
    }
}
