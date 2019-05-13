using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public class DropDown : IPage
    {
        private readonly IWebDriver _driver;

        public DropDown(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _pageLogo = By.Id("logo");
        private readonly By _dropDownButton = By.CssSelector("#dropdownMenuButton");
        private readonly By _autocompleteOption = By.CssSelector("#autocomplete");
        private readonly By _pageTitle = By.XPath("/html/body/div[1]/h1");
        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/dropdown");
        }

        public void ClickButton()
        {
            _driver.FindElement(_dropDownButton).Click();
        }

        public void Autocomplete()
        {
            _driver.FindElement(_autocompleteOption).Click();  
        }

        public bool AssertIsTrue()
        {
            return _driver.FindElement(_pageTitle).Displayed;
        }
    }
}
