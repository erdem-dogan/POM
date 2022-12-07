using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;

namespace TestProject1.Utility
{
	class Browser
	{
		ChromeOptions chromeOptions;
		EdgeOptions edgeOptions;
		public String browserName = "chrome";

		public ChromeOptions ChromeOptions()
		{
			chromeOptions = new ChromeOptions();
			chromeOptions.AddArguments("start-maximized");
			chromeOptions.AddArguments("lang=tr");
			chromeOptions.AddArguments("disable-notifications");
			Dictionary<string, object> prefs = new Dictionary<string, object>
			{
				{ "profile.default_content_setting_values.notifications", 2 }
			};
			chromeOptions.AddLocalStatePreference("prefs", prefs);
			Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\testinium\Desktop\chromedriver.exe");
			return chromeOptions;
		}

		public EdgeOptions EdgeOptions()
		{
			edgeOptions = new EdgeOptions();
			edgeOptions.AddArguments("start-maximized");
			edgeOptions.AddArguments("lang=tr");
			edgeOptions.AddArguments("disable-notifications");
			Dictionary<string, object> prefs = new Dictionary<string, object>
			{
				{ "profile.default_content_setting_values.notifications", 2 }
			};
			edgeOptions.AddLocalStatePreference("prefs", prefs);
			Environment.SetEnvironmentVariable("webdriver.edge.driver", @"C:\Users\testinium\Desktop\msedgedriver.exe");
			return edgeOptions;
		}
	}
}
