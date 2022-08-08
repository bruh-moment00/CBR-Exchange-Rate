using CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects;
using CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects.Interfaces;

namespace CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects
{
    public class CbrApiCurrenciesResponse : IApiCurrenciesResponse<CbrCurrency>
    {
        DateTime Date { get; set; }
        DateTime PreviousDate { get; set; }
        string PreviousUrl { get; set; }
        DateTime TimeStamp { get; set; }
        IDictionary<string, CbrCurrency> Valute { get; set; }
        public int TotalCount { get; }
        public CbrApiCurrenciesResponse(DateTime date, DateTime previousDate, string previousUrl, DateTime timeStamp, IDictionary<string, CbrCurrency> valute)
        {
            Date = date;
            PreviousDate = previousDate;
            PreviousUrl = previousUrl;
            TimeStamp = timeStamp;
            Valute = valute;
            TotalCount = valute.Count;
        }

        public IEnumerable<CbrCurrency> GetCurrenciesList()
        {
            return Valute.Values;
        }
    }
}
