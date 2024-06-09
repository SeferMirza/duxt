using duxt;
using duxt.app.components;
using duxt.component;

internal class IndexPage : IBodyComponent
{
    public string Invoke(HtmlContext context)
    {
        var index = new Div(
                    @class: "container monospace centered-content",
                    slot: [
                        new Div(
                            @class: "banner centered-content",
                            slot: [
                                new H1(
                                    text: "Sefer Mirza | FullStack Developer",
                                    @class: "monospace",
                                    styles: new() { AlignContent = "center" }
                                )
                            ]
                        ),
                        new Div(
                            @class: "about-container centered-content column",
                            slot: [
                                new H2("About this blog"),
                                new Text("Welcome to my website. Here you can see the projects I have developed, what I have learned, and the posts I have published during this process. As long as I do not lose my enthusiasm and curiosity for learning, I will continue to publish what I learn and develop here.")
                            ]
                        ),
                        new Div(
                            @class: "about-container centered-content column",
                            slot: [
                                new H2("About me"),
                                new Text("My name is Sefer Mirza. I am a Software Engineer. I graduated from the Software Engineering department at Celal Bayar University.")
                            ]
                        ),
                        new Div(
                            @class: "projects-container centered-content column",
                            slot: [
                                new H2("My Projects"),
                                new Div(
                                    @class: "projects",
                                    slot: [
                                        new Card(
                                            imgSrc: "./images/code.jpg",
                                            title: "Project Title",
                                            text: "Project description goes here. It's a brief intro to the project.",
                                            link: "projectLink.html"
                                        ),
                                        new Card(
                                            imgSrc: "./images/code.jpg",
                                            title: "Project Title",
                                            text: "Project description goes here. It's a brief intro to the project.",
                                            link: "projectLink.html"
                                        ),
                                        new Card(
                                            imgSrc: "./images/code.jpg",
                                            title: "Project Title",
                                            text: "Project description goes here. It's a brief intro to the project.",
                                            link: "projectLink.html"
                                        )
                                    ]
                                )
                            ]
                        ),
                        new Div(
                            @class: "articles-container centered-content column",
                            slot: [
                                new H2("My Articles"),
                                new Div(
                                    @class: "articles",
                                    slot: [
                                        new Card(
                                            imgSrc: "./images/article.png",
                                            title: "Article Title",
                                            text: "Article description goes here. It's a brief intro to the article.",
                                            link: "projectLink.html"
                                        ),
                                        new Card(
                                            imgSrc: "./images/article.png",
                                            title: "Article Title",
                                            text: "Article description goes here. It's a brief intro to the article.",
                                            link: "projectLink.html"
                                        ),
                                        new Card(
                                            imgSrc: "./images/article.png",
                                            title: "Article Title",
                                            text: "Article description goes here. It's a brief intro to the article.",
                                            link: "projectLink.html"
                                        )
                                    ]
                                )
                            ]
                        )
                    ]
                );

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
                    Width = "24vw",
                    BorderRadius = "5px",
                    Margin = "10px"
                }),
                (".card:hover", new() { BoxShadow = "0 8px 16px 0 rgba(255,255,255)" }),
                (".card-img", new() { Width = "100%", BorderRadius = "5px 5px 0 0" }),
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
                (".btn:hover", new() { BackgroundColor = "#dd" })
            ]
        );

        return index.Display();
    }
}
