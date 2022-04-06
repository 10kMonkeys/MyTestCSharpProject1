using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace MyTestCSharpProject1.net.Pages
{
    public abstract class BasePage
    {

        protected IWebDriver Driver { get; set; }
        protected WebDriverWait wait;

        private readonly string pageTitleLocator = "//div[@class='cart__title ']";

        private readonly By acceptCookiesBtnLocatorID = By.Id("CybotCookiebotDialogBodyButtonAccept");

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(6000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(10000);
            wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(6000));

            driver.Manage().Window.Maximize();
        }

        protected void OpenPage(string url, bool isNeedToAcceptCookies = false)
        {
            Driver.Navigate().GoToUrl(Environment.GetEnvironmentVariable("Env") + url);


            if (isNeedToAcceptCookies)
            {
                AcceptCookies();
            }
        }

        private void AcceptCookies()
        {
            var acceptCookiesBtn = wait.Until(ExpectedConditions.ElementIsVisible(acceptCookiesBtnLocatorID));
            acceptCookiesBtn.Click();
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(acceptCookiesBtnLocatorID));
        }

        protected IWebElement GetCertainPageTitle(string pageTitleValue)
        {
            var pageTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(pageTitleLocator + $"[text() = '{pageTitleValue}']")));
            return pageTitle; 
        }
    }
}
