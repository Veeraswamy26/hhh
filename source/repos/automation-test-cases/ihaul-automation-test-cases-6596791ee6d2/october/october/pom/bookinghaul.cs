using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium;
namespace october.pom
{
    public class bookinghaul:UserDataTests
    {
            public void bookingflow()
            {

                Console.WriteLine("123go");
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
            driver.FindElement(By.XPath("//android.widget.ImageView[@index=1]")).Click();
            //driver.FindElement(By.XPath("//*[@elementId='00000000-0000-0025-0000-019f00000004']")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"25, Friday, October 25, 2024\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@index=6])[1]")).Click();
            driver.FindElement(By.XPath("//android.widget.RadioButton[@content-desc=\"AM\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@index=7]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@index=9]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Upload From Gallery\"]")).Click();
            driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[1]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.ScrollView/android.view.View[2]/android.widget.RadioButton[1]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Items needs to be boxed\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"smallBoxes-Type here\"]")).Click();
            AndroidElement small = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"smallBoxes-Type here\"]"));
            small.Click();
            small.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smalll = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"mediumBoxes-Type here\"]"));
            smalll.Click();
            smalll.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smallll = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"largeBoxes-Type here\"]"));
            smallll.Click();

            smallll.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smal = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"xLargeBoxes-Type here\"]"));
            smal.Click();
            smal.SendKeys("6");
            driver.Navigate().Back();


            driver.FindElement(By.XPath("//android.widget.ScrollView/android.view.View[4]/android.widget.RadioButton[1]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();

            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"+Add Card\"]")).Click();
                driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();


            }
        }
    }




