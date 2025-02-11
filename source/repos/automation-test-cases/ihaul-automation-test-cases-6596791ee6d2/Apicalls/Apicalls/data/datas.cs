using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Apicalls.StepDefinitions;

    public class UserDataTests
    {
        private RestClient _client;
        private RestRequest _request;
        private RestResponse _response;

        // Method to fetch and extract data
        public List<(string PhoneNumber, string Email)> GetData()
        {
            _client = new RestClient("http://15.206.27.64/api/v1/admin/getAllUsers");
            _request = new RestRequest();
            _request.Method = Method.Get;
            _request.AddHeader("Authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzIxMjA2NjM4LCJleHAiOjE3NTI3NDI2Mzh9.aP1PBb8dgBRg_LsZs1LD_nFlNtRM6STAbrUvGCInmVY");
            _response = _client.Execute(_request);

            // Check if the response content is not null or empty
            Assert.IsNotNull(_response.Content, "Response content is null.");
            Assert.IsNotEmpty(_response.Content, "Response content is empty.");

            // Parse the JSON response
            var jsonResponse = JObject.Parse(_response.Content);

            // Check for successful status
            Assert.AreEqual(200, (int)jsonResponse["status"], "Status code is not 200.");

            // Access the data array
            var users = jsonResponse["data"] as JArray;
            Assert.IsNotNull(users, "The 'data' property is not an array.");

            // Extract phone numbers and emails
            var userData = new List<(string PhoneNumber, string Email)>();
            foreach (var user in users)
            {
                var phoneNumber = user["phoneNumber"]?.ToString();
                var email = user["email"]?.ToString();

                // Ensure phoneNumber and email are not null
                Assert.IsNotNull(phoneNumber, "Phone number is null.");
                Assert.IsNotNull(email, "Email is null.");

                // Display the data in the console
                Console.WriteLine($"Phone Number: {phoneNumber}, Email: {email}");

                // Add to the list
                userData.Add((phoneNumber, email));
            }

            // Return the extracted data
            return userData;
        }

        [Test]
        public void TestMobileNumberInResponse()
        {
            // Call GetData to fetch and extract data
            var userData = GetData();

            // Define the mobile number to check
            string enteredMobileNumber = "12345678909";

            // Check if the entered mobile number exists in the extracted data
            bool isMobileNumberInResponse = userData.Any(user => user.PhoneNumber == enteredMobileNumber);

            // Assert that the mobile number is found in the response data
            Assert.IsTrue(isMobileNumberInResponse, "The entered mobile number was not found in the response data.");
        }
    }
