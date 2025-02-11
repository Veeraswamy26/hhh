
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.StepDefinitions
{
    public class steps : UserDataTests
    {
        [Given(@"go to app")]
        public void GivenGoToApp()
        {
            Thread.Sleep(1000);
        }
        [Then(@"click on the Next")]
        public void ThenClickOnTheNext()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@"click on the button get started")]
        public void ThenClickOnTheButtonGetStarted()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
            Thread.Sleep(10000);

        }
        [When(@"save the data")]
        public void WhenSaveTheData()
        {
            GetData();
        }

        [Then(@"enter mobile number")]
        public void ThenEnterMobileNumber()
        {
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("12345678909");
         
            
        }


        [Then(@"booking haul page will display")]
        public void ThenBookingHaulPageWillDisplay()
        {
        }
    }
}

