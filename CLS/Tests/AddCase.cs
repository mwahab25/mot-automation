using System;
using Framework.Selenium;
using NUnit.Framework;
using Tests.Base;
using CLS.Pages;

namespace Tests
{
    [TestFixture, Parallelizable]
    public class AddCase : TestBase
    {
        [Test, Parallelizable, Category("support")]
        public void Game_service_online()
        {
            Pages.Goto();
            //Pages.Support.Goto();
            //Pages.ServiceStatus.Goto();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Game"));
        }

        [Test, Parallelizable, Category("support")]
        public void Client_service_online()
        {
            Pages.Goto();
            //Pages.Support.Goto();
            //Pages.ServiceStatus.Goto();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Client"));
        }

        [Test, Parallelizable, Category("support")]
        public void Store_service_online()
        {
            Pages.Goto();
            //Pages.Support.Goto();
            //Pages.ServiceStatus.Goto();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Store"));
        }

        [Test, Parallelizable, Category("support")]
        public void Website_service_online()
        {
            Pages.Goto();
            //Pages.Support.Goto();
            //Pages.ServiceStatus.Goto();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Website"));
        }
    }
}
