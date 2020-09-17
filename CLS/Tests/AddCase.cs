﻿using System;
using Framework.Selenium;
using NUnit.Framework;
using Tests.Base;
using CLS.Pages;

namespace Tests
{
    [TestFixture, Parallelizable]
    public class AddCase : TestBase
    {
        [Test, Parallelizable, Category("AddCase")]
        public void Save_case_without_fill_fields()
        {
            Pages.Goto();
            Pages.AddCase.Goto();
            Pages.AddCase.SaveCaseWithoutFill();
            //Assert.That(Pages.ServiceStatus.ServiceOnline("Game"));
        }

        [Test, Parallelizable, Category("AddCase")]
        public void Save_case_with_fill_all_fields()
        {
            Pages.Goto();
            Pages.AddCase.Goto();
        }
    }
}
