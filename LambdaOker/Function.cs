using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using LambdaOker.Services;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LambdaOker
{
    public class Function
    {
        public async Task<HttpStatusCode> FunctionHandler(ILambdaContext context)
        {
            var urls = FileReader.GetUrlsFromFile();

            var failedResponses = await OkerService.CheckStatusForUrls(urls);

            if (failedResponses.Count == 0)
                return HttpStatusCode.OK;

            throw new Exception("One or more of the URLs failed to return 200 OK. Please check cloudwatch logs for more details.");
        }

        

    }

}
