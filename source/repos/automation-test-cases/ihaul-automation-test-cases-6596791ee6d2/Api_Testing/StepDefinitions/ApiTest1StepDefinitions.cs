using System;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Infrastructure;
using Newtonsoft.Json;
using Api_Testing.Support;
using System.Net.Http.Headers;

namespace Api_Testing.StepDefinitions
{
    [Binding]
    public class ApiTest1StepDefinitions : DataModel
    {
        public readonly HttpClient httpClient;
        public HttpResponseMessage response;
        public string responsebody;
        public readonly ISpecFlowOutputHelper specFlowOutputHelper;
        public  const string JwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzIxMjA2NjM4LCJleHAiOjE3NTI3NDI2Mzh9.aP1PBb8dgBRg_LsZs1LD_nFlNtRM6STAbrUvGCInmVY";

        public ApiTest1StepDefinitions(ISpecFlowOutputHelper specFlowOutputHelper)
        {
            this.specFlowOutputHelper = specFlowOutputHelper;
            httpClient = new HttpClient { BaseAddress = new Uri("http://15.206.27.64") };
        }

        [Given(@"the API endpoint is set up")]
        public void GivenTheApiEndpointIsSetUp()
        {
            // This step can be used to initialize or log the setup process
            specFlowOutputHelper.WriteLine("API endpoint is set up.");
        }

        [When(@"the user sends a GET request to ""([^""]*)"" with JWT token")]
        public async Task WhenTheUserSendsAGetRequestToWithJwtToken(string uri)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzIxMjA2NjM4LCJleHAiOjE3NTI3NDI2Mzh9.aP1PBb8dgBRg_LsZs1LD_nFlNtRM6STAbrUvGCInmVY", JwtToken);
                response = await httpClient.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                responsebody = await response.Content.ReadAsStringAsync();
                specFlowOutputHelper.WriteLine(responsebody);

                var deserializedData = JsonConvert.DeserializeObject<DataModel.Rootobject>(responsebody);
                specFlowOutputHelper.WriteLine("After deserialization, object value is: " + deserializedData.Datum.ToString());

                foreach (var item in deserializedData.Datum)
                {
                    specFlowOutputHelper.WriteLine(item.FirstName.ToString());
                }
            }
            catch (HttpRequestException e)
            {
                specFlowOutputHelper.WriteLine("Request error: " + e.Message);
                Assert.Fail("Request error: " + e.Message);
            }
            catch (Exception e)
            {
                specFlowOutputHelper.WriteLine("Unexpected error: " + e.Message);
                Assert.Fail("Unexpected error: " + e.Message);
            }
        }

        [Then(@"the response should be successful with status code (.*)")]
        public void ThenTheResponseShouldBeSuccessfulWithStatusCode(int statusCode)
        {
            Assert.IsNotNull(response, "Response is null");
            Assert.AreEqual(statusCode, (int)response.StatusCode, $"Expected status code: {statusCode}, but got: {(int)response.StatusCode}");
        }
    }
}
