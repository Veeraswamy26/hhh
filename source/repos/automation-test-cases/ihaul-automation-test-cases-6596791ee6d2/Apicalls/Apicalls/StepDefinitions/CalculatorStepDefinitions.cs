
using RestSharp;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Net;
using Gherkin;
using Newtonsoft.Json.Linq;

namespace Apicalls.StepDefinitions
{
  
    public class ApiTestingSteps:UserDataTests
    {
        public RestClient _client;
        public RestRequest _request;
        public RestResponse _response;
       
        [Given(@"end point is""([^""]*)""")]
        public void GivenEndPointIs(string p0)
        {
            _client = new RestClient(p0);
            _request = new RestRequest();
            _request.Method = Method.Get;
        }
        
        [When(@"pass authorization header")]
        public void WhenPassAuthorizationHeader()
        {
            // Add the Authorization header with the Bearer token
            _request.AddHeader("Authorization", $"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzIxMjA2NjM4LCJleHAiOjE3NTI3NDI2Mzh9.aP1PBb8dgBRg_LsZs1LD_nFlNtRM6STAbrUvGCInmVY");
        }

        [When(@"send get request give me details")]
        public void WhenSendGetRequestGiveMeDetails()
        {
            _response = _client.Execute(_request);
        }


        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)_response.StatusCode);
        }

        [Then(@"the response content should contain expected")]
        public void ThenTheResponseContentShouldContainExpected()
        
        {
            // Check if the response content is not null or empty
            Assert.IsNotNull(_response.Content, "Response content is null.");
            Assert.IsNotEmpty(_response.Content, "Response content is empty.");

            // Print the full response content to the console
            Console.WriteLine("Full Response Content:");
            Console.WriteLine(_response.Content);

            // Check if the response contains the expected text
            bool containsText = _response.Content.Contains("9441474329");
            Assert.IsTrue(containsText, $"Expected text '{"9441474329"}' not found in response. Actual response content: {_response.Content}");
        }
    

[Then(@"print all phone numbers and emails from the responsee")]
    public void ThenPrintAllPhoneNumbersAndEmailsFromTheResponsee()
    {
            GetData();
        //// Ensure the response content is not null or empty
        //Assert.IsNotNull(_response.Content, "Response content is null.");
        //Assert.IsNotEmpty(_response.Content, "Response content is empty.");

        //// Parse the JSON response
        //var jsonResponse = JObject.Parse(_response.Content);

        //// Check for successful status
        //Assert.AreEqual(200, (int)jsonResponse["status"], "Status code is not 200.");

        //// Access the data array
        //var users = jsonResponse["data"] as JArray;
        //if (users == null)
        //{
        //    Assert.Fail("The 'data' property is not an array.");
        //}

        //// Iterate through each user and print phone numbers and emails
        //foreach (var user in users)
        //{
        //    var phoneNumber = user["phoneNumber"]?.ToString();
        //    var email = user["email"]?.ToString();

        //    // Ensure phoneNumber and email are not null
        //    Assert.IsNotNull(phoneNumber, "Phone number is null.");
        //    Assert.IsNotNull(email, "Email is null.");

        //    // Print the phone number and email
        //    Console.WriteLine($"Phone Number: {phoneNumber}, Email: {email}");
               
            }
        }
    }
      

 
