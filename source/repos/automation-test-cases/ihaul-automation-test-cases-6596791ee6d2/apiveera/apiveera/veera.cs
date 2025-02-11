using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiveera
{
    public class veera
    {
        public list Getdetails()
        {

            var restClient = new RestClient("http://15.206.27.64/");
            var restRequest = new RestRequest("api/v1/admin/getAllUsers", Method.GET);
            restRequest.AddHeader("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJfaWQiOiI2NWI4ZTFiMWZkNzI3N2Q1ZTM3MTE3NGEiLCJlbWFpbCI6ImFkbWluQGlyYXkuY29tIiwiaWF0IjoxNzE5OTE2MTExLCJleHAiOjE3NTE0NTIxMTF9.JydEy7r__28_5CBNBGoPxmDgUILcmq_QYz_CoBOj9yk", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var details = JsonConvert.DeserializeObject<list>(content);
            return details;

        }
    }
}
