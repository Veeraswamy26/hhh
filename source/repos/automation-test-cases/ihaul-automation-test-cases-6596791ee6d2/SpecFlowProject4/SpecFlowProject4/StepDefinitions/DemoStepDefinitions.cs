using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using ResoundSmart3Ddemo.Hooks;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Newtonsoft.Json.Linq;

namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class DemoStepDefinitions : Hooks1
    {

        //public static AppiumDriver<AndroidElement> driver;


        [Given(@"Clicks on ""([^""]*)""")]
        public void GivenClicksOn(string p0)
        {
 

            switch (p0.ToLower())
            {
                case "no take me to demo mode":
                    driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"dk.resound.smart3d:id/demo_button\"]")).Click();

                    break;
                case "yes,connect now":
                    driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"dk.resound.smart3d:id/connect_button\"]")).Click();

                    break;
                default:

                    break;
            }


        }

        [When(@"Clicks on ""([^""]*)""")]
        public static void WhenClicksOn(string exit)
        {
            switch (exit)
            {
                case "exits":
                    driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"dk.resound.smart3d:id/connect_button\"]")).Click();
                    break;
                case "continue":
                    driver.FindElement(By.XPath("//android.widget.Button[@resource-id=\"dk.resound.smart3d:id/connect_button\"]")).Click();
                    break;
                default:
                    break;
            }
        }

    }
}
