using System.Text.RegularExpressions;

namespace duxt;

public static class Extensions
{
    public static string HtmlIndentation(this string html)
    {
        var result = string.Empty;
        Stack<string> stack = new();
        string patternThatCheckEndWithGT = @"(?<=>)";
        string patternThatCheckStartWithLT = @"^</?\w+";
        string patternThatCheckhLT = @"(?=<)";
        string[] parts = Regex.Split(html, patternThatCheckEndWithGT);

        foreach(var line in parts)
        {
            var trimmedLine = line.Trim();
            if(trimmedLine == string.Empty) break;

            bool isMatch = Regex.IsMatch(trimmedLine, patternThatCheckStartWithLT);
            if(!isMatch)
            {
                var splitTextAndElement = Regex.Split(trimmedLine, patternThatCheckhLT);
                trimmedLine = splitTextAndElement[1].Trim();
                stack.Push(splitTextAndElement[0].Trim());
            }

            stack.Push(trimmedLine);
        }

        int indent = 0;
        string cacheLastElement = string.Empty;
        while (stack.Count > 0)
        {
            string item = stack.Pop();

            if((IsClosingTag(item) || IsContent(item)) && IsClosingTag(cacheLastElement))
            {
                indent++;
            }
            else if(IsOpeningTag(item) && IsContent(cacheLastElement))
            {
                indent--;
            }
            else if(IsOpeningTag(item) && IsOpeningTag(cacheLastElement))
            {
                indent--;
            }

            result = $"{new string(' ', indent * 2)}{item}{Environment.NewLine}{result}";

            cacheLastElement = item;
        }

        return result;
    }

    static bool IsOpeningTag(string str) => str.StartsWith('<') && !str.StartsWith("</");
    static bool IsClosingTag(string str) => str.StartsWith("</");
    static bool IsContent(string str) => !str.StartsWith('<');
}
