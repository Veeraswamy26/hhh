using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.Hooks
{
    [Binding]
    public class Hooks1
    {
        private AppiumDriver<AndroidElement> driver;

      
        public void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "google");
            appiumOptions.AddAdditionalCapability("platform Version", "12");
            appiumOptions.AddAdditionalCapability("udid", "89DX08EN0");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\Desktop\\apk\\smart3d-android-1.35.0.33836.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
        }

        
    }
}