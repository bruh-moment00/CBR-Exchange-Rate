using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.ApiClient
{
    public class CbrApiClient : IApiClient
    {
        private readonly string _apiUrl;
        public CbrApiClient(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        string IApiClient.Get(string path)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(_apiUrl);
                var result = httpClient.GetAsync(path).Result;
                return result.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
