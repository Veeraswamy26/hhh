using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emulatorpractice.StepDefinitions
{
    public class Class1
    {
        [Given(@"open app and go")]
        public void GivenOpenAppAndGo()
        {
           Thread.Sleep(1000);
        }

    }
}
