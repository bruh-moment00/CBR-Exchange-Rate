using CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects.Interfaces
{
    public interface IApiCurrenciesResponse<Currency> where Currency : ICurrency
    {
        int TotalCount { get; }
        IEnumerable<Currency> GetCurrenciesList();
    }
}
