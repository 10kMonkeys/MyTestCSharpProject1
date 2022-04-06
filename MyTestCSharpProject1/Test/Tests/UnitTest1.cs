using MyTestCSharpProject1.Test.Tests.Base;
using Xunit;

namespace MyTestCSharpProject1.Test.Tests
{
    //[AllureSuite("Suite A")]
    [Collection("Collection A")]
    public class UnitTest1 : BaseWebTest
    {
        public UnitTest1()
        {
        }

        [Fact]
        //[AllureXunit(DisplayName = "Test 1")]
        public void Test1()
        {
            user.atHomePage.OpenHomePage();
            user.atHomePage.VerifySearchFieldIsDisplayed();
            user.atHomePage.ClickOnFirstProductAddToCardBtnFirstSlider();
            user.atSlideOutCardPage.ClickOnViewCartBtn();
            user.atCartPage.VerifyCartPageTitleIsDisplayed();
        }

        [Fact]
        //[AllureXunit(DisplayName = "Test 2")]
        public void Test2()
        {
            user.atHomePage.OpenHomePage();
            user.atHomePage.VerifySearchFieldIsDisplayed();
            user.atHomePage.ClickOnFirstProductAddToCardBtnFirstSlider();
            user.atSlideOutCardPage.ClickOnViewCartBtn();
            user.atCartPage.VerifyCartPageTitleIsDisplayed();
        }
    }
}
