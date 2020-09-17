using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class AddCasePage : PageBase
    {
        public readonly AddCasePageMap Map;

        public AddCasePage()
        {
            Map = new AddCasePageMap();
        }

        public AddCasePage Goto()
        {
            CLSMenu.AddCasesLink.Click();
            return this;
        }

        public void SaveCaseWithoutFill()
        {
           Map.SaveCaseButton.Click();   
        }


    }

    public class AddCasePageMap
    {
        public Element SaveCaseButton => Driver.FindElement(By.Id("submit"));
    }
}
