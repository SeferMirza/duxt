namespace duxt.test;

public static class TestsExtensions
{
    public static string IgnoreIndentation(this string text)
    {
        return text
            .Replace(Environment.NewLine, string.Empty)
            .Replace(" ", string.Empty)
            .Replace("\n", string.Empty);
    }
}