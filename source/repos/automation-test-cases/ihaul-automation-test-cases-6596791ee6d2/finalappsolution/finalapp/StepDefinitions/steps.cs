using finalapp.Hooks;
using finalapp.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using finalapp.POM;

namespace finalapp.StepDefinitions
{
    public class steps: Class1
    {
        [Given(@"cliks on next")]
        public void GivenCliksOnNext()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [When(@"clickss on getstarted")]
        public void WhenClickssOnGetstarted()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }

        [Then(@"enter mobile number")]
        public void ThenEnterMobileNumber()
        {
            Thread.Sleep(1000 );
            TestMobileNumberInResponse();
        }

    }
}
