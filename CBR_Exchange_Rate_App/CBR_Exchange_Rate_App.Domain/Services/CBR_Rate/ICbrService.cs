using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CBR_Exchange_Rate_App.Data.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Domain.Models.Pagination;

namespace CBR_Exchange_Rate_App.Domain.Services.CBR_Rate
{
    public interface ICbrService
    {
        public CbrExchangeRate ReturnExchangeRateById(string id);
        public PaginatedData<CbrExchangeRate> ReturnExchangeRatesPaginated(int pageSize, int pageIndex);
    }
}
