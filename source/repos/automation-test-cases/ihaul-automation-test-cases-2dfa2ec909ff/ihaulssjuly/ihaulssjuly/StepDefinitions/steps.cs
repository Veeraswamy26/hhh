using ihaulssjuly.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Appium.Interfaces;

namespace ihaulssjuly.StepDefinitions
{
    [Binding]
    public class steps : Hooks1
    {

        [Given(@":click on  the ""([^""]*)""")]
        public static void GivenClickOnThe(string skip)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Skip\"]")).Click();
        }

        [Given(@": click on  ""([^""]*)""")]
        public static void GivenClickOn(string p0)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@": enter email")]
        public void ThenEnterEmail()
        {
            Thread.Sleep(6000);
           
           AndroidElement inputField = driver.FindElementByXPath("//android.widget.EditText");
            inputField.Click();
            inputField.SendKeys("9441474329");
           
            //driver.FindElement(By.XPath("//android.widget.EditText")).Click();
            //driver.Keyboard.SendKeys("9441474328");



            //[Given(@"open App")]
            //public void GivenOpenApp()
            //{

            //}

            //[When(@"skip to continue")]
            //public void WhenSkipToContinue()
            //{
            //    Thread.Sleep(6000);
            //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();

            //}

            //[When(@"click on get started")]
            //public void WhenClickOnGetStarted()
            //{
            //    Thread.Sleep(6000);
            //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
            //}

            //[Then(@"enter email or password")]
            //public void ThenEnterEmailOrPassword()
            //{
            //    Thread.Sleep(6000);
            //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            //}

            //[Then(@"get request with url""([^""]*)""")]
            //public void ThenGetRequestWithUrl(string p0)
            //{
            //    Thread.Sleep(6000);
            //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            //}


            //[Given(@": click on ""([^""]*)""")]
            //public void GivenClickOn(string next)
            //{
            //    Thread.Sleep(6000);
            //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();

            //}
        }
    }
}