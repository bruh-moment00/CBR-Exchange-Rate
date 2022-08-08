using CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects;
using CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Data.Currencies.Repositories.CBR;
using Result2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Services.CBR_Rate
{
    public class CbrCurrenciesService : ICbrCurrenciesService
    {
        private readonly ICbrRepository _cbrRepository;
        public CbrCurrenciesService(ICbrRepository cbrRepository)
        {
            _cbrRepository = cbrRepository;
        }
        public IResult<CbrCurrency> ReturnCurrencyById(string id)
        {
            CbrApiCurrenciesResponse cbrCurrencies = _cbrRepository.getDataFromApi();
            return Result.Success(cbrCurrencies.GetCurrenciesList().Where(o => o.Id == id).FirstOrDefault()); 
        }

        public IResult<IEnumerable<CbrCurrency>> ReturnCurrencies()
        {
            CbrApiCurrenciesResponse cbrCurrencies = _cbrRepository.getDataFromApi();
            return Result.Success(cbrCurrencies.GetCurrenciesList());
        }
    }
}
