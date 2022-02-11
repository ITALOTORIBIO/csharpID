using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pidgeotto.Interfaces.WebActions
{
    public interface ISeleniumUtils
    {
        void navigateToUrl(string url);
        string getText(By element);
        void click(By element);
        void click(String Xpath);
        void setText(By element, String text);
        void mouseOver(String Xpath);
        void mouseOver(By element);
        IList<IWebElement> getElements(By elements);
        void waitWebElementClickableBy(By element);
        void waitWebElementVisibleBy(By element);
        void waitWebElementsVisibleBy(By elements);
        void AssertElementPresent(WebElement element);
        void AssertElementPresent(By element);
    }
}
