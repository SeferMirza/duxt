using duxt.component;

namespace duxt.app.pages;

public class AboutPage : IBodyContent
{
    public IComponent Invoke(WebContext context)
    {
        return
            new Div
            {
                Slot = [
                    new Br(),
                    new P(@$"I was born in Karabiga, a town in the Biga district of Çanakkale.
                    I completed my primary and secondary education at the local school. I
                    attended high school at Biga İçdaş Anadolu Technical High School,
                    where I studied Web Design and Computer Programming. During this time,
                    I pursued sailing professionally for five years and a total of seven years,
                    and I also played football for two years with the local club. Additionally,
                    I have a keen interest in tennis.")
                    {
                        Class = "about-paragraph"
                    },
                    new Br(),
                    new P(@$"Later, I studied Software Engineering at Celal Bayar University.
                    Growing up, I worked in various jobs due to the influence of my environment,
                    notably in fishing because my father was a fisherman, as well as in retail,
                    waiting tables, and other roles. This early start in the workforce instilled
                    in me a strong work ethic.")
                    {
                        Class = "about-paragraph"
                    },
                    new Br(),
                    new P(@"Whether in sports or my professional endeavors, I consider myself
                    disciplined, ambitious, and resilient, with a high tolerance for challenges.
                    My life philosophy has always been to 'be the sought-after person.' Therefore,
                    I strive to do my work impeccably and constantly seek to understand why the best are the best.")
                    {
                        Class = "about-paragraph"
                    }
                ]
            };
    }
}
