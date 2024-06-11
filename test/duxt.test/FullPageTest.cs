using duxt.component;

namespace duxt.test;

[TestFixture]
public class StyleGeneration
{
    class TestComponent()
    : Component(
        [
            new Div(slot: [new Text("duxt")], @class: "duxtClass", id: "duxtId"),
            new Div(slot: [new Text("test")], @class: "testClass", id: "testId", styles: new() { TextAlign = "center" })
        ],
        new("div", default, default),
        default
    ) { }

    class TestPage : IBodyComponent
    {
        public Component Invoke(HtmlContext context)
        {
            context.Styles.Add([
              (".duxtClass", new(){ Color = "red" }),
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
      Duxt
    </title>
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
  </style>
</html>
";
        var builder = Builder.CreateHtml();

        var actual = builder.Slot<TestPage>();

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
    <title>
      Duxt
    </title>
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