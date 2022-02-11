
using Autofac;
using OpenQA.Selenium;
using pidgeotto.Driver;
using pidgeotto.Interfaces;
using pidgeotto.Pages;
using pidgeotto.Resources;
using pidgeotto.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Test.Base
{
    public class WebTest 
	{
		public IWebDriver driver;
		DriverFactory driverFactory;
		protected IPageFactory Page;
		/*HomePage home;
		SearchPage search;*/

		public WebTest()
		{
			driverFactory = new DriverFactory();
			driverFactory.getDriver(Resource1.browser);
			driver = driverFactory.driver();
		

			ContainerBuilder container = new ContainerBuilder().Register(driver);
			Page = new pidgeottoPageFactory(container.Build());

			/*home = new HomePage(driver);
			search = new SearchPage(driver);*/
		}

		public void tearDown()
		{
			driverFactory.tearDown();
		}
	}
}
