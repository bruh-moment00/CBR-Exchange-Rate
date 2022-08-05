using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using CBR_Exchange_Rate_App.Data.Models.Responses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Models.Pagination
{
    public class PaginatedData<ExchangeRate>
    {
        int PageSize { get; set; }
        int PageIndex { get; set; }
        int TotalCount { get; }
        int PagesCount { get; }
        IEnumerable<ExchangeRate> ExchangeRates { get; }

        public PaginatedData(int pageSize, int pageIndex, IResponse<ExchangeRate> response)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            TotalCount = response.TotalCount;
            PagesCount = Convert.ToInt16(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
            ExchangeRates = response.GetResponseObjects().Skip(PageIndex*PageSize).Take(PageSize);
        }

    }
}
