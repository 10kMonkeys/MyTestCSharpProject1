using MyTestCSharpProject1.Src.PageObject.Pages;

namespace MyTestCSharpProject1.Src.PageObject.Steps
{
    public class AtSlideOutCartPage
    {
        private readonly SlideOutCardPage atPage;

        public AtSlideOutCartPage(SlideOutCardPage page)
        {
            atPage = page;
        }

        internal void ClickOnViewCartBtn()
        {
            atPage.ClickOnViewCartBtn();
        }
    }
}
