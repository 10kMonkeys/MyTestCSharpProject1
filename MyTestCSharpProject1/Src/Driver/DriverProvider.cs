
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace MyTestCSharpProject1.Src.Driver
{
    public class DriverProvider
    {
        private IWebDriver driver;
        private readonly DriverType driverType;

        public DriverProvider()
        {
            var driverType = Environment.GetEnvironmentVariable("Browser");
            this.driverType = (DriverType) Enum.Parse(typeof(DriverType), driverType);
        }

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                InitDriver();
            }

            return driver;
        }

        public void Quit()
        {
            driver.Quit();
        }

        public IWebDriver InitDriver()
        {
            switch (driverType)
            {
                case DriverType.FIREFOX:
                    driver = new FirefoxDriver();
                    break;
                case DriverType.CHROME:
                    driver = new ChromeDriver();
                    break;
                case DriverType.SAFARI:
                    driver = new SafariDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            return driver;
        }
    }

    public enum DriverType
    {
        FIREFOX,
        CHROME,
        SAFARI
    }
    
}
