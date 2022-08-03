using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models.Interfaces
{
    public interface IResponse<TSource>
    {
        IEnumerable<TSource> Response { get; set; }
        int TotalCount { get; }
    }
}
