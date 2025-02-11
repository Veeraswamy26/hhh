
using iHaulautomation.Hooks;
using iHaulautomation.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHaulautomation.StepDefinitions
{
    public class i_haulsteps: bookinghaul
    {
        [Given(@":launch app")]
        public void GivenLaunchApp()
        {
            Thread.Sleep(1000);
        }

        [Then(@": click on the Next")]
        public void ThenClickOnTheNext()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": click on the button get started")]
        public void ThenClickOnTheButtonGetStarted()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
           
        }
        [Then(@"do the action")]
        public void ThenDoTheAction()
        {
            Thread.Sleep(1000);
           AndroidElement logins = driver.FindElementByXPath("//android.widget.EditText");
            logins.Click();
            logins.SendKeys("9441474329");
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
           
        }
        [Then(@"do the login")]
        public void ThenDoTheLogin()
        {
            Thread.Sleep(1000);
            login();
        }
        [Then(@": books haul")]
        public void ThenBooksHaul()
        {
            Thread.Sleep(1000);
            Booking();
        }





        [Given(@":launched app")]
        public void GivenLaunchedApp()
        {
            Thread.Sleep(1000);
        }

        [Then(@": click  Next")]
        public void ThenClickNext()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": click on  button get started")]
        public void ThenClickOnButtonGetStarted()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@"do  action")]
        public void ThenDoAction()
        {
            Thread.Sleep(1000);
            AndroidElement logins = driver.FindElementByXPath("//android.widget.EditText");
            logins.Click();
            logins.SendKeys("94414740000");
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
        }
        [Then(@"do the signup")]
        public void ThenDoTheSignup()
        {
            signup();
           
        }
        [Then(@": bookings haul")]
        public void ThenBookingsHaul()
        {
            Thread.Sleep(1000);
            Booking();
        }

        [Given(@":launchedt app")]
        public void GivenLaunchedtApp()
        {
            Thread.Sleep(1000);
        }

        [Then(@": clicks  Next")]
        public void ThenClicksNext()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": clicks on  button get started")]
        public void ThenClicksOnButtonGetStarted()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }

        [Then(@"signups button")]
        public void ThenSignupsButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\" Sign Up\"]")).Click();
            signups();

        }
        [Then(@": booking haul")]
        public void ThenBookingHaul()
        {
            Thread.Sleep(1000);
            Booking();
        }





        [Given(@":launching app")]
        public void GivenLaunchingApp()
        {
            Thread.Sleep(1000);
        }

        [Then(@": click on Next")]
        public void ThenClickOnNext()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": click button get started")]
        public void ThenClickButtonGetStarted()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@"do the actions")]
        public void ThenDoTheActions()
        {
            continueasaguest();
        }
        [Then(@": bookingss haul")]
        public void ThenBookingssHaul()
        {
            Thread.Sleep(1000);
            Booking();
        }

    }

}

