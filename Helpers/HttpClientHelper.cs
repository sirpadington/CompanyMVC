using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace InterviewPractice.Sites.MVC.Helpers
{
    public static class HttpClientHelper
    {
        private static Uri companyServiceBaseAddress = new Uri("http://localhost:6766/api/");
        public static HttpResponseMessage GetResponse(MediaTypeWithQualityHeaderValue MediaType, string url)
        {
            var client = new HttpClient();
            client.BaseAddress = companyServiceBaseAddress;
            client.DefaultRequestHeaders.Accept.Add(MediaType);
            return client.GetAsync(url).Result;
        }
    }
}