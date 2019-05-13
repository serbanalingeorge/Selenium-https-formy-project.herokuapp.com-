using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using FormyProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace FormyProject.pages
{
    public class HomePage : IPage
    {
       
        private readonly IWebDriver _driver;

        private readonly By _pageLogo = By.Id("logo");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/");
        }

   


       
    }
}
