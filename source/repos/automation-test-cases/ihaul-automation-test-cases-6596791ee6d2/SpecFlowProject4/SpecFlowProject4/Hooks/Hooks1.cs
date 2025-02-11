using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using SpecFlowProject4.StepDefinitions;

namespace ResoundSmart3Ddemo.Hooks
{
    [Binding]
    public class Hooks1  : ask
    { 

        //created driver instance statically
        public static AppiumDriver<AndroidElement> driver;

        
        [BeforeScenario()]
        public static void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "samsung");
            appiumOptions.AddAdditionalCapability("platform Version", "14");
            appiumOptions.AddAdditionalCapability("udid", "R5CN317NG7W");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\Desktop\\apk\\dk.resound.smart3d-Signed.apk.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);

        }
    }
}