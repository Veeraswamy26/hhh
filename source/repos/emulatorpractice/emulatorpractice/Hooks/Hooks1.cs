using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using TechTalk.SpecFlow;

namespace emulatorpractice.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private AppiumDriver<AndroidElement> driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            var appoptions = new AppiumOptions();
            appoptions.AddAdditionalCapability("PlatformName", "Android");
            appoptions.AddAdditionalCapability("PlatformVersion", "13");
            appoptions.AddAdditionalCapability("udid", "RZ8R12B5L5H");
            appoptions.AddAdditionalCapability("App", "C:\\Users\\iray\\Downloads\\dk.resound.smart3d - Signed.apk");
            
            HttpClient timer = new HttpClient();
            timer.Timeout = TimeSpan.FromSeconds(150);


            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appoptions);
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        /* [BeforeScenario(Order = 1)]
         public void FirstBeforeScenario()
         {
              Example of ordering the execution of hooks
              See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

             TODO: implement logic that has to run before executing each scenario

        */
        [AfterScenario]
         public void AfterScenario()
         {
         driver.Quit();
          } 

    }
}