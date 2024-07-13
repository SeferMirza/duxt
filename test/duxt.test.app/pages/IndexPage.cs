using duxt.app.components;
using duxt.component;

namespace duxt.app.pages;

public class IndexPage : IBodyContent
{
    public IComponent Invoke(WebContext context, HttpClient client)
    {
        context.Styles.Add(
            [
                ("body", new() { Margin = "0", BackgroundColor = "black", Color = "white" }),
                (".container", new() { FlexDirection = "column", AlignItems = "center" }),
                (".column", new() { FlexDirection = "column" }),
                (".banner",  new() {
                    Height = "20vh",
                    Width = "100%",
                    BackgroundImage = "url(\"./images/code.jpg\")",
                    BackgroundRepeat = "no-repeat",
                    BackgroundSize = "cover"
                }),
                (".centered-content",  new() {
                    Display = "flex",
                    JustifyContent = "center",
                    AlignItems = "center"
                }),
                (".about-container",  new() { Width = "78%" }),
                (".projects-container", new() { Width = "80%" }),
                (".projects", new() {
                    Display = "flex",
                    JustifyContent = "space-around",
                    AlignItems = "center",
                    FlexWrap = "wrap"
                }),
                (".project", new() {
                        BoxShadow = "0 4px 8px 0 rgba(0,0,0,0.2)",
                        Transition = "0.3s",
                        Width = "300px",
                        Margin = "10px"
                }),
                (".articles-container", new() { Width = "80%" }),
                (".articles", new() {
                    Display = "flex",
                    JustifyContent = "space-around",
                    AlignItems = "center",
                    FlexWrap = "wrap"
                }),
                (".article", new() {
                    BoxShadow = "0 4px 8px 0 rgba(0,0,0,0.2)",
                    Transition = "0.3s",
                    Width = "300px",
                    Margin = "10px"
                }),
                (".monospace",  new() {
                    FontFamily = "VT323, monospace",
                    FontWeight = "400"
                }),
                (".card", new() {
                    BoxShadow = "0 4px 8px 0 rgba(255,255,255,0.2)",
                    Transition = "0.3s",
                    Width = "20vw",
                    BorderRadius = "5px",
                    Margin = "10px",
                    Display = "flex",
                    AlignItems = "center",
                    FlexDirection = "column",
                    Overflow = "hidden"
                }),
                (".card:hover", new() { BoxShadow = "0 8px 16px 0 rgba(255,255,255)" }),
                (".card-title", new() { FontSize = "5vw", Margin = "0", Height = "200px", WhiteSpace = "nowrap" }),
                (".card-content-container", new() { Width = "100%" }),
                (".btn", new() {
                    Padding = "10px",
                    BackgroundColor = "#f0f0f0",
                    TextDecoration = "none",
                    Color = "black",
                    BorderRadius = "5px",
                    TextAlign = "center",
                    Display = "block",
                    MarginTop = "10px"
                }),
                (".btn:hover", new() { BackgroundColor = "#ddd" }),
                ("h1", new() { AlignContent = "center" })
            ]
        );
        context.Scripts.Add(new Script("./scripts/main.js")
        {
            OtherProperties = new () { {"type", "module"} }
        });

        return
            new Div
            {
                Class = "container monospace centered-content",
                Slot = [
                    new Banner("Sefer Mirza | FullStack Developer"),
                    new Div
                    {
                        Class = "about-container centered-content column",
                        Slot = [
                            new H1("About this blog"),
                            new Text("Welcome to my website. Here you can see the projects I have developed, what I have learned, and the posts I have published during this process. As long as I do not lose my enthusiasm and curiosity for learning, I will continue to publish what I learn and develop here.")
                        ]
                    },
                    new Div
                    {
                        Class = "about-container centered-content column",
                        Slot = [
                            new H1("About me"),
                            new Text("My name is Sefer Mirza. I am a Software Engineer. I graduated from the Software Engineering department at Celal Bayar University.")
                        ]
                    },
                    new Projects(),
                    new Articles()
                ]
            };
    }
}
