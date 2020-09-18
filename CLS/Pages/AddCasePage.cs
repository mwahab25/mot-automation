using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class AddCasePage : PageBase
    {
        public readonly AddCasePageMap Map;

        public AddCasePage Goto()
        {
            CLSMenu.GotoDeckPage();
            return this;
        }

        public AddCasePage()
        {
            Map = new AddCasePageMap();
        }

        public void SaveCaseWithoutFill()
        {
           Map.SaveCaseButton.Click();   
        }

         public void ClickCard(string name)
        {
          // Map.Card(name).Click();
           Map.StageByName(name).Click();
        }

    }

    public class AddCasePageMap
    {
        public Element SaveCaseButton => Driver.FindElement(By.Id("submit"));

        public Element Card(string name) => Driver.FindElement(By.CssSelector($"a[href*='{name}']"), $"Card: {name}");

        public Element StageByName(string name) => Driver.FindElement(
            by: By.XPath($"//div[@class='stage-option' and text()='{name}']"),
            elementName: $"{name} Stage");
    }
}
