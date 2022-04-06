using System;
using MyTestCSharpProject1.Src.PageObject.Pages;
using OpenQA.Selenium;
using Xunit;

namespace MyTestCSharpProject1.Src.PageObject.Steps
{
    public class AtCartPage
    {
        private readonly CartPage atPage;

        public AtCartPage(CartPage page)
        {
            atPage = page;
        }

        internal void VerifyCartPageTitleIsDisplayed()
        {
            Assert.True(atPage.GetCartPageTitle().Displayed);
        }

    }
}
