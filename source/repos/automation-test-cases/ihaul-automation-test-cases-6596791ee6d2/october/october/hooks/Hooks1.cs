using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Security.Cryptography.X509Certificates;

namespace october.hooks
{
    [Binding]
    public class Hooks1
    {
        public static AppiumDriver<AndroidElement> driver;

        [BeforeScenario]
        public static void BeforeScenarioWithTag()
        {
            if (driver == null)
            {
                try
                {
                    var appiumOptions = new AppiumOptions();
                    appiumOptions.AddAdditionalCapability("platformName", "Android");
                    appiumOptions.AddAdditionalCapability("deviceName", "moto");
                    appiumOptions.AddAdditionalCapability("platformVersion", "10");
                    appiumOptions.AddAdditionalCapability("udid", "ZF6224CBC8");
                    appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v54.apk");
                    appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions

                    var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(300));
                    driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error initializing Appium driver: {ex.Message}");
                    throw;
                }
            }

        }
        [AfterScenario]
        public static void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }

}