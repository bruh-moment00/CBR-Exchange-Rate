using CBR_Exchange_Rate_App.Data.Models.ResponseObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBR_Exchange_Rate_App.Data.Models.ResponseObjects
{
    public class CbrResponseObject : IResponseObject
    {
        public int Id { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }

        public CbrResponseObject(int id, string numCode, string charCode, int nominal, string name, double value, double previous)
        {
            Id = id;
            NumCode = numCode;
            CharCode = charCode;
            Nominal = nominal;
            Name = name;
            Value = value;
            Previous = previous;
        }
    }
}
