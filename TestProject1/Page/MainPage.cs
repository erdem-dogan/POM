using OpenQA.Selenium;
using TestProject1.Base;

namespace TestProject1.Page
{
	class MainPage : BasePage
	{
		By elementsButton = By.CssSelector("div.category-cards > :nth-child(1) > div > :nth-child(3)");

		public MainPage(IWebDriver driver) : base(driver)
		{
			
		}

		public MainPage OpenBrowserAndClickElements() 
		{
			GoToURL("https://demoqa.com/");
			ClickelementWithJS(elementsButton);
			return this;
		}
	}
}
