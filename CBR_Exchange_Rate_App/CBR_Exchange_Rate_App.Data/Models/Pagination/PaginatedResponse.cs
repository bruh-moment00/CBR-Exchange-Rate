using CBR_Exchange_Rate_App.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Domain.Models.Pagination
{
    public class PaginatedResponse
    {
        int PageSize { get; set; }
        int PageIndex { get; set; }
        int TotalCount { get; }
        int PagesCount { get; }
        Response Response { get; }

        public PaginatedResponse(int pageSize, int pageIndex, Response response)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            Response = response;
            TotalCount = response.TotalCount;
            PagesCount = Convert.ToInt16(Math.Ceiling(Convert.ToDouble(TotalCount) / Convert.ToDouble(PageSize)));
        }

    }
}
