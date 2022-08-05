using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using CBR_Exchange_Rate_App.Data.Models.Responses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Models.Pagination
{
    public class PaginatedData
    {
        int PageSize { get; set; }
        int PageIndex { get; set; }
        int TotalCount { get; }
        int PagesCount { get; }
        IEnumerable<IResponseObject> ExchangeRates { get; }

        public PaginatedData(int pageSize, int pageIndex, IResponse response)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            ExchangeRates = response.GetResponseObjects();
            TotalCount = response.TotalCount;
            PagesCount = Convert.ToInt16(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
        }

    }
}
