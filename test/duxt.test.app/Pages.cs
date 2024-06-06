using duxt.app.components;
using duxt.component;
using duxt.styles;

namespace duxt.app;

public static class Pages
{
    public static string Index =>
        Web.Create().Build(tool =>
        tool.Html(
            head: new Head(
                [
                    ("title", "Sefer Mirza")
                ],
                [
                    ("https://fonts.googleapis.com", "preconnect"),
                    ("https://fonts.gstatic.com", "preconnect"),
                    ("https://fonts.googleapis.com/css2?family=VT323&display=swap", "stylesheet"),
                ]
            ),
            body: new Body([
                    new Div(
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
                    )
                ],
                styles: new() { Margin = "0", BackgroundColor = "black", Color = "white" }
            ),
            styles: new() {
                {
                    "container", new Styles {
                        FlexDirection = "column",
                        AlignItems = "center"
                    }
                },
                {
                    "column", new Styles {
                        FlexDirection = "column"
                    }
                },
                {
                    "banner",  new Styles {
                        Height = "20vh",
                        Width = "100%",
                        BackgroundImage = "url(\"./images/code.jpg\")",
                        BackgroundRepeat = "no-repeat",
                        BackgroundSize = "cover"
                    }
                },
                {
                    "centered-content",  new Styles {
                        Display = "flex",
                        JustifyContent = "center",
                        AlignItems = "center"
                    }
                },
                {
                    "about-container",  new Styles {
                        Width = "78%"
                    }
                },
                {
                    "projects-container", new Styles {
                        Width = "80%"
                    }
                },
                {
                    "projects", new Styles {
                        Display = "flex",
                        JustifyContent = "space-around",
                        AlignItems = "center",
                        FlexWrap = "wrap"
                    }
                },
                {
                    "project", new Styles {
                        BoxShadow = "0 4px 8px 0 rgba(0,0,0,0.2)",
                        Transition = "0.3s",
                        Width = "300px",
                        Margin = "10px"
                    }
                },
                {
                    "articles-container", new Styles {
                        Width = "80%"
                    }
                },
                {
                    "articles", new Styles {
                        Display = "flex",
                        JustifyContent = "space-around",
                        AlignItems = "center",
                        FlexWrap = "wrap"
                    }
                },
                {
                    "article", new Styles {
                        BoxShadow = "0 4px 8px 0 rgba(0,0,0,0.2)",
                        Transition = "0.3s",
                        Width = "300px",
                        Margin = "10px"
                    }
                },
                {
                    "monospace",  new Styles {
                        FontFamily = "VT323, monospace",
                        FontWeight = "400"
                    }
                },
                {
                    "card", new Styles {
                        BoxShadow = "0 4px 8px 0 rgba(255,255,255,0.2)",
                        Transition = "0.3s",
                        Width = "24vw",
                        BorderRadius = "5px",
                        Margin = "10px"
                    }
                },
                {
                    "card:hover", new Styles {
                        BoxShadow = "0 8px 16px 0 rgba(255,255,255)"
                    }
                },
                {
                    "card-img", new Styles {
                        Width = "100%",
                        BorderRadius = "5px 5px 0 0"
                    }
                },
                {
                    "btn", new Styles {
                        Padding = "10px",
                        BackgroundColor = "#f0f0f0",
                        TextDecoration = "none",
                        Color = "black",
                        BorderRadius = "5px",
                        TextAlign = "center",
                        Display = "block",
                        MarginTop = "10px"
                    }
                },
                {
                    "btn:hover", new Styles {
                        BackgroundColor = "#dd"
                    }
                }
            }
        ).Display()
    );
}
