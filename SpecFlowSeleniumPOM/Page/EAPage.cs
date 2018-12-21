using OpenQA.Selenium;
using SpecFlowSeleniumPOM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSeleniumPOM.Page
{
    public class EAPage : BasePage
    {
        #region // Locators
        private readonly By saveButtonLocator = By.Name("Save");
        #endregion

        #region // Constructor
        public EAPage(IWebDriver driver) : base(driver) { }
        #endregion

        #region // Methods
        public bool IsOnEAPage()
        {
            return IsDisplayed(saveButtonLocator, new TimeSpan(0, 1, 0));
        }
        #endregion
    }
}
