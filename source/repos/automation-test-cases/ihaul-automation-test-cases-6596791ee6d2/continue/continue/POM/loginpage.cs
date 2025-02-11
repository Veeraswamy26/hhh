using iHaulautomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace iHaulautomation.POM
{
   public class loginpage : continueasguest
    {

        public void login()
        {
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("123456");
            //driver.Navigate().Back();
            driver.Navigate().Back();


            AndroidElement loginss = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Login\"])[2]");
            Thread.Sleep(3000);
            loginss.Click();
        }
        public void logout()
        { 
            AndroidElement logout = driver.FindElementByXPath("//android.widget.ImageView[@index=4]");
            logout.Click();
            AndroidElement logout1 = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Logout\"]");
            logout1.Click();
            AndroidElement logout2 = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Logout\"])[2]");
            logout2.Click();
        }

}
}
