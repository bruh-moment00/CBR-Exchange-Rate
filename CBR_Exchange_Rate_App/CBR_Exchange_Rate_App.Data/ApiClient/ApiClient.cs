using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
using Leaf.xNet;
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
        internal ApiClient(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        string IApiClient.Get(string path)
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();

                HttpResponse httpResponse = request.Get(_apiUrl + path);
                return httpResponse.ToString();
            }
        }
    }
}
