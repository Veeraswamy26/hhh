using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APITestProject
{
    public class APITests
    {
        private const string BaseUrl = "http://15.206.27.64/api/v1/auth/appLogin";

        [Fact]
        public async Task TestPostEndpoint()
        {
            // Arrange
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);

                try
                {
                    // Act
                    // Example: Create JSON content for POST request (replace with actual content)
                    var jsonContent = new StringContent("{\"username\": \"veeraswamy@iray.com\", \"password\": \"123456\"}", Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("api/resource", jsonContent);
                    response.EnsureSuccessStatusCode(); // Throws exception if HTTP response status is not 2xx

                    // Assert
                    Assert.True(response.IsSuccessStatusCode, "Expected successful status code");
                }
                catch (HttpRequestException ex)
                {
                    Assert.True (false, $"Request exception: {ex.Message}");
                }
            }
        }
    }
}
