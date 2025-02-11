using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using signin.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signin.utility
{
    public class mobilenimber : Hooks1
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
            mobileField.SendKeys("9447755223");
            driver.Navigate().Back();


            //Console.WriteLine("Entered email successfully.");
        }
        public void signupcus()

        {
            AndroidElement cust = driver.FindElementByXPath("//android.widget.ImageView[@index=3]");
            cust.Click();
            AndroidElement vfr = driver.FindElementByXPath("//android.view.View[@content-desc=\"Continue\"]");
            vfr.Click();

            AndroidElement upload = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Upload Photo\"]");
            upload.Click();

            AndroidElement uploadfrm = driver.FindElementByXPath("//android.view.View[@content-desc=\"Upload From Gallery\"]");
            uploadfrm.Click();

            AndroidElement uploadphoto = driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.google.android.providers.media.module:id/icon_thumbnail\"])[1]");
            uploadphoto.Click();

            AndroidElement photocrop = driver.FindElementByXPath("//android.widget.Button[@content-desc=\"Crop\"]");
            photocrop.Click();

            AndroidElement first = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[1]");
            first.Click();
            first.SendKeys("kalluri");
            driver.Navigate().Back();
            AndroidElement last = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[2]");
            last.Click();
            last.SendKeys("veera");
            driver.Navigate().Back();
            AndroidElement email = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[4]");
            email.Click();
            email.SendKeys("kvswamy@26022012324.com");
            driver.Navigate().Back();
            AndroidElement create = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[5]");
            create.Click();
            create.SendKeys("1234567890");
            driver.Navigate().Back();
            AndroidElement confirm = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[6]");
            confirm.Click();
            confirm.SendKeys("1234567890");
            driver.Navigate().Back();
            driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            AndroidElement signup = driver.FindElementByXPath("//android.view.View[@content-desc=\"Sign Up\"]");
            signup.Click();
            Console.WriteLine("successfully.");
            Thread.Sleep(10000);
        }
    }
}

