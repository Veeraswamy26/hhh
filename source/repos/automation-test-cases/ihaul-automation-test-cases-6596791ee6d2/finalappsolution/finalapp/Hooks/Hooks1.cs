using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace finalapp.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow ZF6224CBC8 R5CN317NG7W hooks see http://go.specflow.org/doc-hooks
        public static AppiumDriver<AndroidElement> driver;

        [BeforeScenario("@check")]
        public void BeforeScenarioWithTag()
        {
            if (driver == null)
            { 
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "moto");
            appiumOptions.AddAdditionalCapability("platformVersion", "10");
            appiumOptions.AddAdditionalCapability("udid", "ZF6224CBC8");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v54.apk");
            appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions

            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
        }
            

        }
    }
}