using System.Runtime.InteropServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class PageScroll
    {
        private static IWebDriver _driver;

        public PageScroll(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _fullName = By.Id("name");
        private readonly By _date = By.Id("date");

        private readonly By _pageLogo = By.Id("logo");

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/scroll");
        }

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void InputName(string name)
        {
            _driver.FindElement(_fullName).SendKeys(name);
        }

        public void InputDate(string date)
        {
            _driver.FindElement(_date).SendKeys(date);
        }
        /// <summary>
        /// Currently this method does not work
        /// </summary>
        /// TODO
        public void SelectField()
        {
            var actions = new Actions(_driver);
            actions.MoveToElement(_driver.FindElement(_fullName)).Click();

            var action = actions.Build();
            action.Perform();

        }

        public void MoveToElementForInteraction()
        {
            Js(_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _driver.FindElement(_fullName));
        }

        private static IJavaScriptExecutor Js(IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }
    }
}
