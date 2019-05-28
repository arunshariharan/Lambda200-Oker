using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LambdaOker
{
    public class FailedResponse
    {
        public string Url { get; set; }
        public HttpStatusCode ErrorCode {get; set;}
        public string ErrorMessage { get; set; }
    }
}
