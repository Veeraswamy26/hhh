using finalapp.utility;
using october.xpaths;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace october.StepDefinitions
{
    public class steps:Class1
    {

        [Given(@"display splash screen")]
        public void GivenDisplaySplashScreen()
        {
            
        }

        [When(@"click on get next")]
        public void WhenClickOnGetNext()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(xpath.Next)).Click();
            driver.FindElement(By.XPath(xpath.Next)).Click();
           
        }

        [Then(@"display login page")]
        public void ThenDisplayLoginPage()
        {
            driver.FindElement(By.XPath(xpath.GetStarted)).Click();
            Thread.Sleep(1000);
        }
        [Given(@"click on fa cebook or google")]
        public void GivenClickOnFaCebookOrGoogle()
        {
            Thread.Sleep(6000);
            homepage();
            driver.FindElement(By.XPath(xpath.face)).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element is visible (adjust XPath if needed)
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath.ok)));

            // Perform actions on the element
            element.Click();
// driver.FindElement(By.XPath(xpath.ok)).Click();
        
            driver.FindElement(By.XPath(xpath.gmail)).Click();
           
        }

        [When(@"if userexists  login or signup when new mail or number is detected")]
        public void WhenIfUserexistsLoginOrSignupWhenNewMailOrNumberIsDetected()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element is visible (adjust XPath if needed)
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath.gmailacc)));

            // Perform actions on the element
            element.Click();
            
            Thread.Sleep(10000);

        }

        [Then(@"if login then l og out")]
        public void ThenIfLoginThenLOgOut()
        {
            logout();
        }

        [Given(@"api end point and authorization")]
        public void GivenApiEndPointAndAuthorization()
        {
            Thread.Sleep(1000);
            homepage();
            
        }

        [When(@"display respective scereen")]
        public void WhenDisplayRespectiveScereen()
        {
            TestMobileNumberInResponse();
        }

        [Then(@"logout from the page")]
        public void ThenLogoutFromThePage()
        {
            logout();
        }
        [Given(@"home page is displayed")]
        public void GivenHomePageIsDisplayed()
        {
            Thread.Sleep(1000);
            homepage();
            TestMobileNumberInResponse();
        }

        [When(@"click on set pick up and drop off")]
        public void WhenClickOnSetPickUpAndDropOff()
        {
            bookingflow();
        }

    }
}



