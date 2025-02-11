using login.Hooks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Utility
{
    public class mobilenumber : Hooks1

    {
     
        public void EnterMobile()
        {
            // Locate and interact with email input field
            //AndroidElement mobileField = driver.FindElementById("00000000-0000-04ee-0000-002a00000003");
            // mobileField.SendKeys("9441474329");
            //driver.FindElement(By.XPath("//android.widget.EditText")).Click();
            //driver.Keyboard.SendKeys("9441474328");
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("9441474329");
            driver.Navigate().Back();
        }
        public void Enterpassword()
        {
            // Locate and interact with email input field
            //AndroidElement mobileField = driver.FindElementById("00000000-0000-04ee-0000-002a00000003");
            // mobileField.SendKeys("9441474329");
            //driver.FindElement(By.XPath("//android.widget.EditText")).Click();
            //driver.Keyboard.SendKeys("9441474328");
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("123456");
            //driver.Navigate().Back();

            AndroidElement login = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Login\"])[2]");
            Thread.Sleep(3000);
            login.Click();
            
            AndroidElement logout = driver.FindElementByXPath("//android.widget.ImageView[@index=4]");
            logout.Click();
            AndroidElement move = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));

            driver.FindElementByXPath("//android.view.View[@content-desc=\"Settings\"]").Click();
            AndroidElement logout1 = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Logout\"]");
            logout1.Click();
            AndroidElement logout2 = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Logout\"])[2]");
            logout2.Click();
            //Console.WriteLine("Entered email successfully.");
        }
    }
}
