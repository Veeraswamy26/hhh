using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Remote;

namespace login.Hooks
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
                appiumOptions.AddAdditionalCapability("platformVersion", "13");
                appiumOptions.AddAdditionalCapability("udid", "R5CN317NG7W");
                appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v41.apk");
                appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions

                var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
                driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            }
        }
    }
}
