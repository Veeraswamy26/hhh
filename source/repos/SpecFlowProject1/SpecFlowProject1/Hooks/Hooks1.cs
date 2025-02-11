using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow ZF6224CBC8 R5CN317NG7W hooks see http://go.specflow.org/doc-hooks
        public static AppiumDriver<AndroidElement> driver;

        [BeforeScenario("@launch")]
        public void BeforeScenarioWithTag()
        {
            
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("platformName", "Android");
                appiumOptions.AddAdditionalCapability("deviceName", "samsung");
                appiumOptions.AddAdditionalCapability("platformVersion", "14");
                appiumOptions.AddAdditionalCapability("udid", "R5CT31BHYWE");
                appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\Smart 3D 1.39.0.40739\\Smart 3D 1.39.0.40739\\dk.resound.smart3d-Signed.apk");
                //appiumOptions.AddAdditionalCapability("autoGrantPermissions", true);  // Automatically grant all permissions

                var commandExecutor = new HttpCommandExecutor(new Uri("http://localhost:4723/wd/hub"), TimeSpan.FromSeconds(180));
                driver = new AndroidDriver<AndroidElement>(commandExecutor, appiumOptions);

            

        }
    }

}