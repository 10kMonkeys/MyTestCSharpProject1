using MyTestCSharpProject1.Src.PageObject.Pages;
using MyTestCSharpProject1.Src.PageObject.Pages.Base;

namespace MyTestCSharpProject1.Src.PageObject.Steps.StepsFactory
{
    public class StepsFactory
    {
        public PageProvider pageProvider;
        public AtHomePage atHomePage;
        public AtSlideOutCartPage atSlideOutCardPage;
        public AtCartPage atCartPage;

        public StepsFactory(PageProvider pageProvider)
        {
            this.pageProvider = pageProvider;
            atHomePage = new AtHomePage(pageProvider.InitPage<HomePage>());
            atSlideOutCardPage = new AtSlideOutCartPage(pageProvider.InitPage<SlideOutCardPage>());
            atCartPage = new AtCartPage(pageProvider.InitPage<CartPage>());
        }

    }
}
