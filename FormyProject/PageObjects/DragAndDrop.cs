using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class DragAndDrop : IPage
    {
        private readonly IWebDriver _driver;

        public DragAndDrop(IWebDriver driver)
        {
            _driver = driver;
        }
        [CacheLookup]
        private readonly By _pageLogo = By.Id("logo");
        [CacheLookup]
        private readonly By _image = By.CssSelector("#image");
        [CacheLookup]
        private readonly By _box = By.CssSelector("#box");

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/dragdrop");
        }

        private Actions Actions()
        {
            return new Actions(_driver);
        }

        public void DragDrop()
        {
            Actions().DragAndDrop(_driver.FindElement(_image),_driver.FindElement(_box)).Build().Perform();
        }
    }
}
