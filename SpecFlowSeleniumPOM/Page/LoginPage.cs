using OpenQA.Selenium;
using SpecFlowSeleniumPOM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumPOM.Page
{
    public class LoginPage : BasePage
    {
        #region // Locators

        //public IWebElement txtUserName => FindElement(By.Name("UserName"));
        private readonly By loginLocator        = By.Name("UserName");
        private readonly By passwordLocator     = By.Name("Password");        
        private readonly By loginButtonLocator  = By.XPath("//input[@value='Login']");
        //private readonly By loginButtonLocator  = By.Name("Login");
        #endregion

        #region // Constructor
        public LoginPage(IWebDriver driver) : base(driver) {}
        #endregion

        #region // Methods

        public void GoToLoginPage(String url)
        {
            GoToPage(url);
        }

        public void FillLogin(string username, string password)
        {
            //txtUserName.SendKeys(username);
            IsDisplayed(loginLocator, new TimeSpan(0, 1, 0));
            SendKeys(username, loginLocator);
            SendKeys(password, passwordLocator);
        }

        public EAPage ClickLogin()
        {
            Click(loginButtonLocator, new TimeSpan(0,1,0));
            return new EAPage(Driver);
        }
        #endregion
    }
}
