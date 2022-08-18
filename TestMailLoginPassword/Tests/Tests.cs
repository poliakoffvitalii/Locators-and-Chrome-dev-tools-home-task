using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;


namespace WebDriverHomeTask.Tests
{

    [TestClass]
    public class Part : BaseTest
    {
        private static long DEFAULT_TIMEOUT = 40;

        [TestMethod]
        [DataRow("dog")]

        public void WebDriverHomeTask(string Item)
        {
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetImageBotton());
            getHomePage().ClickImageBotton();
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetSearchIcon());
            getHomePage().InputSearch(Item);
            getHomePage().WaitLittle(DEFAULT_TIMEOUT);
            getHomePage().CheckResult();
        }
    }
}
