using pidgeotto.Test.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace pidgeotto.Test.PageTest
{
    public class HomeTest : WebTest
    {
        [Fact]
        public void Test1()
        {
            Page.LoginPage().goLoginPage().insertData();
            Page.HomePage().createNB();
        }
    }
}
