using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using ihaullaunch.StepDefinitions;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.MultiTouch;
using ihaullaunch.utility;
using NUnit.Framework;

namespace ihaullaunch.Hooks
{
    [Binding]
    public class Hooks1
    {

        //created driver instance statically
        public static AppiumDriver<AndroidElement> driver;
        //public static HttpClient client;


        [BeforeScenario()]
        public static void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "google");
            appiumOptions.AddAdditionalCapability("platform Version", "14");
            appiumOptions.AddAdditionalCapability("udid", "1C201FDEE0084P");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\1-07-2024.apk");
            //appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            //client = new HttpClient();
            //client.BaseAddress = new Uri("http://15.206.27.64/api/v1/auth/appLogin");

        }
    }
}