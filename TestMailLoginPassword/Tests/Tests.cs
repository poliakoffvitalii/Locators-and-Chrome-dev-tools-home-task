using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SeleniumExtras.PageObjects;


namespace Locators.Tests
{

    [TestClass]
    public class Part : BaseTest
    {
        private static long DEFAULT_TIMEOUT = 20;

        [TestMethod]
        [DataRow("boriszimmerman6", "12a34b56", "polvit@meta.ua", "Good morning", "Have a nice day")]

        public void WebDriverHomeTask(string login, string pass, string email, string topic, string text)
        {
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetIdField());
            getHomePage().InputLogin(login);
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetPassField());
            getHomePage().InputPass(pass);
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetWriteLetterBotton());
            getHomePage().ClickWriteLetterBotton();
            getHomePage().WaitClickabilityOfElement(DEFAULT_TIMEOUT, getHomePage().GetRecipient());
            getHomePage().InputRecipient(email);
            getHomePage().WaitLittle(DEFAULT_TIMEOUT);
            getHomePage().InputSubject(topic);
            getHomePage().WaitLittle(DEFAULT_TIMEOUT);
            getHomePage().InputText(text);
            getHomePage().WaitLittle(DEFAULT_TIMEOUT);
            getHomePage().ClickSendBotton();
            getHomePage().WaitLittle(DEFAULT_TIMEOUT);
        }
    }
}
