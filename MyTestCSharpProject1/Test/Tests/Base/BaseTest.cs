using System;
using MyTestCSharpProject1.Src.Model.Config;
using MyTestCSharpProject1.Src.PageObject.Pages.Base;
using MyTestCSharpProject1.Src.PageObject.Steps.StepsFactory;
using MyTestCSharpProject1.Src.Utils.Config;
using OpenQA.Selenium;


namespace MyTestCSharpProject1.Test.Tests.Base
{
    public class BaseTest// : IDisposable
    {
        protected IWebDriver driver;
        protected StepsFactory user;

        public BaseTest()
        {
            SetBrowser(SettingsManager.GetValueByKey(Browsers.Chrome)); // set up browser
            SetEnv(SettingsManager.GetValueByKey(Environments.ProdUsUrl)); // set up env
            //InitTest();
        }

        //private void InitTest()
        //{
        //    user = new StepsFactory(new PageProvider());
        //}

        //public void Dispose()
        //{
        //    user.pageProvider.Quit();
        //}

        private void SetBrowser(string value)
        {
            if (Environment.GetEnvironmentVariable("Browser") is null)
            {
                Environment.SetEnvironmentVariable("Browser", value);

            }
        }

        private void SetEnv(string value)
        {
            if (Environment.GetEnvironmentVariable("Env") is null)
            {
                Environment.SetEnvironmentVariable("Env", value);

            }
        }
    }
}
