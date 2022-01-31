using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
   public class Goods
    {
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public double Weigth { get; set; }
       

        public Goods(decimal price, string barcode, double weigth)
        {
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            
        }
        public override string ToString()
        {
            return $"{Price} {Barcode} {Weigth}";
        }
    }
}
