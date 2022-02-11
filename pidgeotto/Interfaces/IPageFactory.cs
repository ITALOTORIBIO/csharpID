using pidgeotto.Interfaces.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Interfaces
{
    public interface IPageFactory
    {
        ILoginPage LoginPage();
        IHomePage HomePage();
    }
}
