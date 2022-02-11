using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Driver
{
    public class DriverChrome : Driver
    {
        public override void freeDriver()
        {
            driver.Close();
            
        }

        public override void instanceDriver()
        {
            driver = new ChromeDriver();
            
        }

        public override WebDriver returnDriver()
        {
            return driver;
            
        }


    }
}
