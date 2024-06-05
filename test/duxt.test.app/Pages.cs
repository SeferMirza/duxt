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
                                    new H2("About"),
                                    new Text("I'm a Software Engineer :)")
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
                                                imgSrc: "https://singularity.gs/wp-content/uploads/2018/04/css.jpg",
                                                title: "Project Title",
                                                text: "Project description goes here. It's a brief intro to the project.",
                                                link: "projectLink.html"
                                            ),
                                            new Card(
                                                imgSrc: "https://singularity.gs/wp-content/uploads/2018/04/css.jpg",
                                                title: "Project Title",
                                                text: "Project description goes here. It's a brief intro to the project.",
                                                link: "projectLink.html"
                                            ),
                                            new Card(
                                                imgSrc: "https://singularity.gs/wp-content/uploads/2018/04/css.jpg",
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
                                            new Div(
                                                @class: "article",
                                                slot: [
                                                    new Div(
                                                        @class: "article-img",
                                                        slot: [ ]
                                                    )
                                                ]
                                            ),
                                            new Div(
                                                @class: "article",
                                                slot: [
                                                    new Div(
                                                        @class: "article-img",
                                                        slot: [ ]
                                                    )
                                                ]
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
                        Width = "100%"
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
                    }
                },
                {
                    "projects-container", new Styles {
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
                        MinWidth = "10vw",
                        MaxWidth = "15vw",
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
