using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class Drinks : Goods
    {
        public double Litre { get; set; }
        public string Name { get; set; }
        public Drinks(string name, decimal price, string barcode, double weigth, double litre) : base(price, barcode, weigth)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            Litre = litre;
        }
        public override string ToString()
        {
            return $"{Name} {Price} {Barcode} {Weigth} {Litre}";
        }
    }
}
