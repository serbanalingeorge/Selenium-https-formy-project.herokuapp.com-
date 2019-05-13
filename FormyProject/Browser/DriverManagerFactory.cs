using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormyProject.Browser
{
    public class DriverManagerFactory
    {
        public static DriverManager GetDriverManager(DriverType type)
        {
            DriverManager driverManager = null;

            switch (type)
            {
                case DriverType.Chrome:
                    driverManager = new ChromeDriverManager();
                    break;
                case DriverType.Firefox:
                    driverManager = new FirefoxDriverManager();
                    break;
            }

            return driverManager;
        }
    }
}
