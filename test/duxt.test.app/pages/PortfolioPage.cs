using duxt.app.components;
using duxt.component;

namespace duxt.app.pages;

public class PortfolioPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        context.Styles.AddRange(
            [

            ]
        );

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
