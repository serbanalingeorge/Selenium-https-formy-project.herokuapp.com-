﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class RadioButton : IPage
    {
        private readonly IWebDriver _driver;

        public RadioButton(IWebDriver driver)
        {
            _driver = driver;
        }
        [CacheLookup]
        private readonly By _pageLogo = By.Id("logo");
        [CacheLookup]
        private readonly By _radioButton1 = By.Id("radio-button-1");
        [CacheLookup]
        private readonly By _radioButton2 = By.CssSelector("input[value='option2']");
        [CacheLookup]
        private readonly By _radioButton3 = By.XPath("//div[3]/input");
        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/radiobutton");
        }

        public void ClickButton(string whichButton)
        {
            switch (whichButton)
            {
                case "1":
                    _driver.FindElement(_radioButton1).Click();
                    break;
                case "2":
                    _driver.FindElement(_radioButton2).Click();
                    break;
                case "3":
                    _driver.FindElement(_radioButton3).Click();
                    break;
                default:
                    _driver.FindElement(_radioButton1).Click();
                    break;
            }
        }
    }
}
