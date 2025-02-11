using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;

namespace YourNamespace.Tests
{
    [TestFixture]
    public class ApiTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient("http://15.206.27.64/"); // Replace with your API base URL
        }

        [Test]
        public void Test_GetAllUsers()
        {
            var request = new RestRequest("api/v1/admin/getAllUsers", Method.GET);
            request.AddHeader("Authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzE5OTE2MTExLCJleHAiOjE3NTE0NTIxMTF9.JydEy7r__28_5CBNBGoPxmDgUILcmq_QYz_CoBOj9yk");
            request.AddHeader("Accept", "application/json");

            // Act
            IRestResponse response = _client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));

            // Deserialize JSON response
            var content = response.Content;
            var userList = JsonConvert.DeserializeObject<UserList>(content);

            // Perform assertions on deserialized object
            Assert.IsNotNull(userList);
            Assert.IsNotNull(userList.data);
            Assert.IsTrue(userList.data.Count > 0);
        }
    }

    // Define classes for deserialization
    public class User
    {
        public long Status { get; set; }
        public string Message { get; set; }
        public List<Datum> Data { get; set; }
    }

    public class Datum
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        public string ReferralCode { get; set; }
        public NotificationSettings NotificationSettings { get; set; }
        public string ProfilePicture { get; set; }
        public string Pin { get; set; }
        public string InviteCode { get; set; }
        public string ResetPassToken { get; set; }
        public string EmailOtp { get; set; }
        public string PhoneNumberOtp { get; set; }
        public string EmailSent { get; set; }
        public string PhoneNumberSent { get; set; }
        public string StripeCusId { get; set; }
        public bool IsDiscountApplicable { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsApprovedByAdmin { get; set; }
        public bool IsProfileUpdated { get; set; }
        public bool IsVehicleDetailsUpdated { get; set; }
        public bool IsW9FormUpdated { get; set; }
        public string SocketId { get; set; }
        public string StripeAccId { get; set; }
        public string TotalCanceledMove { get; set; }
        public string MoverStatus { get; set; }
        public string MoverType { get; set; }
        public string BusinessTaxId { get; set; }
        public object CheckList { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset LastLoginTime { get; set; }
    }

    public class NotificationSettings
    {
        public bool NewOfferReceived { get; set; }
        public bool MoveUpdate { get; set; }
    }

    public class UserList
    {
        public List<User> data { get; set; }
    }
}
