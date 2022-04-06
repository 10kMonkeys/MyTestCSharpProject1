using MyTestCSharpProject1.net.Pages;
using MyTestCSharpProject1.Src.Data;
using OpenQA.Selenium;

namespace MyTestCSharpProject1.Src.PageObject.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        internal IWebElement GetCartPageTitle() => GetCertainPageTitle(PageTitles.CartPage);
    }
}
