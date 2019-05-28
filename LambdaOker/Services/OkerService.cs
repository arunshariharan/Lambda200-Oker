using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace LambdaOker.Services
{
    public class OkerService
    {
        public static async Task<List<FailedResponse>> CheckStatusForUrls(List<string> urls)
        {
            List<FailedResponse> failedResponses = new List<FailedResponse>();

            foreach (var url in urls)
            {
                HttpResponseMessage response = await GetResponseFor(url);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine($"Failed Url: {url}, ErrorCode: {response.StatusCode}, ErrorMessage: {response.ReasonPhrase}");

                    failedResponses.Add(new FailedResponse
                    {
                        Url = url,
                        ErrorCode = response.StatusCode,
                        ErrorMessage = response.ReasonPhrase
                    });

                }
            }

            return failedResponses;
        }

        private static async Task<HttpResponseMessage> GetResponseFor(string input)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HttpClient client = new HttpClient();         

            try
            {
                response = await client.GetAsync(input);
            }
            catch (Exception e)
            {
                response.StatusCode = (HttpStatusCode)400;
                response.ReasonPhrase = $"{e.Message.ToString()}, Exception Type: {e.GetType().FullName}, Source: {e.Source}";
            }

            return response;
        }
        
    }
}
