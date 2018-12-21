using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumPOM.Base
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        public void GoToPage(String url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        public IList<IWebElement> FindElements(By locator)
        {
            return Driver.FindElements(locator);
        }

        public IList<IWebElement> FindElements(By locator, TimeSpan timeout)
        {
            IsDisplayed(locator, timeout);
            return FindElements(locator);
        }

        public IWebElement FindElement(By locator, TimeSpan timeout)
        {
            IsDisplayed(locator, timeout);
            return FindElement(locator);
        }

        public void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public void Click(By locator, TimeSpan timeout)
        {
            FindElement(locator, timeout).Click();
        }
        
        public void SendKeys(String inputText, By locator)
        {
            FindElement(locator).SendKeys(inputText);
        }

        public void SendKeys(String inputText, By locator, TimeSpan timeout)
        {
            IsDisplayed(locator, timeout);
            SendKeys(inputText, locator);
        }

        public Boolean IsDisplayed(By locator)
        {
            try
            {
                return FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public Boolean IsDisplayed(By locator, TimeSpan timeout)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, timeout);
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        public Boolean IsNotDisplayed(By locator, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(Driver, timeout);
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return !IsDisplayed(locator);
        }

        public Boolean IsPresent(By locator, TimeSpan timeout)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, timeout);
                wait.Until(ExpectedConditions.ElementExists(locator));
            }
            catch (TimeoutException)
            {
                return false;
            }
            return true;
        }        
    }
}
