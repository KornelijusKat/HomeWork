using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class Veggie : Goods
    {
        
        public double Fiber { get; set; }

        public Veggie(string name, decimal price, string barcode, double weigth, double fiber)  : base (name,price, barcode, weigth)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            Fiber = fiber;
        }
        public override string ToString()
        {
            return $"{Name}, {Price} Euro, Barcode -  {Barcode}, {Weigth} grams, contains {Fiber} grams of fiber";
        }

    }
}
