using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.Browser
{
    public abstract class DriverManager
    {
        protected IWebDriver Driver;
        protected abstract void CreateWebDriver();

        public void QuitWebDriver()
        {
            if (null != Driver )
            {
                Driver.Quit();
                Driver = null;
            }
        }

        public IWebDriver GetWebDriver()
        {
            if (null == Driver)
            {
                CreateWebDriver();
            }

            return Driver;
        }
    }
}
