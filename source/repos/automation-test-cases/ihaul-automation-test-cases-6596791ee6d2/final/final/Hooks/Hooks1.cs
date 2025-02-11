using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace final.Hooks
{
    [Binding]

    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        // Created driver instance statically
        public static AppiumDriver<AndroidElement> driver;


        [BeforeScenario]

        public static void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario



            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "googlepixel");
            appiumOptions.AddAdditionalCapability("platformVersion", "10");
            appiumOptions.AddAdditionalCapability("udid", "HT69B0207315");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\app-release-v40.apk");
            appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions
            

            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
            

        }

        [AfterScenario]
        public static void AfterScenarioWithTag()
        {
            driver.Quit();

        }
    }
}