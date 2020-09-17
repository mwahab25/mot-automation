using Framework.Selenium;
using OpenQA.Selenium;

namespace CLS.Pages
{
    public class CLSMenu
    {
        public Element AddCaseLink => Driver.FindElement(By.CssSelector(".item.link.watch"), "Watch Nav Link");
        public Element ViewCasesLink => Driver.FindElement(By.CssSelector(".item.link.schedule"), "Schedule Nav Link");
    }
}
