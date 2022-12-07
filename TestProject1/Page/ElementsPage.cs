using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject1.Base;

namespace TestProject1.Page
{
	class ElementsPage : BasePage
	{
		By anyElement = By.CssSelector("#app > div > div > div.row > div:nth-child(1) > div > div > div:nth-child(1) > div > ul > :nth-child(1)");

		public ElementsPage(IWebDriver driver) : base(driver)
		{
		}

		public ElementsPage CheckAnyElement()
		{
			CheckElementWithDynamicWait(anyElement);
			return this;
		}
	}
}
