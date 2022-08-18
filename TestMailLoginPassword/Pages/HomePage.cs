using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;

namespace WebDriverHomeTask.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='gb']/div/div[1]/div/div[2]/a")]
        private readonly IWebElement ImageBotton;

        [FindsBy(How = How.XPath, Using = "//html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")]
        private readonly IWebElement InputField;

        [FindsBy(How = How.XPath, Using = "//html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/button")]
        private readonly IWebElement SearchIcon;

        [FindsBy(How = How.XPath, Using = "//*[@id='islrg']/div[1]/*/a[1]/div[1]/img")]
        private IList<IWebElement> SearchResult;

        public IWebElement GetImageBotton()
        {
            return ImageBotton;
        }

        public void ClickImageBotton()
        {
            ImageBotton.Click();
        }

        public IWebElement GetInputField()
        {
            return InputField;
        }
        public IWebElement GetSearchIcon()
        {
            return SearchIcon;
        }

        public void ClickSearchIcon()
        {
            SearchIcon.Click();
        }

        public void InputSearch(string Item)
        {
            InputField.Clear();
            InputField.SendKeys(Item);
            ClickSearchIcon();
        }
        public IList<IWebElement> GetSearchResult()
        {
            return SearchResult;
        }
        public void CheckResult()
        {
            foreach (IWebElement item in SearchResult)
            {
                Assert.IsTrue(item.GetAttribute("src").Contains("image"));
            }
        }
    }
}
