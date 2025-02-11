using iHaulautomation.Hooks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace iHaulautomation.POM
{
    public class continueasguest:Hooks1
{
        public void continueasaguest()
        {
            Thread.Sleep(1000);
            driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            AndroidElement signups = driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue As guest\"]"));
                signups.Click();
            

          
            
        }
    }
}
