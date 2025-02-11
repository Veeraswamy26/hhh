using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

using BoDi;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SpecFlowProject2.utility
{
    [Binding]
    public sealed class ControlHelper

    {

        public static AppiumDriver<AndroidElement> driver;

        public static void InitializeDriver()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "Google Pixel 8");
            appiumOptions.AddAdditionalCapability("platformVersion", "14");
            appiumOptions.AddAdditionalCapability("udid", "38081FDJH007V4");
            appiumOptions.AddAdditionalCapability("appium:serverAddress", "http://127.0.0.1:4723/wd/hub");
            appiumOptions.AddAdditionalCapability("app", @"C:\Users\Iray Trust\Desktop\apk\dk.resound.smart3d-Signed.apk.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");

            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(120);
            var commandExecutor = new HttpCommandExecutor(new Uri("http://127.0.0.1:4723/wd/hub"), TimeSpan.FromSeconds(180));
            // No need to register the driver instance here as it's a static field
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);

            // CommandPromptAutomationStepDefinitions casd = new CommandPromptAutomationStepDefinitions();
            // casd.GivenIOpenCommandPrompt();



            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
        }



        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }




        public void PressElement(AppiumDriver<AndroidElement> driver, By locator)
        {


            // Wait for the element to be clickable
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            // Click on the element using the provided locator
            element.Click();


        }
    }

    public class AndroidElement
    {
    }

    public class AppiumDriver<T>
    {
    }
}