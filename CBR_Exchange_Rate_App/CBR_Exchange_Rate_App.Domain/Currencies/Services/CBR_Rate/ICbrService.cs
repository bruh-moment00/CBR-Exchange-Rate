using CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects;
using Result2;

namespace CBR_Exchange_Rate_App.Domain.Services.CBR_Rate
{
    public interface ICbrCurrenciesService
    {
        public IResult<CbrCurrency> ReturnCurrencyById(string id);
        public IResult<IEnumerable<CbrCurrency>> ReturnCurrencies();
    }
}
