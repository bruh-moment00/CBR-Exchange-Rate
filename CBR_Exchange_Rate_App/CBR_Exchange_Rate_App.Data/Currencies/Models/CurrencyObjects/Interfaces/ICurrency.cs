using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Currencies.Models.CurrencyObjects.Interfaces
{
    public interface ICurrency
    {
        string Name { get; set; }
        double Value { get; set; }
    }
}
