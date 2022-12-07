using NUnit.Framework;
using TestProject1.Base;
using TestProject1.Page;

namespace TestProject1.Test
{
	class ProductionTest : BaseTest
	{
        MainPage mainPage;

        [Test]
        public void Test1()
        {
            mainPage = new MainPage(GetDriver());
            mainPage.OpenBrowserAndClickElements().callElementsPage().CheckAnyElement();

        }

    }
}
