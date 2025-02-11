using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.Events;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.xpaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using SpecFlowProject1.xpaths;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;

namespace SpecFlowProject1.StepDefinitions
{
    public class steps : Hooks1
    {

        [Given(@"display app")]
        public void GivenDisplayApp()
        {
            Thread.Sleep(1000);
        }
        [When(@"app opens agree tnc")]
        public  void WhenAppOpensAgreeTnc()
        {
            driver.FindElementByXPath(xpathsfor.yes).Click();
            driver.FindElementByXPath(xpathsfor.tnc).Click();
        }


    }
}