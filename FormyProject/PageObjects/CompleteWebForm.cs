using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public class CompleteWebForm : IPage
    {
        private readonly IWebDriver _driver;

        public CompleteWebForm(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _firstName = By.CssSelector("#first-name");
        private readonly By _lastName = By.CssSelector("#last-name");
        private readonly By _jobTitle = By.CssSelector("#job-title");
        private readonly By _radioButton1 = By.CssSelector("#radio-button-1");
        private readonly By _checkBox1 = By.CssSelector("#checkbox-1");
        private readonly By _dropDownButton = By.CssSelector("option[value='1']");
        private readonly By _datePicker = By.CssSelector("#datepicker");
        private readonly By _submitButton = By.CssSelector(".btn.btn-lg.btn-primary");
        private readonly By _expectedTitle = By.XPath("/html/body/div/h1");

        public void SubmitForm(string first, string last, string job, string date)
        {
            _driver.FindElement(_firstName).SendKeys(first);
            _driver.FindElement(_lastName).SendKeys(last);
            _driver.FindElement(_jobTitle).SendKeys(job);
            _driver.FindElement(_radioButton1).Click();
            _driver.FindElement(_checkBox1).Click();
            _driver.FindElement(_dropDownButton).Click();
            _driver.FindElement(_datePicker).SendKeys(date);
            _driver.FindElement(_datePicker).SendKeys(Keys.Return);
            _driver.FindElement(_submitButton).Click();
        }

        public bool IsAt()
        {
            return _driver.FindElement(_expectedTitle).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/form");
        }
        public void CreateImplicitWait(int seconds)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
