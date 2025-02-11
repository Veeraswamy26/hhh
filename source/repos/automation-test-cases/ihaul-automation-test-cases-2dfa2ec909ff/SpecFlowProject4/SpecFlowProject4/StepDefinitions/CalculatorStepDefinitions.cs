//using OpenQA.Selenium.Appium.Android;
//using OpenQA.Selenium.Appium;

//namespace SpecFlowProject4.StepDefinitions
//{
//    [Binding]
//    public sealed class CalculatorStepDefinitions
//    {

using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using ResoundSmart3Ddemo.Hooks;

namespace ResoundSmart3Ddemo.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions : Hooks1
    {
       
         [Given(@"Click ""([^""]*)""")]
        public  void GivenClick(string demoMode)
        {







        }

      

    }
}