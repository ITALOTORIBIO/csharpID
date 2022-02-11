using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Driver
{
    public abstract class Driver
    {
        protected WebDriver driver;
                
        public abstract void instanceDriver();

        public abstract void freeDriver();

        public abstract WebDriver returnDriver();
    }
}
