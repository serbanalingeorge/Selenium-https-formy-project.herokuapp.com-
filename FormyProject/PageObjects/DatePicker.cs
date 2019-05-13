using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public class DatePicker : IPage
    {
        private readonly IWebDriver _driver;

        public DatePicker(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _pageLogo = By.Id("logo");
        private readonly By _dateField = By.CssSelector("#datepicker");
        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/datepicker");
        }

        public void Input(string date)
        {
            _driver.FindElement(_dateField).SendKeys(date);
            _driver.FindElement(_dateField).SendKeys(Keys.Return);
        }
    }
}
