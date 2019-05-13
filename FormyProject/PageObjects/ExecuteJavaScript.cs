using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public class ExecuteJavaScript : IPage
    {
        private readonly IWebDriver _driver;

        public ExecuteJavaScript(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _pageLogo = By.Id("logo");
        private readonly By _openButton = By.CssSelector("#modal-button");
        private readonly By _closeButton = By.CssSelector("#close-button");

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/modal");
        }

        public void ClickButton()
        {
            _driver.FindElement(_openButton).Click();
        }

        public IWebElement CloseButton()
        {
            return _driver.FindElement(_closeButton);
        }

        public void MoveToElementForInteraction(IWebElement element)
        {
            Js(_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        private static IJavaScriptExecutor Js(IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }

    }
}
