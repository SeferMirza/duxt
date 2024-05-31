namespace duxt.app.pages;

public static class Profile
{
    public static string Page =>
        Web.Create().Build(tool =>
        tool.Html(
            head: new Head(new() { {"title", "duxt"} }),
            body: new Body([
                new Div(
                    [ new Text("Sefer") ],
                    @class: "name"
                ),
                new Div(
                    [ new Text("Mirza") ],
                    @class: "surname",
                    styles: new() { TextAlign = "center" }
                )
            ]),
            styles: new() {
                {"name", new Styles { Color = "red" }},
                {"surname",  new Styles { Color = "yellow" }}
            }
        ).Display()
    );
}
