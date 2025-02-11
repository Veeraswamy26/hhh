using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Remote;

namespace signin.Hooks
{
    [Binding]
    public class Hooks1
    {
        // Created driver instance statically
        public static AppiumDriver<AndroidElement> driver;

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            if (driver == null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("platformName", "Android");
                appiumOptions.AddAdditionalCapability("deviceName", "samsung");
                appiumOptions.AddAdditionalCapability("platformVersion", "14");
                appiumOptions.AddAdditionalCapability("udid", "R3CT302GE0F");
                appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v23.apk");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions

                var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
                driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            }
        }
    }
}
