using CBR_Exchange_Rate_App.Data.ApiClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CBR_Exchange_Rate_App.Data.Models.Responses;

namespace CBR_Exchange_Rate_App.Data.Repositories.CBR
{
    public class CbrRepository : ICbrRepository
    {
        private readonly IApiClient _apiClient;
        public CbrRepository(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public CbrFullResponse getDataFromApi()
        {
            var result = _apiClient.Get("");
            return JsonConvert.DeserializeObject<CbrFullResponse>(result);
        }
    }
}
