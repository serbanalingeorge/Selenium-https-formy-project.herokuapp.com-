using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class CheckBox : IPage
    {
        private readonly IWebDriver _driver;

        public CheckBox(IWebDriver driver)
        {
            _driver = driver;
        }
        [CacheLookup]
        private readonly By _pageLogo = By.Id("logo");
        [CacheLookup]
        private readonly By _checkBox1 = By.Id("checkbox-1");
        [CacheLookup]
        private readonly By _checkBox2 = By.Id("checkbox-2");
        [CacheLookup]
        private readonly By _checkBox3 = By.Id("checkbox-3");

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/checkbox");
        }

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void SelectBox1()
        {
            _driver.FindElement(_checkBox1).Click();
        }

        public void SelectBox2()
        {
            _driver.FindElement(_checkBox2).Click();
        }

        public void SelectBox3()
        {
            _driver.FindElement(_checkBox3).Click();
        }


    }
}
