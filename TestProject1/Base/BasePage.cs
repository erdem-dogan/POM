using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1.Page;

namespace TestProject1.Base
{
	class BasePage : BaseTest
	{
		protected static int DEFAULT_DYNAMIC_WAIT_AMOUNT = 60;
		protected static int DEFAULT_MAX_ITERATION_COUNT = 150;
		protected static int DEFAULT_MILLISECONDS_WAIT_AMOUNT = 200;
		WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(DEFAULT_DYNAMIC_WAIT_AMOUNT));
		IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

		public BasePage(IWebDriver driver)
		{
			BaseTest.driver = driver;
		}

		private bool isDisplayed(IWebElement element)
		{
			return element.Displayed;
		}

		public IWebElement FindElement(By by)
		{
			return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
		}

		public IWebElement FindElementWithoutWait(By by)
		{
			return driver.FindElement(by);
		}

		public void GoToURL(String Url)
		{
			driver.Navigate().GoToUrl(Url);
		}

		public void ClickelementWithJS(By by)
		{
			IWebElement element = FindElement(by);
			executor.ExecuteScript("arguments[0].click();", element);
		}

		public void Click(By by)
		{
			IWebElement element = FindElement(by);
			element.Click();
		}

		public void WaitByMilliSeconds(long milliseconds)
		{
			System.Threading.Thread.Sleep((int)milliseconds);
		}

		public void WaitBySeconds(int seconds)
		{
			System.Threading.Thread.Sleep(seconds * 1000);
		}

		public void CheckElementWithDynamicWait(By by)
		{
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
		}

		public ElementsPage callElementsPage()
		{
			return new ElementsPage(driver);
		}


	}
}
