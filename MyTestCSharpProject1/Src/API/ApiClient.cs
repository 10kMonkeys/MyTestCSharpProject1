using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Xunit;

namespace MyTestCSharpProject1.Src.API
{
    public class ApiClient
    {
        private RestClient restClient;
        //private RestRequest restRequest;
        private readonly string baseUrl;

        public ApiClient()
        {
            baseUrl = "https://reqres.in"; // should be the line of code below in real world 
            //baseUrl = Environment.GetEnvironmentVariable("Env");
            //restClient = new RestClient(baseUrl);

            var options = new RestClientOptions("https://reqres.in")
            {
                ThrowOnAnyError = true,
                Timeout = 1000
            };

            var headers = new Dictionary<string, string>()
            {
                { "Content-Type", "application/json; charset=utf-8" }
            };

            restClient = new RestClient(options).
                AddDefaultHeaders(headers);
        }

        public RestRequest CreatePostRequest<T>(string urn, T payload)
        {
            var restRequest = new RestRequest(urn, Method.Post).
                AddBody(payload);
            
            return restRequest;
        }

        public RestRequest CreateGetRequest(string urn)
        {
            var restRequest = new RestRequest(urn, Method.Get);

            return restRequest;
        }

        internal async Task<RestResponse> GetResponseAsync(RestRequest restRequest)
        {
            var response = await restClient.ExecuteAsync(restRequest);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.";
                throw new ApplicationException(message, response.ErrorException);
            }

            return response;
        }

        public RestResponse GetResponse(RestRequest restRequest)
        {
            var response = restClient.ExecuteAsync(restRequest).GetAwaiter().GetResult();
            var statusCode = (int)response.StatusCode;

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.";
                throw new ApplicationException(message, response.ErrorException);
            }

            //Assert.Equal(201, statusCode);

            return response; 
        }

        public T GetContent<T>(RestResponse response)
        {
            var content = response.Content;
            T dtoObject = JsonConvert.DeserializeObject<T>(content);

            return dtoObject;
        }
    }
}
