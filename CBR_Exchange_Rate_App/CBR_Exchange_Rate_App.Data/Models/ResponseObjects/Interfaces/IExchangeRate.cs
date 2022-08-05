using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces
{
    public interface IExchangeRate
    {
        string Name { get; set; }
        double Value { get; set; }
    }
}
