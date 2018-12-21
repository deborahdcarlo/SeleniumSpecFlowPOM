using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumPOM.Base
{    
    public class StepBase
    {
        public IWebDriver driver;
        
        [BeforeScenario]
        public void BeforeTestRun()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
