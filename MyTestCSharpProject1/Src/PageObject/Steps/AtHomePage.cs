using MyTestCSharpProject1.Src.PageObject.Pages;
using Xunit;

namespace MyTestCSharpProject1.Src.PageObject.Steps
{
    public class AtHomePage
    {
        private readonly HomePage atPage;

        public AtHomePage(HomePage page)
        {
            atPage = page;
        }

        public void OpenHomePage()
        {
            atPage.OpenHomePage();
        }

        public void VerifySearchFieldIsDisplayed()
        {
            Assert.True(atPage.GetSearchField().Displayed);
        }

        public void ClickOnFirstProductAddToCardBtnFirstSlider()
        {
            atPage.ClickOnFirstProductAddToCardBtnFirstSlider();
        }

        public string[] GetListOfProductTitles()
        {
            return atPage.GetListOfProductTitles();
        }
    }
}
