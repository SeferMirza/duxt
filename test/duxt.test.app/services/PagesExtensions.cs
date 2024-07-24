using duxt.app.pages;

namespace duxt.app.services;

public static class PagesExtensions
{
    public static void AddPages(this WebSite web)
    {
        web.AddBodySlot<IndexPage>();
        web.AddBodySlot<AboutPage>();
        // web.AddBodySlot<BlogPage>();
        web.AddBodySlot<ContactPage>();
        web.AddBodySlot<PortfolioPage>();
    }
}
