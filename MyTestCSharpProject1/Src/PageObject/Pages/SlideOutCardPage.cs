using MyTestCSharpProject1.net.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyTestCSharpProject1.Src.PageObject.Pages
{
    public class SlideOutCardPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a.cart-footer__cart-btn")]
        private IWebElement ViewCartBtn { get; set; }

        public SlideOutCardPage(IWebDriver driver) : base(driver)
        {
        }        

        internal void ClickOnViewCartBtn()
        {
            ViewCartBtn.Click();
        }
    }
}