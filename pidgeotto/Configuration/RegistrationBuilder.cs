using Autofac;
using OpenQA.Selenium;
using pidgeotto.Common;
using pidgeotto.Interfaces.Pages;
using pidgeotto.Interfaces.WebActions;
using pidgeotto.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Configuration
{
    public static class RegistrationBuilder
    {
        public static ContainerBuilder Register(this ContainerBuilder container, IWebDriver driver)
        {
            container.RegisterType<SeleniumUtils>().As<ISeleniumUtils>().WithParameter("driver", driver);

            container.RegisterType<LoginPage>().As<ILoginPage>();

            container.RegisterType<HomePage>().As<IHomePage>();

            return container;
        }
    }
}
