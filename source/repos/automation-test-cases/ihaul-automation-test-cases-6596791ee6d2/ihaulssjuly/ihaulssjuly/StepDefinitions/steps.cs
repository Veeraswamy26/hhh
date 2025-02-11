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
using ihaulssjuly.POM;
using System.Data.OleDb;

namespace ihaulssjuly.StepDefinitions
{

    public class steps : login_signup_guest
    {
        [Given(@":launched app")]
        public void GivenLaunchedApp()
        {
            Thread.Sleep(1000);
        }

        [Then(@": clicks on ""([^""]*)""")]
        public void ThenClicksOn(string next)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();

        }

        [Then(@": clickss on the button ""([^""]*)""")]
        public void ThenClickssOnTheButton(string p0)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@": Do login")]
        public void ThenDoLogin()
        {
            Thread.Sleep(1000);
            login();

        }
        [Then(@": booking haul")]
        public void ThenBookingHaul()
        {
            Thread.Sleep(1000);
            bookhaulscards();
        }


    }
}
        
