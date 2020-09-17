using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class ViewCasesPage : PageBase
	{
		public readonly ViewCasesPageMap Map;

		public ViewCasesPage()
		{
			Map = new ViewCasesPageMap();
		}
	}

	public class ViewCasesPageMap
	{
        public Element PlayNowSignupButton => Driver.FindElement(By.CssSelector("[data-riotbar-link-id='signup']"));
	}
}
