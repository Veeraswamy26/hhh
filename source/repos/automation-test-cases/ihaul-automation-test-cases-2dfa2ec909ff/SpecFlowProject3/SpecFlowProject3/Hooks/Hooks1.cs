using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private AppiumDriver<AndroidElement> driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "Samsung");
            appiumOptions.AddAdditionalCapability("platform Version", "14");
            appiumOptions.AddAdditionalCapability("udid", "RZCWB12C5DN");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\Desktop\\apk\\smart3d-android-1.35.0.33836.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
            driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}