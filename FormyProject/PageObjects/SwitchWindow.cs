using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;

namespace FormyProject.PageObjects
{
    public class SwitchWindow
    {
        private IWebDriver driver;
        

        [FindsBy(How = How.Id, Using = "logo")]
        private IWebElement PageLogo { get; set; }

        [FindsBy(How = How.Id, Using = "new-tab-button")]
        private IWebElement NewWindow { get; set; }


        public bool IsAt()
        {
            return PageLogo.Displayed;
        }

        public void OpenNewWindow(int newWidows)
        {
            NewWindow.Click();
        }

        public void SwitchToFirstWindow()
        {
            var originalHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(originalHandle);
        }
    }
}
