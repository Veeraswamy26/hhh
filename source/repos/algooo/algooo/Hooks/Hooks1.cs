using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace Algo
{
    public class Hooks
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> Algoconnect;
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", @"C:\Program Files (x86)\ReSound\Dooku3.10.21.4\AlgoLabtest.Dooku.exe");
            appiumOptions.AddAdditionalCapability("appWorkingDir", @"C:\Program Files (x86)\ReSound\Dooku3.10.15.1");
            Algoconnect = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), appiumOptions);

            Assert.IsNotNull(Algoconnect);
            Algoconnect.Manage().Window.Maximize();

        }
    }
}