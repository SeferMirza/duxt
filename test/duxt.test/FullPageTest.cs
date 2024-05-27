using System.Xml.Linq;

namespace duxt.test;

[TestFixture]
public class FullPageTest
{
    [Test]
    public void DisplayTest()
    {
        var expected = XDocument.Parse(@$"<html>
            <head>
                <title>duxt test</title>
            </head>
            <body>
                <div>
                    duxt
                </div>
                <div>
                    test
                </div>
            </body>
        </html>").ToString();
        var page = new Html(
            head: new Head(new() { {"title", "duxt test"} }),
            body: new Body([
                new Div([
                    new Text("duxt")
                ]),
                new Div([
                    new Text("test")
                ])
            ])
        );

        var actual = page.Display();

        Assert.That(actual, Is.EqualTo(expected));
    }
}