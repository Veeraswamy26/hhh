using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace algotrail.hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public WindowsDriver<WindowsElement> sessionAlgo;
        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            if (sessionAlgo == null)
            {
                AppiumOptions appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", @"C:\Program Files (x86)\ReSound\Dooku3.10.29.2\AlgoLabtest.Dooku.exe");
                appiumOptions.AddAdditionalCapability("appWorkingDir", @"C:\Program Files (x86)\ReSound\Dooku3.10.29.2");
                appiumOptions.AddAdditionalCapability("run--as-adminstrator",true);
                sessionAlgo = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            }
        }

    }
}
/*using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Appium options
        AppiumOptions options = new AppiumOptions();
        options.AddAdditionalCapability("app", @"C:\Program Files (x86)\ReSound\Dooku3.10.30.1\AlgoLabtest.Dooku.exe"); // Path to the desktop app
        options.AddAdditionalCapability("platformName", "Windows");
        options.AddAdditionalCapability("deviceName", "WindowsPC");

        // Connect to WinAppDriver
        WindowsDriver<WindowsElement> driver = null;
        try
        {
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            Console.WriteLine("Desktop application launched successfully!");

            // Example: Interact with the application (if it supports automation)
            // Perform actions using driver.FindElement and driver.Click, etc.
            // Example: Close the application
            driver.CloseApp();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to launch the desktop application: {ex.Message}");
        }
        finally
        {
            driver?.Quit();
        }
    }
}
*/