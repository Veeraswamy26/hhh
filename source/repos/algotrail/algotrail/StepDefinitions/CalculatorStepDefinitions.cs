using algotrail.hooks;
using OpenQA.Selenium.Appium.Windows;

namespace algotrail.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions : Hooks1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"HAs are ready and open algo")]
        public void GivenHAsAreReadyAndOpenAlgo()
        {
           Thread.Sleep(1000);
            WindowsElement toggleButton = sessionAlgo.FindElementByXPath("//Button[@AutomationId='ToggleButton']");
            toggleButton.Click();
        }

        [When(@"the HAs are connect using interface available")]
        public void WhenTheHAsAreConnectUsingInterfaceAvailable()
        {
            Thread.Sleep(1000);
            WindowsElement selectdongle = sessionAlgo.FindElementByXPath("//Button[@AutomationId='FittingDongle:0']");
            selectdongle.Click();
        }

        [Then(@"HAs read and store preset")]
        public void ThenHAsReadAndStorePreset()
        {
            Thread.Sleep(1000);
        }

    }
}
