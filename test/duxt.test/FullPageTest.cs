using duxt.component;
using duxt.styles;

namespace duxt.test;

[TestFixture]
public class FullPageTest
{
    [Test]
    public void DisplayTest()
    {
        var expected =
@"<html>
  <head>
    <title>
      duxt test
    </title>
  </head>
  <body>
    <div class=""duxtClass"" id=""duxtId"">
      duxt
    </div>
    <div class=""testClass"" id=""testId"" style=""text-align: center;"">
      test
    </div>
  </body>
  <style>
    .duxtClass {
      color: red;
    }
  </style>
</html>
";
        var page = new Html(
            head: new Head([ ("title", "duxt test") ]),
            body: new Body([
                new Div(
                    slot: [ new Text("duxt") ],
                    @class: "duxtClass",
                    id: "duxtId"
                ),
                new Div(
                    slot: [ new Text("test") ],
                    @class: "testClass",
                    id: "testId",
                    styles: new() { TextAlign = "center" }
                )
            ]),
            styles: new() {
                {"duxtClass", new Styles { Color = "red" }}
            }
        );

        var actual = page.Display();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void FormatterTest()
    {
        var expected =
@"<html>
  <head>
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