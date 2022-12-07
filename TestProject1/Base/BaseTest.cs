using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using TestProject1.Utility;

namespace TestProject1.Base
{
	class BaseTest
	{
		protected static IWebDriver driver;
        protected static Browser browser = new Browser();
        [SetUp]
        public void Setup()
        {
            if (browser.browserName == "chrome")
            {
                driver = new ChromeDriver(browser.ChromeOptions());
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
			}
			else if (browser.browserName == "edge")
			{
                driver = new EdgeDriver(browser.EdgeOptions());
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(1);
            }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        public static IWebDriver GetDriver() 
        {
            return driver;
        }

    }
}
