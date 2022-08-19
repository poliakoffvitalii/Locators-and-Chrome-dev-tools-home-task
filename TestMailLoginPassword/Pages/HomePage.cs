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
using System.Threading;

namespace Locators.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "identifierId")]
        private readonly IWebElement IdField;

        [FindsBy(How = How.Name, Using = "password")]
        private readonly IWebElement PassField;

        [FindsBy(How = How.XPath, Using = "//div[@class='T-I T-I-KE L3']")]
        private readonly IWebElement WriteLetterBotton;

        [FindsBy(How = How.CssSelector, Using = "div.afx input")]
        private readonly IWebElement Recipient;

        [FindsBy(How = How.XPath, Using = "//input[@name='subjectbox']")]
        private readonly IWebElement Subject;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Текст повідомлення']")]
        private readonly IWebElement Text;

        [FindsBy(How = How.XPath, Using = "//div[contains(@data-tooltip,'Надіслати')]")]
        private readonly IWebElement SendBotton;
        
        public IWebElement GetIdField()
        {
            return IdField;
        }
        public IWebElement GetPassField()
        {
            return PassField;
        }

        public void InputLogin(string Login)
        {
            IdField.Clear();
            IdField.SendKeys(Login + Keys.Enter);
        }
        public void InputPass(string Pass)
        {
            PassField.Clear();
            PassField.SendKeys(Pass + Keys.Enter);
        }
        public IWebElement GetWriteLetterBotton()
        {
            return WriteLetterBotton;
        }
        public void ClickWriteLetterBotton()
        {
            WriteLetterBotton.Click();
        }
        public IWebElement GetRecipient()
        {
            return Recipient;
        }
        public void InputRecipient(string Email)
        {
            Recipient.SendKeys(Email);
        }
        public IWebElement GetSubject()
        {
            return Subject;
        }
        public void InputSubject(string Topic)
        {
            Subject.SendKeys(Topic);
        }
        public IWebElement GetText()
        {
            return Text;
        }
        public void InputText(string Textmess)
        {
            Text.SendKeys(Textmess);
        }
        public IWebElement GetSendBotton()
        {
            return SendBotton;
        }
        public void ClickSendBotton()
        {
            Thread.Sleep(3000);
            SendBotton.Click();
            Thread.Sleep(3000);
        }
    }
}
