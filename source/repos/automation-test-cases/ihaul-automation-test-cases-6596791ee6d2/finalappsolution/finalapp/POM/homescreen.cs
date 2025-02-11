using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.MultiTouch;

namespace finalapp.POM
{
   public class homescreen: adddetailspage
    {
        public void abc()
        {
           
            Console.WriteLine("1m,;jkljkghjfygjkjhfgujfgjf23go");
            location();
            summary();
      
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"+Add Card\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();


        }
    }
}

        