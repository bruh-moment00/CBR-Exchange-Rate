using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
//using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.ApiClient
{
    public class ApiClient : IApiClient
    {
        private readonly string _apiUrl;
        public ApiClient(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        string IApiClient.Get(string path)
        {
            //using (var request = new HttpRequest())
            //{
            //    request.Get(/*_apiUrl + path*/"https://www.cbr-xml-daily.ru/daily_json.js");
            //    HttpResponse httpResponse = request.Response;
            //    return httpResponse.ToString();
            //}
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://www.cbr-xml-daily.ru/daily_json.js");
                var result = httpClient.GetAsync("").Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
