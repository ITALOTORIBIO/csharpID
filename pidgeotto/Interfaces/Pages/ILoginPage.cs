using pidgeotto.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Interfaces.Pages
{
    public interface ILoginPage
    {
        LoginPage goLoginPage();
        LoginPage insertData();
        
    }
}
