using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.MultiTouch;

namespace iHaulautomation.POM
{
    public class bookinghaul: signuppage
    {
        public void Booking()
        {
            AndroidElement logout = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Set Pick Up & Drop Location\"]");
            logout.Click();
            AndroidElement addpickup = driver.FindElementByXPath("//android.view.View[@content-desc=\"Add details\"]");
            addpickup.Click();
            AndroidElement sel = driver.FindElementByXPath("//android.view.View[@content-desc=\"Select\"]");
            sel.Click();
            AndroidElement search = driver.FindElementByXPath("//android.widget.ImageView[@index=2]");
            search.Click();
            search.SendKeys("USA");
            Thread.Sleep(3000);
            AndroidElement location = driver.FindElementByXPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[3]");
            location.Click();
            Thread.Sleep(10000);
            AndroidElement addmore = driver.FindElementByXPath("//android.view.View[@index=5]");
            addmore.Click();
        }

    }
}
