using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBR_Exchange_Rate_App.Data.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Domain.Models.Pagination;
using Result2;

namespace CBR_Exchange_Rate_App.Domain.Services.CBR_Rate
{
    public interface ICbrService
    {
        public IResult<CbrExchangeRate> ReturnExchangeRateById(string id);
        public IResult<IEnumerable<CbrExchangeRate>> ReturnExchangeRates();
    }
}
