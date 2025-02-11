using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using RestSharp;

namespace apiappium
{
    [TestFixture]
    public class Hooks
    {
        private AndroidDriver<AndroidElement> driver;
        private RestClient client;
        private const string BaseUrl = "https://api.example.com"; // Replace with your API base URL

        [SetUp]
        public void Setup()
        {
            // Appium setup
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "samsung");
            appiumOptions.AddAdditionalCapability("platform Version", "13");
            appiumOptions.AddAdditionalCapability("udid", "RZ8NA1HKZ0B");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            appiumOptions.AddAdditionalCapability("app", "C:\\Users\\iray3\\ihaulrelease\\3-3-2024.apk"); // Replace with the path to your APK file

            // Initialize driver
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);

            // Initialize RestClient for API requests
            client = new RestClient(BaseUrl);
        }

        [Test]
        public void TestApiWithMobileApp()
        {
            // Perform actions on the mobile app (using Appium)
            // Example: Click a button or perform a gesture
            // driver.FindElementById("buttonId").Click();

            // Make an API request to verify something
            var request = new RestRequest("/api/endpoint", Method.Get);

            // Execute the request
            IRestResponse response = client.Execute(request);

            // Assert API response
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.True(response.Content.Contains("ExpectedContent")); // Adjust based on your API response
        }

        [TearDown]
        public void Cleanup()
        {
            // Clean up
            driver.Quit();
        }
    }
}
