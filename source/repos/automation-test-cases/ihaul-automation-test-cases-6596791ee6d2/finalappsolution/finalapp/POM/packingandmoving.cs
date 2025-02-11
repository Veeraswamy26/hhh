using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalapp.POM
{
    public class packingandmoving: UserDataTests
    
    {
        public void summary()
        {
            driver.FindElement(By.XPath("//android.widget.ImageView[@index=1]")).Click();
            //driver.FindElement(By.XPath("//*[@elementId='00000000-0000-0025-0000-019f00000004']")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"17, Thursday, October 17, 2024\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("(//android.view.View[@index=6])[1]")).Click();
            driver.FindElement(By.XPath("//android.widget.RadioButton[@content-desc=\"AM\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@index=7]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"OK\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@index=9]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Upload From Gallery\"]")).Click();
            driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.android.documentsui:id/icon_thumb\"])[1]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.ScrollView/android.view.View[2]/android.widget.RadioButton[1]")).Click();
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Select\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Items needs to be boxed\"]")).Click();
            driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"smallBoxes-Type here\"]")).Click();
            AndroidElement small = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"smallBoxes-Type here\"]"));
            small.Click();
            small.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smalll = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"mediumBoxes-Type here\"]"));
            smalll.Click();
            smalll.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smallll = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"largeBoxes-Type here\"]"));
            smallll.Click();
            
            smallll.SendKeys("6");
            driver.Navigate().Back();
            AndroidElement smal = driver.FindElement(By.XPath("//android.widget.EditText[@resource-id=\"xLargeBoxes-Type here\"]"));
            smal.Click();
            smal.SendKeys("6");
            driver.Navigate().Back();
       

            driver.FindElement(By.XPath("//android.widget.ScrollView/android.view.View[4]/android.widget.RadioButton[1]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Save & Next\"]")).Click();
            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue\"]")).Click();
        }
    }
}
