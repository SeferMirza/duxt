using System.Xml.Linq;
using duxt.styles;

namespace duxt.component;

public class Html(Head head, Body body, Dictionary<string, Styles>? styles = default)
    : Component([head, body], default, default, "html", default)
{
    public override string Display()
    {
        var stylesDisplay = styles != default
            ? string.Join("\n", styles.Select(style =>
            @$".{style.Key} {{
      {style.Value.DisplayYDirection()}
    }}"))
            : string.Empty;

        return @$"<html>
          {head.Display()}
          {body.Display()}
          <style>
            {stylesDisplay}
          </style>
        </html>".HtmlIndentation();
    }
}
