using login.Hooks;
using login.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.StepDefinitions
{
    public class steps : mobilenumber
    {
        [Given(@":launch app")]
        public void GivenLaunchApp()
        {
            Thread.Sleep(6000);
        }

        [Then(@": click on ""([^""]*)""")]
        public void ThenClickOn(string next)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
        }

        [Then(@": click on the button ""([^""]*)""")]
        public void ThenClickOnTheButton(string p0)
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [Then(@": enter mobile number")]
        public void ThenEnterMobileNumber()
        {
            Thread.Sleep(6000);
            EnterMobile();
        }

        
        [Then(@": click onthe continue")]
        public void ThenClickOntheContinue()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
                  .Click();
        }
        [Then(@": enter Password")]
        public void ThenEnterPassword()
        {
            Thread.Sleep(6000);
            Enterpassword();
        }
        [Then(@": click on login")]
        public void ThenClickOnLogin()
        {
            Thread.Sleep(6000);
            driver.FindElement(By.XPath(" //android.widget.EditText"))
                  .Click();
            EnterMobile();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
                  .Click();
            AndroidElement mobileField = driver.FindElementByXPath("//android.widget.EditText");
            mobileField.Click();
            mobileField.SendKeys("123456");
            AndroidElement login = driver.FindElementByXPath("(//android.view.View[@content-desc=\"Login\"])[2]");
            Thread.Sleep(3000);
            login.Click();
        }

        [Then(@": click on the create Haul")]
        public void ThenClickOnTheCreateHaul()
        {
            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Set Pick Up & Drop Location\"]"))
                .Click();
            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Select Pickup Location\"]"))
                .Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Add More Address Details\"]"))
                .Click();
            AndroidElement textfield = driver.FindElementByXPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.EditText[1]");
               textfield.Click();

            textfield.SendKeys("entry");
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
                .Click();
            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Drop off Location\"]"))
                  .Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Add More Address Details\"]"))
               .Click();
            AndroidElement textfields = driver.FindElementByXPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.widget.EditText[1]");
            textfields.Click();

            textfields.SendKeys("exit");
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]"))
               .Click();
            AndroidElement move = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));

            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Add pick up & drop off details\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Ground floor\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[1]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[2]")).Click();
            AndroidElement moves = driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            AndroidElement reciver = driver.FindElementByXPath("//android.widget.EditText");
            reciver.Click();    
            reciver.SendKeys("exit");
            driver.Navigate().Back();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Ground floor\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[3]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@content-desc=\"Yes\"])[4]")).Click();
            //driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            //driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//android.widget.ImageView[@text=\"09/18/2024\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"19, Wednesday, September 18, 2024\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]/android.view.View/android.view.View[5]")).Click();
            driver.FindElement(By.XPath("//android.widget.RadioButton[@content-desc=\"AM\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]/android.view.View/android.view.View[6]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]/android.view.View/android.view.View[8]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Upload From Gallery\"]")).Click();
            driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.google.android.providers.media.module:id/icon_thumbnail\"])[1]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"com.google.android.providers.media.module:id/button_add\"]")).Click();
            Thread.Sleep(60000);

        }
    }
}
