using CBR_Exchange_Rate_App.Data.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using CBR_Exchange_Rate_App.Data.Models.Responses;
using CBR_Exchange_Rate_App.Data.Repositories.CBR;
using CBR_Exchange_Rate_App.Domain.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Services.CBR_Rate
{
    public class CbrService : ICbrService
    {
        private readonly ICbrRepository _cbrRepository;
        public CbrService(ICbrRepository cbrRepository)
        {
            _cbrRepository = cbrRepository;
        }
        public CbrExchangeRate ReturnExchangeRateById(string id)
        {
            CbrFullResponse cbrExchangeRates = _cbrRepository.getDataFromApi();
            return cbrExchangeRates.GetResponseObjects().Where(o => o.Id == id).FirstOrDefault();
        }

        public PaginatedData<CbrExchangeRate> ReturnExchangeRatesPaginated(int pageSize = 5, int pageIndex = 1)
        {
            CbrFullResponse cbrExchangeRates = _cbrRepository.getDataFromApi();
            return new PaginatedData<CbrExchangeRate>(pageSize, pageIndex, cbrExchangeRates);
        }
    }
}
