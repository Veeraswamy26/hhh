using ihaullaunch.Hooks;
using ihaullaunch.utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihaullaunch.StepDefinitions
{
    public class ihaul : Hooks1
    {
       
        [Given(@"click on skip ""([^""]*)""")]
        public void GivenClickOnSkip(string skip)
        {
            Thread.Sleep(4000);
            //use implicit waits 
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Skip\"]")).Click();
        }
        [When(@"click on ""([^""]*)""")]
        public void WhenClickOn(string getstarted)
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Get Started\"]")).Click();
        }
        [When(@"scrool up")]
        public void WhenScroolUp()
        {
            doswipee();
        }
        [When(@"click on continoue as ""([^""]*)""")]
        public void WhenClickOnContinoueAs()
        {
            Thread.Sleep(6000);
            //driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue As guest\"]")).Click();
            driver.FindElementByAccessibilityId("Continue As guest");
        }

        [When(@"click on arrow""([^""]*)""")]
        public void WhenClickOnArrow(string arrow)
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//android.widget.FrameLayout[@resource-id=\"android:id/content\"]/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.widget.ImageView")).Click();

        }


        //[When(@"page get back")]
        //public void WhenPageGetBack()
        //{
        //    driver.Navigate().Back();
        //    //driver.Navigate().Back();
        //    //driver.Navigate().Back();
        //}
        //[Then(@"observe page is exists")]
        //public void ThenObservePageIsExists()
        //{
        //    bool Actual_value = driver.FindElement(By.ClassName("android.widget.ImageView")).Displayed;
        //    Assert.IsTrue(Actual_value, "Page is loaded.");
        //    if (Actual_value) {
        //        Console.WriteLine("Text is validated succes fully");
        //        Console.WriteLine("HttpRequestOptionsKey");
        //    }
        //}
        //Secure Transactions Pay securely through our app.Your payment details are safe with us
        //[Then(@"validate text")]
        //public void ThenValidateText()
        //{
        
        //        // Navigate to the screen where the text validation is needed
        //        // Assuming you are already on the screen or navigating to it

        //        // Locate the text element
        //        var textElement = driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Secure Transactions\r\nPay securely through our app. Your payment details are safe with us.\"]")); // Replace with your element's ID

        //        // Get the actual text from the element
        //        string actualText = textElement.Text;

        //        // Define the expected text
        //        string expectedText = "Secure Transactions Pay securely through our app.Your payment details are safe with us"; // Replace with the expected text

        //        // Assert that the actual text matches the expected text
        //        Assert.AreEqual(expectedText, actualText, "The text on the UI/UX screen does not match the expected text.");
        //        if (actualText == expectedText)
        //        {
        //            Console.WriteLine("Text is validated succes fully");
        //            Console.WriteLine(actualText);
        //        }
          // }
        }
    }





    //        //[When(@"Swipe  page to page")]
    //        //public void WhenSwipePageToPage()

    //        //{
    //        //    doswipe();
    //        //    doswipe();
    //        //}

    //        //[Then(@"Click on ""([^""]*)"" Button on Welcome page")]
    //        //public void ThenClickOnButtonOnWelcomePage(string next)

    //        //    // mark
    //        //{
    //        //    driver.FindElement(By.XPath("//android.widget.Button[@content-desc=\"Next\"]")).Click();
    //        //}
    //        [When(@"click on continoue as guest")]
    //        public void WhenClickOnContinoueAsGuest()
    //        {
    //            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Continue As guest\"]")).Click();
    //        }

    //        [When(@"click on about us")]
    //        public void WhenClickOnAboutUs()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"About Us\"]")).Click();
    //        }
    //        [When(@"click on the""([^""]*)""")]
    //        public void WhenClickOnThe(string p0)
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView")).Click();
    //        }

    //        [When(@"click on terms of use")]
    //        public void WhenClickOnTermsOfUse()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Terms of Use\"]")).Click();
    //        }

    //        [When(@"click on privacy policy")]
    //        public void WhenClickOnPrivacyPolicy()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Privacy Policy\"]")).Click();
    //        }

    //        [When(@"click on change password")]
    //        public void WhenClickOnChangePassword()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Change Password\"]")).Click();
    //        }

    //        [When(@"click on notification setting")]
    //        public void WhenClickOnNotificationSetting()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Notification Settings\"]")).Click();
    //        }

    //        [When(@"click on contact admin")]
    //        public void WhenClickOnContactAdmin()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Contact Admin\"]")).Click();
    //        }

    //        [When(@"click on Faq")]
    //        public void WhenClickOnFaq()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"FAQs\"]")).Click();
    //        }

    //        [When(@"click on delete acc")]
    //        public void WhenClickOnDeleteAcc()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Delete Account\"]")).Click();
    //        }
    //        [When(@"click on thee ""([^""]*)""")]
    //        public void WhenClickOnThee(string cancel)
    //        {
    //            driver.FindElement(By.XPath("//android.view.View[@content-desc=\"Cancel\"]")).Click();
    //        }

    //        [When(@"click on log out")]
    //        public void WhenClickOnLogOut()
    //        {
    //            driver.FindElement(By.XPath("//android.widget.ImageView[@content-desc=\"Logout\"]")).Click();
    //        }


    

