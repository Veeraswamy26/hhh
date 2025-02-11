using ihaullaunch.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihaullaunch.utility
{
    public class swipe:Hooks1
    {
        
        public static void doswipe()
        {
            int screenHeight = driver.Manage().Window.Size.Height;
            int screenWidth = driver.Manage().Window.Size.Width;

            // Define swipe coordinates
            int startx = (int)(screenWidth * 0.2);
            int endx = (int)(screenWidth * 0.8);
            int starty = screenHeight / 2;

            // Perform swipe action
            TouchAction touchAction = new TouchAction(driver);
            touchAction.Press(startx, starty).MoveTo(endx, starty).Release().Perform();
            
        }
        public static void doswipee()
        {
            //int screenHeight = driver.Manage().Window.Size.Height;
            //int screenWidth = driver.Manage().Window.Size.Width;

            //// Define swipe coordinates
            //int starty = (int)(screenHeight * 0.2);
            //int endy = (int)(screenHeight * 0.8);
            //int startx = screenWidth/2;

            //// Perform swipe action
            //TouchAction touchAction = new TouchAction(driver);
            //touchAction.Press(starty, startx).MoveTo(endy, startx).Release().Perform();
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0, 250);"); // Scroll down by pixel offset
            //js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            //string targetText = "Continue As guest";
            //string scrollCommand = $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().textContains(\"{targetText}\"));";
            //driver.FindElement(MobileBy.AndroidUIAutomator(scrollCommand));
            driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));


        }
        //public void TestAPICallFromApp()
        //{
        //    // Perform actions in the app that trigger API calls

        //    // Example: Click a button that makes an API call
        //    driver.FindElementById("button_id").Click();

        //    // Wait for API call to complete (if necessary)
        //    System.Threading.Thread.Sleep(3000); // Example: Wait for 3 seconds

        //    // Example: Verify API response
        //    HttpResponseMessage response = client.GetAsync("/endpoint").Result;

        //    // Assert API response status code
        //    Assert.IsTrue(response.IsSuccessStatusCode, "API endpoint is not accessible");
        //}
        //public void TearDown()
        //{
        //    // Clean up
        //    driver.Quit();
        //    client.Dispose();
        //}
    }
}

