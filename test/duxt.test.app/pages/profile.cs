namespace duxt.app.pages;

public static class Profile
{
    public static string Page =>
        Web.Create().Build(tool =>
        tool.Html(
            head: new Head(new() { {"title", "duxt"} }),
            body: new Body([
                new Div([
                    new Text("Sefer")
                ]),
                new Div([
                    new Text("Mirza")
                ])
            ])
        ).Display()
    );

}