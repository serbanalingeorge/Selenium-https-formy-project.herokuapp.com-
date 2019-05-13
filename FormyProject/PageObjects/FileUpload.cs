using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public class FileUpload : IPage
    {
        private readonly IWebDriver _driver;

        public FileUpload(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _pageLogo = By.Id("logo");
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
