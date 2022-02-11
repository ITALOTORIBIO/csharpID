using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using pidgeotto.Interfaces.WebActions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pidgeotto.Common
{
    public class SeleniumUtils: ISeleniumUtils
    {
        private readonly IWebDriver _driver;
        WebDriverWait wait;
        public SeleniumUtils(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
        }

		public void navigateToUrl(string url)
        {
			_driver.Navigate().GoToUrl(url);
			Thread.Sleep(1000);
        }

        public string getText(By element)
        {            
            IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
            return webElement.Text;
        }

		public void click(By element)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			webElement.Click();
		}

		public void click(String Xpath)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(By.XPath(Xpath)));
			webElement.Click();
		}

		public void setText(By element, String text)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			webElement.SendKeys(text);
		}

		public void mouseOver(String Xpath)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(By.XPath(Xpath)));
			Actions builder = new Actions(_driver);
			builder.MoveToElement(webElement).Perform();
		}

		public void mouseOver(By element)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			Actions builder = new Actions(_driver);
			builder.MoveToElement(webElement).Perform();
		}


		public IList<IWebElement> getElements(By elements)
		{
			IList<IWebElement> webElements = wait.Until(_driver => _driver.FindElements(elements));
            return webElements;
		}
		

		public void waitWebElementClickableBy(By element)
		{
			wait.Until(ExpectedConditions.ElementToBeClickable(element));
		}
		public void waitWebElementVisibleBy(By element)
		{
			wait.Until(ExpectedConditions.ElementIsVisible(element));
		}
		public void waitWebElementsVisibleBy(By elements)
		{
			wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elements));
		}

		/* ### Asserts ### */
		public void AssertElementPresent(WebElement element)
		{
			Xunit.Assert.True(element.Displayed);
		}

		public void AssertElementPresent(By element)
		{
			waitWebElementVisibleBy(element);
			Xunit.Assert.True(_driver.FindElement(element).Displayed);
		}
	}
}
