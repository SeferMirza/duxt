using System.Text;
using System.Text.RegularExpressions;

namespace duxt;

public static class IndentationExtensions
{
    public static string HtmlIndentation(this string html)
    {
        var result = string.Empty;
        Stack<string> stack = new();
        string patternThatCheckEndWithGT = @"(?<=>)";
        string patternThatCheckStartWithLT = @"^</?\w+";
        string patternThatCheckLT = @"(?=<)";
        string[] parts = Regex.Split(html, patternThatCheckEndWithGT);

        foreach(var line in parts)
        {
            var trimmedLine = line.Trim();
            if(trimmedLine == string.Empty) break;

            bool isMatch = Regex.IsMatch(trimmedLine, patternThatCheckStartWithLT);
            if(!isMatch)
            {
                var splitTextAndElement = Regex.Split(trimmedLine, patternThatCheckLT);
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

            if((IsClosingTag(item) || IsContent(item)) && IsClosingTag(cacheLastElement) && cacheLastElement != "</style>")
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
            else if(IsContent(item) && cacheLastElement == "</style>")
            {
                indent++;
                item = item.CssIndentation();
            }
            else if(IsVoidOrSelfClosing(item))
            {
                indent += IsClosingTag(cacheLastElement)
                    ? 1
                    : IsVoidOrSelfClosing(cacheLastElement)
                        ? 0
                        : -1;
            }

            var lines = item.Split("\n").Reverse().ToArray();
            foreach((var line, int index) in lines.Select((line, index) => (line, index)))
            {
                result = $"{new string(' ', indent * 2)}{lines[index]}{Environment.NewLine}{result}";
            }

            cacheLastElement = item;
        }

        return result;
    }

    public static string CssIndentation(this string css)
    {
        css = css.Replace("\r\n", "\n").Replace("\r", "\n");

        string[] lines = css.Split('\n');
        int indent = 0;
        string indentString = "  ";
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Trim();

            if (lines[i].EndsWith("}"))
            {
                indent--;
            }

            lines[i] = new string(' ', indent * indentString.Length) + lines[i];

            if (lines[i].EndsWith("{"))
            {
                indent++;
            }
        }

        return string.Join("\n", lines);
    }

    public static void PublishHtmlFile(this string content, string fileName, string path)
    {
        string filePath = Path.Combine(path, fileName);
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        using FileStream fs = File.Create(filePath);
        byte[] info = new UTF8Encoding(true).GetBytes(content);
        fs.Write(info, 0, info.Length);
    }

    public static string AlsoPublishHtmlFile(this string content, string fileName, string path)
    {
        string filePath = Path.Combine(path, fileName);
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }

        using FileStream fs = File.Create(filePath);
        byte[] info = new UTF8Encoding(true).GetBytes(content);
        fs.Write(info, 0, info.Length);

        return content;
    }

    static bool IsOpeningTag(string str) => str.StartsWith('<') && !str.StartsWith("</") && !IsVoidOrSelfClosing(str);
    static bool IsClosingTag(string str) => str.StartsWith("</");
    static bool IsContent(string str) => !str.StartsWith('<');
    static bool IsVoidOrSelfClosing(string str) => str.StartsWith("<meta") || str.StartsWith("<link") || str.StartsWith("<img");
}
