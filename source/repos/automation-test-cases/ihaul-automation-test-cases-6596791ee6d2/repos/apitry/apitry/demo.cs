using System;
using NUnit.Framework; // Using NUnit for testing framework
using RestSharp;

[TestFixture]
public class ApiTests
{
    private RestClient _client;

    [SetUp]
    public void Setup()
    {
        _client = new RestClient("http://15.206.27.64/api/v1/admin/getAllUsers"); // Replace with your API base URL
    }

    [Test]
    public void Test_GetRequest()
    {
        // Arrange
        var request = new RestRequest("/users/{userId}", Method.Get);
        request.AddUrlSegment("userId", "1"); // Replace with actual userId

        // Act
        IRestResponse response = _client.Execute(request);

        // Assert
        object value = Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);
        Assert.IsTrue(response.Content.Contains("John Doe")); // Example assertion based on expected response content
    }
}

