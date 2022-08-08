using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects;

namespace CBR_Exchange_Rate_App.Data.Currencies.Repositories.CBR
{
    public class CbrRepository : ICbrRepository
    {
        private readonly IApiClient _apiClient;
        public CbrRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public CbrApiCurrenciesResponse getDataFromApi()
        {
            var result = _apiClient.Get("");
            return JsonConvert.DeserializeObject<CbrApiCurrenciesResponse>(result);
        }
    }
}
