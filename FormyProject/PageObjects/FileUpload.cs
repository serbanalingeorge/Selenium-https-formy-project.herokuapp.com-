using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class FileUpload : IPage
    {
        private readonly IWebDriver _driver;

        public FileUpload(IWebDriver driver)
        {
            _driver = driver;
        }
        [CacheLookup]
        private readonly By _pageLogo = By.Id("logo");
        [CacheLookup]
        private readonly By _uploadField = By.CssSelector("#file-upload-field");
        private const string File = "file-to-upload.png";

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/fileupload");
        }

        public void Perform()
        {
            UploadField().SendKeys(File);
        }

        private IWebElement UploadField()
        {
            return _driver.FindElement(_uploadField);
        }
    }
}
