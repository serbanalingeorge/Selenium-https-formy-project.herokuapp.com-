using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace FormyProject.Browser
{
    public class ChromeDriverManager : DriverManager
    {
        protected override void CreateWebDriver()
        {
            var options = new ChromeOptions();
            Driver = new ChromeDriver(options);
        }
    }
}
