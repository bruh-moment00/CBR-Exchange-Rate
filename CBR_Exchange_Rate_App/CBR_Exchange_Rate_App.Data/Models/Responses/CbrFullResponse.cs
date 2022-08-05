using CBR_Exchange_Rate_App.Data.Models.ResponseObjects;
using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using CBR_Exchange_Rate_App.Data.Models.Responses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models.Responses
{
    public class CbrFullResponse : IResponse
    {
        DateTime Date { get; set; }
        DateTime PreviousDate { get; set; }
        string PreviousUrl { get; set; }
        DateTime TimeStamp { get; set; }
        IDictionary<string, CbrResponseObject> Valute { get; set; }
        public int TotalCount { get; }
        public CbrFullResponse(DateTime date, DateTime previousDate, string previousUrl, DateTime timeStamp, IDictionary<string, CbrResponseObject> valute)
        {
            Date = date;
            PreviousDate = previousDate;
            PreviousUrl = previousUrl;
            TimeStamp = timeStamp;
            Valute = valute;
            TotalCount = valute.Count;
        }

        public IEnumerable<IResponseObject> GetResponseObjects()
        {
            return Valute as IEnumerable<CbrResponseObject>;
        }
    }
}
