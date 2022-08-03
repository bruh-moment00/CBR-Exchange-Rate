using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models
{
    public class Response
    {
        public IEnumerable<IResponseObject> ResponseObjects { get; set; }
        public int TotalCount { get; }
        public Response(IEnumerable<IResponseObject> response)
        {
            ResponseObjects = response;
            TotalCount = ResponseObjects.Count();
        }
    }
}
