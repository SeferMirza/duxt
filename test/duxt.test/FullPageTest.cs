using duxt.component;

namespace duxt.test;

[TestFixture]
public class StyleGeneration
{
    class TestComponent : Component
    {
        public override List<IComponent>? Slot { get; set; } = [
            new Div
            {
              Slot = [new Text("duxt")],
              Class = "duxtClass",
              Id = "duxtId"
            },
            new Div
            {
              Slot = [new Text("test")],
              Class = "testClass",
              Id = "testId",
              Styles = new() { TextAlign = "center" }
            },
        ];
    };

    class TestPage : IBodyContent
    {
        public IComponent Invoke(WebContext context, HttpClient client)
        {
            context.Styles.Add([
              (".duxtClass", new(){ Color = "red" }),
              (".test", new(){ AlignItems = "center" }),
            ]);
            context.Heads.Title = new(title:"Test");
            context.Heads.Links.AddRange([
              new(href: "styles1.css", rel: "stylesheet"),
              new(href: "styles2.css", rel: "stylesheet")
            ]);
            context.Heads.Metas.AddRange([
              new(name: "og", content: "duxt", property: "og:title"),
              new(name: "og", content: "duxt.jpg", property: "og:image"),
            ]);

            return new TestComponent();
        }
    }

    [Test]
    public void Display_all_item_correctly()
    {
        var expected =
@"<html>
  <head>
    <title>
      Test
    </title>
    <link href=""styles1.css"" rel=""stylesheet"">
    <link href=""styles2.css"" rel=""stylesheet"">
    <meta name=""og"" content=""duxt"" property=""og:title"">
    <meta name=""og"" content=""duxt.jpg"" property=""og:image"">
  </head>
  <body>
    <div>
      <div class=""duxtClass"" id=""duxtId"">
        duxt
      </div>
      <div class=""testClass"" id=""testId"" style=""text-align: center;"">
        test
      </div>
    </div>
  </body>
  <style>
    .duxtClass {
      color: red;
    }
    .test {
      align-items: center;
    }
  </style>
</html>
";
        var builder = Builder.CreateHtml();
        builder.AddBodySlot<TestPage>();

        var actual = builder.DisplayPage<TestPage>();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Formatter_fix_indentation()
    {
        var expected =
@"<html>
  <head>
    <title>
      Duxt
    </title>
    <link href=""styles1.css"" rel=""stylesheet"">
    <link href=""styles2.css"" rel=""stylesheet"">
    <meta name=""og"" content=""duxt"" property=""og:title"">
    <meta name=""og"" content=""someimage.com"" property=""og:image"">
  </head>
  <body>
    <div>
      div 1
    </div>
    <div>
      div 2
    </div>
    <div>
      div 3
    </div>
    <div>
      div 4
    </div>
  </body>
  <style>
    .duxtClass {
      color: red;
    }
  </style>
</html>
";
        var test =
@"<html><head>
    <title>Duxt
</title><link href=""styles1.css"" rel=""stylesheet"">
         <link href=""styles2.css"" rel=""stylesheet""><meta name=""og"" content=""duxt"" property=""og:title"">
<meta name=""og"" content=""someimage.com"" property=""og:image"">
</head>
    <body>
  <div>div 1</div>
  <div>div 2
  </div>
  <div>
  div 3
  </div>
  <div>
  div 4</div>
</body>
<style>    .duxtClass {
      color: red;
    }
</style>
 </html>";

        var actual = test.HtmlIndentation();

        Assert.That(actual, Is.EqualTo(expected));
    }
}