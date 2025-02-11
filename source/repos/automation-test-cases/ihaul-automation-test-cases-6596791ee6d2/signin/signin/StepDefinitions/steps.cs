using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using signin.Hooks;
using signin.utility;

namespace signin.StepDefinitions
{
    public class steps : mobilenimber
    {
        
        [Given(@":launch app")]
        public void GivenLaunchApp()
        {
            Thread.Sleep(6000);
        }

        [Then(@": click on ""([^""]*)""")]
        public void ThenClickOn(string next)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": click on the button ""([^""]*)""")]
        public void ThenClickOnTheButton(string p0)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@": enter mobile number")]
        public void ThenEnterMobileNumber()
        {
            Thread.Sleep(6000);
            EnterMobile();
        }


        [Then(@": click onthe continue")]
        public void ThenClickOntheContinue()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
                  .Click();
        }
        [Then(@": enter details")]
        public void ThenEnterDetails()
        {
            signupcus();
        }
        [Then(@": click on  the create Haul")]
        public void ThenClickOnTheCreateHaul()
        {
           
        }



    }
}
