using duxt.app.pages;

namespace duxt.app;

public static class PagesExtensions
{
    public static void AddPages(this WebSite web)
    {
        web.AddBodySlot<IndexPage>();
        web.AddBodySlot<AboutPage>();
        web.AddBodySlot<LinksPage>();
        web.AddBodySlot<SkillsPage>();
    }
}
