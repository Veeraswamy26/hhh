using SpecFlowProject3.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.StepDefinitions
{
    public class steps : Hooks1
    {


        [Given(@"I launch the app")]
        public void GivenILaunchTheApp()
        {
            Thread.Sleep(6000); 
                }

    }
}
