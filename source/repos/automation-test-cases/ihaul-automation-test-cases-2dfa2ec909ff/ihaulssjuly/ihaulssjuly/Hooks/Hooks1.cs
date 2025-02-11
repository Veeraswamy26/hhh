using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using ihaulssjuly.StepDefinitions;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.MultiTouch;
using ihaulssjuly.POM;
using NUnit.Framework;

namespace ihaulssjuly.Hooks
{
    [Binding]
    public class Hooks1
    {

        //created driver instance statically
        public static AppiumDriver<AndroidElement> driver;


        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "google");
            appiumOptions.AddAdditionalCapability("platform Version", "10");
            appiumOptions.AddAdditionalCapability("udid", "HT69B0207315");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release j8.apk");
           
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);

        }
    }
}