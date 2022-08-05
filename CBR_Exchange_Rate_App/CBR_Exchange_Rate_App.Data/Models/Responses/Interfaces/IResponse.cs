using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models.Responses.Interfaces
{
    public interface IResponse<ExchangeRate>
    {
        int TotalCount { get; }
        IEnumerable<ExchangeRate> GetResponseObjects();
    }
}
