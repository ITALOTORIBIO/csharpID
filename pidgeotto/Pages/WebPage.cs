using Microsoft.Practices.Unity;
using OpenQA.Selenium;
using pidgeotto.Common;
using pidgeotto.Interfaces.WebActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Pages
{
    public class WebPage
    {
        public ISeleniumUtils _seleniumUtils;

        public WebPage(ISeleniumUtils seleniumUtils)
        {
            _seleniumUtils = seleniumUtils;
        }

    }
}
