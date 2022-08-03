using CBR_Exchange_Rate_App.Data.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Pagination
{
    public class PaginatedResponse<TSource>
    {
        int PageSize { get; set; }
        int PageIndex { get; set; }
        int TotalCount { get; }
        int PagesCount { get; }
        IResponse<TSource> Response { get; }

        public PaginatedResponse(int pageSize, int pageIndex, IResponse<TSource> response)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            Response = response;
            TotalCount = response.TotalCount;
            PagesCount = Convert.ToInt16(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
        }

    }
}
