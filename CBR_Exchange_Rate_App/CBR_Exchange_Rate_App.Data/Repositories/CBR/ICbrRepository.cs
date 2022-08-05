using CBR_Exchange_Rate_App.Data.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Repositories.CBR
{
    public interface ICbrRepository
    {
        public CbrFullResponse getDataFromApi();
    }
}
