using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;

namespace FormyProject.Browser
{
    public class FirefoxDriverManager : DriverManager
    {
        protected override void CreateWebDriver()
        {
            var options = new FirefoxOptions();
            Driver = new FirefoxDriver(options);
        }
    }
}
