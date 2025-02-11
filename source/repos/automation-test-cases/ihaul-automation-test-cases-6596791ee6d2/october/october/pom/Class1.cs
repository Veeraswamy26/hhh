
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using october.pom;
using october.xpaths;
using OpenQA.Selenium.Appium.MultiTouch;

namespace finalapp.utility
{
    public class Class1 : bookinghaul
    {

        //string enterMobileNumber = "123456789";
        // Locate and interact with email input field
        //AndroidElement mobileField = driver.FindElementById("00000000-0000-04ee-0000-002a00000003");
        // mobileField.SendKeys("9441474329");
        //driver.FindElement(By.XPath("//android.widget.EditText")).Click();
        //driver.Keyboard.SendKeys("9441474328");
        public void TestMobileNumberInResponse()
        {
            // Call GetData to fetch and extract data
            var userData = GetData();

            // Define the mobile number to check
            string enteredMobileNumber = "12345678901";
            AndroidElement mobileField = driver.FindElementByXPath(xpath.Edit);
            mobileField.Click();
            mobileField.SendKeys(enteredMobileNumber);
            driver.Navigate().Back();


            // Check if the entered mobile number exists in the extracted data
            bool isMobileNumberInResponse = userData.Any(user => user.PhoneNumber == enteredMobileNumber);

            // Assert that the mobile number is found in the response data


            if (isMobileNumberInResponse)
            {
                // Code to execute if the condition is true
                //login 
                driver.FindElement(By.XPath(xpath.Continues)).Click();
                AndroidElement mobileFields = driver.FindElementByXPath(xpath.Edit);
                mobileFields.Click();
                mobileFields.SendKeys("123456");
                Console.WriteLine("yes");
                AndroidElement login = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Login\"])[2]");
                Thread.Sleep(3000);
                login.Click();
                //clicklogin xpath
                //homepage functio
            }
            else
            {
                //signup button
                // Assert.IsTrue(isMobileNumberInResponse, "The entered mobile number was not found in the response data.");
                driver.FindElement(By.XPath(xpath.Continues))
                      .Click();
                AndroidElement cust = driver.FindElementByXPath("//android.widget.ImageView[@index=3]");
                cust.Click();
                AndroidElement vfr = driver.FindElementByXPath(xpath.Continues);
                vfr.Click();

                AndroidElement upload = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Upload Photo\"]");
                upload.Click();

                AndroidElement uploadfrm = driver.FindElementByXPath("//android.view.View[@content-desc=\"Upload From Gallery\"]");
                uploadfrm.Click();

                AndroidElement uploadphoto = driver.FindElementByXPath("//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"]");
                uploadphoto.Click();

                AndroidElement photocrop = driver.FindElementByXPath("//android.widget.Button[@content-desc=\"Crop\"]");
                photocrop.Click();

                AndroidElement first = driver.FindElementByXPath(xpath.GetTestFieldXPath(1));
                first.Click();
                first.SendKeys("kalluri");
                driver.Navigate().Back();
                AndroidElement last = driver.FindElementByXPath(xpath.GetTestFieldXPath(2));
                last.Click();
                last.SendKeys("veera");
                driver.Navigate().Back();
                AndroidElement email = driver.FindElementByXPath(xpath.GetTestFieldXPath(4));
                email.Click();
                email.SendKeys("swamy.uhjghri@i-raysolutions.com");
                driver.Navigate().Back();
                AndroidElement create = driver.FindElementByXPath(xpath.GetTestFieldXPath(4));
                create.Click();
                create.SendKeys("123456");
                driver.Navigate().Back();
                AndroidElement confirm = driver.FindElementByXPath(xpath.GetTestFieldXPath(4));
                confirm.Click();
                confirm.SendKeys("123456");
                driver.Navigate().Back();

                AndroidElement signup = driver.FindElementByXPath("//android.view.View[@content-desc=\"Sign Up\"]");
                signup.Click();
                Console.WriteLine("successfully.");
                Thread.Sleep(10000);

                Thread.Sleep(10000);
                Console.WriteLine("enter otp thread");
                Thread.Sleep(10000);
                //homepage
                driver.FindElement(By.XPath(xpath.ok)).Click();

            }

        }
       
        public void logout()
        {
            // Locate the element that was clicked
            driver.FindElement(By.XPath(xpath.profile)).Click();
            AndroidElement moves = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            driver.FindElement(By.XPath(xpath.setings)).Click();
            AndroidElement move = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            driver.FindElement(By.XPath(xpath.logout)).Click();
            driver.FindElement(By.XPath(xpath.logout2)).Click();

        }

        public void homepage()
        {
            driver.FindElement(By.XPath(xpath.Next)).Click();
            driver.FindElement(By.XPath(xpath.Next)).Click();
            driver.FindElement(By.XPath(xpath.GetStarted)).Click();
        }
    }

}
    
           
        
        
       
    
    
