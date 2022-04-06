using Allure.Xunit.Attributes;
using MyTestCSharpProject1.Test.Tests.Base;
using Xunit;

namespace MyTestCSharpProject1.Test.Tests
{
    //[AllureSuite("Suite B")]
    [Collection("Collection B")]
    public class UnitTest2 : BaseWebTest
    {
        public UnitTest2()
        {
        }

        [Fact]
        //[AllureXunit(DisplayName = "Test 3")]
        public void Test3()
        {
            user.atHomePage.OpenHomePage();
            user.atHomePage.VerifySearchFieldIsDisplayed();
            user.atHomePage.ClickOnFirstProductAddToCardBtnFirstSlider();
            user.atSlideOutCardPage.ClickOnViewCartBtn();
            user.atCartPage.VerifyCartPageTitleIsDisplayed();
        }

        [Fact]
        //[AllureXunit(DisplayName = "Test 4")]
        public void Test4()
        {
            user.atHomePage.OpenHomePage();
            user.atHomePage.VerifySearchFieldIsDisplayed();
            user.atHomePage.ClickOnFirstProductAddToCardBtnFirstSlider();
            user.atSlideOutCardPage.ClickOnViewCartBtn();
            user.atCartPage.VerifyCartPageTitleIsDisplayed();
        }
    }
}
