using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.ApiClient.Interfaces
{
    public interface IApiClient
    {
        public string Get(string path);
    }
}
