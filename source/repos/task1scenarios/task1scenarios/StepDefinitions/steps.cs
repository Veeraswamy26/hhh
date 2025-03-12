using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1scenarios.Methods;

namespace task1scenarios.StepDefinitions
{
    [Binding]
    public class steps : convert
    {
        [Given(@"I launch the plugin app")]
        public void GivenILaunchThePluginApp()
        {
          Thread.Sleep(1000);
        }

        [Given(@"I scroll Down and launch plugin '([^']*)'")]
        public void GivenIScrollDownAndLaunchPlugin(string aboutPlugin)
        {
            click(aboutPlugin);
        }


        [Then(@"verify '([^']*)' is '([^']*)' on '([^']*)'")]
        public void ThenVerifyIsOn(string hearingAidCompatibilityLink, string displayed, string aboutPluginPage)
        {
           
        }

    }
}
