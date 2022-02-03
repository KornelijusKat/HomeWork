using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
   public class Goods
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public double Weigth { get; set; }
       

        public Goods(string name,decimal price, string barcode, double weigth)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            
        }
        public Goods()
        {

        }
        public override string ToString()
        {
            return $"{Name}, {Price} Euro,barcode - {Barcode},  {Weigth} grams";
        }
    }
}
