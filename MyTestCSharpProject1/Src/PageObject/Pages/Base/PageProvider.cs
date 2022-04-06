using System;
using MyTestCSharpProject1.Src.Driver;
using OpenQA.Selenium;

namespace MyTestCSharpProject1.Src.PageObject.Pages.Base
{
    public class PageProvider
    {
        private DriverProvider provider;

        public void Quit()
        {
            provider.Quit();
        }

        public IWebDriver SetDriver()
        {
            if (provider == null)
            {
                provider = new DriverProvider();
            }
            return provider.GetDriver();
        }


        public T InitPage<T>()
        {
            object[] param = { SetDriver() };
            return (T) Activator.CreateInstance(typeof(T), param);
        }
    }
}
