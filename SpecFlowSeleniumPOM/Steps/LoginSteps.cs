using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowSeleniumPOM.Base;
using SpecFlowSeleniumPOM.Page;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumPOM.Steps
{
    [Binding]
    public class LoginSteps : StepBase
    {        
        private LoginPage loginPage;
        private EAPage EAPage;

        [Given(@"I have navigated to my applicaton")]
        public void GivenIHaveNavigatedToMyApplicaton()
        {
            loginPage = new LoginPage(driver);
            loginPage.GoToPage("http://executeautomation.com/demosite/Login.html");
        }
        
        [Given(@"I typed the (.*) and (.*)")]
        public void GivenITypedTheUsernameAndPassword(string username, string password)
        {
            loginPage.FillLogin(username, password);
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            EAPage = loginPage.ClickLogin();
        }

        [Then(@"I should see the EA page")]
        public void ThenIShouldSeeTheEAPage()
        {
            //EAPage = new EAPage(driver);
            Assert.IsTrue(EAPage.IsOnEAPage(), "The EA page should be shown but it isn't.");
         
        }
    }
}
