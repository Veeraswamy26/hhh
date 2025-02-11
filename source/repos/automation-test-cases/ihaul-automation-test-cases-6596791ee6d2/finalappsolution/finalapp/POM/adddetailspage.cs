using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalapp.POM
{
    public class adddetailspage:packingandmoving
    {
        public void location()
        {
            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Set Pick Up & Drop Location\"]"))
               .Click();
            Thread.Sleep(10000);

            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Select Pickup Location\"]"))
                .Click();
            //AndroidElement maps = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(1);"));
            int startX = 250; // Middle of the screen horizontally
            int startY = 800; // Middle of the screen vertically
            int endY = (int)(1560 * 0.1); // Swipe to 20% of the screen height (swiping up)

            // Perform the swipe action from middle to upward
            new TouchAction(driver)
                .Press(startX, startY) // Start at middle of the screen
                .Wait(1000) // Optional wait for visual purposes
                .MoveTo(startX, endY) // Move to the end Y coordinate (upward)
                .Release()
                .Perform();
            Thread.Sleep(10000);
            // AndroidElement maps = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView(text(\"Miami\"));"));
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Add More Address Details\"]"))
                .Click();
            AndroidElement textfield = driver.FindElementByXPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.EditText[1]");
            textfield.Click();

            textfield.SendKeys("entry");
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
                .Click();
            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Drop off Location\"]"))
                  .Click();

            // Perform the swipe action from middle to upward
            new TouchAction(driver)
                .Press(startX, startY) // Start at middle of the screen
                .Wait(1000) // Optional wait for visual purposes
                .MoveTo(startX, endY) // Move to the end Y coordinate (upward)
                .Release()
                .Perform();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Add More Address Details\"]"))
               .Click();
            AndroidElement textfields = driver.FindElementByXPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.EditText[1]");
            textfields.Click();

            textfields.SendKeys("exit");
            driver.Navigate().Back();
            //AndroidElement move = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));

            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
               .Click();
            AndroidElement move = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            var loginButton = driver.FindElementByAccessibilityId("Add pick up & drop off details");
            loginButton.Click();
            //driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Add pick up & drop off details\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Ground floor\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[1]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[2]")).Click();
            AndroidElement moves = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            AndroidElement reciver = driver.FindElementByXPath("//android.widget.EditText[@resource-id=\"receiverName-Name here\"]");
            reciver.Click();
            reciver.SendKeys("exit");
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Ground floor\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[1]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[2]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            //driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            Thread.Sleep(10000);
        }
    }
}
