using System;
using System.Net;
using Newtonsoft.Json;

namespace Claytondus.ShippyPro.Models
{
    public class ShippyProException : Exception
    {
        [JsonConstructor]
        public ShippyProException(string type, string message) : base(message)
        {
            ShippyProType = type;
            ResponseBody = message;
        }

        public string ShippyProType { get; set; }
        public string? RequestBody { get; set; }
        public string ResponseBody { get; set; }

        public HttpStatusCode? HttpStatus { get; set; }

        public string? Method { get; set; }
        public string? Resource { get; set; }
        public string? HttpMessage { get; set; }


    }
}
