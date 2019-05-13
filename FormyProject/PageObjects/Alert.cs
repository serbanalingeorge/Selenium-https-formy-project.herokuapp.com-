using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class Alert : IPage
    {
        private readonly IWebDriver _driver;

        public Alert(IWebDriver driver)
        {
            _driver = driver;
        }
        [CacheLookup]
        private readonly By _pageLogo = By.Id("logo");
        [CacheLookup]
        private readonly By _alertButton = By.Id("alert-button");

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void OpenAlert()
        {
           _driver.FindElement(_alertButton).Click();
        }

        public void CloseAlert()
        {
            var alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/switch-window");
        }
    }
}
