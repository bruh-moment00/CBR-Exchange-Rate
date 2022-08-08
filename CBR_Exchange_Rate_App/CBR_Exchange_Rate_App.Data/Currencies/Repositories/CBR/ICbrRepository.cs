using CBR_Exchange_Rate_App.Data.Currencies.Models.ResponseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Currencies.Repositories.CBR
{
    public interface ICbrRepository
    {
        public CbrApiCurrenciesResponse getDataFromApi();
    }
}
