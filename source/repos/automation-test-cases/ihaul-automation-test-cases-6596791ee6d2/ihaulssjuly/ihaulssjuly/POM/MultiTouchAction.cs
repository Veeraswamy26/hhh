using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace ihaulssjuly.POM
{
    internal class MultiTouchAction
    {
        private AppiumDriver<AndroidElement> driver;

        public MultiTouchAction(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        internal object Add(TouchAction finger1)
        {
            throw new NotImplementedException();
        }

        internal void Perform()
        {
            throw new NotImplementedException();
        }
    }
}