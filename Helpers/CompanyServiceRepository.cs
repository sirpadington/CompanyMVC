using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InterviewPractice.Sites.MVC.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using InterviewPractice.Sites.MVC.Helpers;
using System.Net;
using Newtonsoft.Json;
namespace InterviewPractice.Sites.MVC.Helpers
{
    public static class CompanyServiceRepository
    {
        private static MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");
        public static Company GetCompany(int Id)
        {
            var result = HttpClientHelper.GetResponse(mediaType, String.Format("Company/{0}", Id));
         
            if (result.StatusCode == HttpStatusCode.OK)
            {
                string responseString = result.Content.ToString();
                // parse to json
                var resultItem = JsonConvert.DeserializeObject<Company>(responseString);
                return resultItem;
            }

            return new Company();
        }
    }
}