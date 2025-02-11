using ihaulssjuly.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihaulssjuly.POM
{
    public class loginsignup : Hooks1
    {
        public void login()
        {
            AndroidElement logins = driver.FindElementByXPath("//android.widget.EditText");
            logins.Click();
            logins.SendKeys("9441474329");
            driver.Navigate().Back();
            Thread.Sleep(1000); 
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("123456");
            //driver.Navigate().Back();
            driver.Navigate().Back();


            AndroidElement loginss = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Login\"])[2]");
            Thread.Sleep(3000);
            loginss.Click();



        }
    }
}
