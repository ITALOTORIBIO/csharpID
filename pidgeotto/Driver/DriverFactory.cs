using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Driver
{
    public class DriverFactory
    {
		public Driver genericDriver;

		public void getDriver(String browser)
		{
			switch (browser)
			{

				case "chrome":
					genericDriver = new DriverChrome();
					break;
				default:
					genericDriver = null;
					break;
			}
			genericDriver.instanceDriver();
		}

		public void tearDown()
		{
			genericDriver.freeDriver();
		}

		public WebDriver driver()
		{
			return genericDriver.returnDriver();
		}
	}
}
