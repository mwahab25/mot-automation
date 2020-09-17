using System;
using Framework.Selenium;

namespace CLS.Pages
{
    public static class Pages
    {
        [ThreadStatic] public static ViewCasesPage Home;

        [ThreadStatic] public static AddCasePage Support;


        public static void Init()
        {
            Home = new ViewCasesPage();
            Support = new AddCasePage();
        }

        public static void Goto()
        {
            Driver.Goto("https://nexus.leagueoflegends.com/en-us/esports/");
            Driver.Wait.Until(driver => Home.Map.PlayNowSignupButton.Displayed);
        }
    }
}
