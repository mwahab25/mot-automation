using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class AddCasePage
    {
        public readonly AddCasePageMap Map;

        public AddCasePage()
        {
            Map = new AddCasePageMap();
        }

    }

    public class AddCasePageMap
    {
        public Element ExploreMenu => Driver.FindElement(By.CssSelector(".riotbar-left-content"));

        public Element SupportLink => Driver.FindElement(By.CssSelector("[data-riotbar-link-id='support']"));
    }
}
