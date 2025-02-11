using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowapi.StepDefinitions
{
    [Binding]
    public class scenarios
    {
        [Given(@"user send url""([^""]*)""")]
        public void GivenUserSendUrl(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"status will be (.*) ok")]
        public void ThenStatusWillBeOk(int p0)
        {
            throw new PendingStepException();
        }

    }
}
