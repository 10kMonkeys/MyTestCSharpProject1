using System.Collections.Generic;
using MyTestCSharpProject1.net.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyTestCSharpProject1.Src.PageObject.Pages
{
    public class HomePage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'SearchField-input-')]")]
        private IWebElement SearchField { get; set; }

        [FindsBy(How = How.Id, Using = "addProductToCartBtn")]
        private IWebElement FirstProductAddToCardBtnFirstSlider { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'Product-product__title-')]")]
        private IList<IWebElement> ProductTitleList { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void OpenHomePage() => OpenPage("", true);

        public IWebElement GetSearchField()
        {
            return SearchField;
        }

        public void ClickOnFirstProductAddToCardBtnFirstSlider()
        {
            FirstProductAddToCardBtnFirstSlider.Click();
        }

        public string[] GetListOfProductTitles()
        {
            string[] titleList = new string[ProductTitleList.Count];

            for (int i = 0; i < ProductTitleList.Count; i++)
            {
                titleList[i] = ProductTitleList[i].GetAttribute("textContent");
            }

            return titleList;
        }
    }
}
