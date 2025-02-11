using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace ihaul_unified.Hooks

  {
    [Binding]
public class Hooks1
{

    //created driver instance statically
    public static AppiumDriver<AndroidElement> driver;


    [BeforeScenario()]
    public void BeforeScenarioWithTag()
    {

        if (driver == null)
        {


            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "samsung");
            appiumOptions.AddAdditionalCapability("platform Version", "14");
            appiumOptions.AddAdditionalCapability("udid", "R5CR10EV6LL");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v21.apk");

            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
        }
    }
}
}
