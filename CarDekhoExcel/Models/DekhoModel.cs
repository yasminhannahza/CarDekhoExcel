using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDekhoExcel.Models
{
    public class DekhoModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double SellingPrice { get; set; }
        public double DrivenKM { get; set; }
        public string Fuel { get; set; }
        public string SellerType { get; set; }
        public string Transmission { get; set; }
        public string Owner { get; set; }
    }
}
