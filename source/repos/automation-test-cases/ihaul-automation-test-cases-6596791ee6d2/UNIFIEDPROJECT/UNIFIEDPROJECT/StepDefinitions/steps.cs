using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIFIEDPROJECT.Hooks;

namespace UNIFIEDPROJECT.StepDefinitions
{
    public class steps:Hooks1
    {
        [Given(@"the application is launched")]
        public void GivenTheApplicationIsLaunched()
        {
            
        }

        [When(@"the user provides input ""(.*)""")]
        public void WhenTheUserProvidesInput(string userInput)
        {
            if (userInput == "not interested")
            {
                ContinueAsGuest();
            }
            else if (userInput == "new number")
            {
                SignUp();
            }
            else if (userInput == "existing number")
            {
                LogIn();
            }
            else
            {
                Assert.Fail("Invalid user input");
            }
        }

        public void ContinueAsGuest()
        {
            driver.FindElementById("continue_as_guest_button_id").Click();
        }

        public void SignUp()
        {
            driver.FindElementById("signup_username_field_id").SendKeys("new_username");
            driver.FindElementById("signup_email_field_id").SendKeys("email@example.com");
            driver.FindElementById("signup_password_field_id").SendKeys("new_password");
            driver.FindElementById("signup_button_id").Click();
        }

        public void LogIn()
        {
            driver.FindElementById("username_field_id").SendKeys("existing_username");
            driver.FindElementById("password_field_id").SendKeys("existing_password");
            driver.FindElementById("login_button_id").Click();
        }

        [Then(@"the user should be able to continue as guest")]
        public void ThenTheUserShouldBeAbleToContinueAsGuest()
        {
            var guestElement = driver.FindElementById("guest_home_element_id");
            Assert.IsTrue(guestElement.Displayed);
        }

        [Then(@"the user should be directed to the signup page")]
        public void ThenTheUserShouldBeDirectedToTheSignupPage()
        {
            var signUpElement = driver.FindElementById("signup_page_element_id");
            Assert.IsTrue(signUpElement.Displayed);
        }

        [Then(@"the user completes the signup process")]
        public void ThenTheUserCompletesTheSignupProcess()
        {
            var signedUpElement = driver.FindElementById("signed_up_element_id");
            Assert.IsTrue(signedUpElement.Displayed);
        }

        [Then(@"the user should be directed to the login page")]
        public void ThenTheUserShouldBeDirectedToTheLoginPage()
        {
            var loginElement = driver.FindElementById("login_page_element_id");
            Assert.IsTrue(loginElement.Displayed);
        }

        [Then(@"the user completes the login process")]
        public void ThenTheUserCompletesTheLoginProcess()
        {
            var loggedInElement = driver.FindElementById("logged_in_element_id");
            Assert.IsTrue(loggedInElement.Displayed);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
    