using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iHaulautomation.POM
{
    public class signup1:loginpage
    {
        public void signups()
        {
            AndroidElement cust = driver.FindElementByXPath("//android.widget.ImageView[@index=3]");
            cust.Click();
            AndroidElement vfr = driver.FindElementByXPath("//android.view.View[@content-desc=\"Continue\"]");
            vfr.Click();

            AndroidElement upload = driver.FindElementByXPath("//android.widget.ImageView[@content-desc=\"Upload Photo\"]");
            upload.Click();

            AndroidElement uploadfrm = driver.FindElementByXPath("//android.view.View[@content-desc=\"Upload From Gallery\"]");
            uploadfrm.Click();

            AndroidElement uploadphoto = driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.google.android.providers.media.module:id/icon_thumbnail\"])[1]");
            uploadphoto.Click();

            AndroidElement photocrop = driver.FindElementByXPath("//android.widget.Button[@content-desc=\"Crop\"]");
            photocrop.Click();

            AndroidElement first = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[1]");
            first.Click();
            first.SendKeys("kalluri");
            driver.Navigate().Back();
            AndroidElement last = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[2]");
            last.Click();
            last.SendKeys("veera");
            AndroidElement mobile = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[3]");
            mobile.Click();
            mobile.SendKeys("147896325");
            driver.Navigate().Back();
            AndroidElement email = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[4]");
            email.Click();
            email.SendKeys("kvswamy@232o.com");
            driver.Navigate().Back();
            AndroidElement create = driver.FindElementByXPath("//android.widget.EditText[@index=3]");
            create.Click();
            create.SendKeys("123456");
            driver.Navigate().Back();
            AndroidElement confirm = driver.FindElementByXPath("//android.widget.ScrollView/android.view.View/android.widget.EditText[4]");
            confirm.Click();
            confirm.SendKeys("123456");
            driver.Navigate().Back();
            driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollToEnd(10);"));
            AndroidElement signup = driver.FindElementByXPath("//android.view.View[@content-desc=\"Sign Up\"]");
            signup.Click();
            Thread.Sleep(10000);
        }
    }
}
