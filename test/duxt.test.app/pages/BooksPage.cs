using duxt.component;

namespace duxt.app.pages;

public class BooksPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        context.Styles.AddRange([
            (".book", new(){ FontWeight = "bold", Color = "#D54E53" }),
            (".status-done", new(){ FontWeight = "bold", Color = "#01a252" }),
            (".status-continues", new(){ FontWeight = "bold", Color = "#969896" })
        ]);

        return
            new Div
            {
                Class = "books-container",
                Slot = [
                    new Div
                    {
                        Slot = [
                            new Text("Below is the list of books I read to help me get better at my job.")
                        ]
                    },
                    new Ul
                    {
                        Class = "list",
                        Slot = [
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("Agile Software Development")]
                                    },
                                    new Text("- Robert C. Martin"),
                                    new Span
                                    {
                                        Class = "status-done",
                                        Slot = [new Text("Done")]
                                    }
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("Refactoring")]
                                    },
                                    new Text("- Robert C. Martin"),
                                    new Span
                                    {
                                        Class = "status-continues",
                                        Slot = [new Text("Continues")]
                                    }
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("Clean Code")]
                                    },
                                    new Text("- Robert C. Martin"),
                                    new Span
                                    {
                                        Class = "status-done",
                                        Slot = [new Text("Done")]
                                    }
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("Surely You’re Joking, Mr. Feynman!")]
                                    },
                                    new Text("- Richard P. Feynman"),
                                    new Span
                                    {
                                        Class = "status-done",
                                        Slot = [new Text("Done")]
                                    }
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("Logic of Scientific Discovery")]
                                    },
                                    new Text("- Karl Popper"),
                                    new Span
                                    {
                                        Class = "status-continues",
                                        Slot = [new Text("Continues")]
                                    }
                                ]
                            },
                            new Li
                            {
                                Slot = [
                                    new Span
                                    {
                                        Class = "book",
                                        Slot = [new Text("The Magic of Math")]
                                    },
                                    new Text("- Arthur T. Benjamin"),
                                    new Span
                                    {
                                        Class = "status-done",
                                        Slot = [new Text("Done")]
                                    }
                                ]
                            }
                        ]
                    }
                ]
            };
    }
}
