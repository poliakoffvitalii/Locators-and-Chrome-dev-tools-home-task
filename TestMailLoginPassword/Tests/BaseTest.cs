﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Locators.Pages;


namespace Locators.Tests
{
    public class BaseTest
    {
        readonly String test_url = "https://www.gmail.com/";
        IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Initialize()
        {
            getDriver().Url = test_url;
            getDriver().Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            getDriver().Close();
        }

        public IWebDriver getDriver()
        {
            return driver;
        }
        public HomePage getHomePage()
        {
            return new HomePage(getDriver());
        }
    }
}
