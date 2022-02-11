using Autofac;
using pidgeotto.Interfaces;
using pidgeotto.Interfaces.Pages;
using pidgeotto.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Test.Base
{
    public class pidgeottoPageFactory : IPageFactory
    {
        private readonly IContainer _container;
        /*private IHomePage _homePage;*/
        private ILoginPage? _loginPage;
        private IHomePage? _homePage;

        public pidgeottoPageFactory(IContainer container)
        {
            _container = container;
        }

        public ILoginPage LoginPage()
        {
            if (_loginPage == null)
                _loginPage = ResolvePage<ILoginPage>();
            return _loginPage;
        }

        public IHomePage HomePage()
        {
            if (_homePage == null)
                _homePage = ResolvePage<IHomePage>();
            return _homePage;
        }

        private Interfaces ResolvePage<Interfaces>()
        {
            var page = _container.Resolve<IEnumerable<Interfaces>>();
            var _page  = page.FirstOrDefault();
            return _page;
        }
    }
}
