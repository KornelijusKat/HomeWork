using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class Meat : Goods
    {
        public double Protein { get; set; }
       
        public Meat(string name,  decimal price, string barcode, double weigth, double protein) : base(name, price, barcode, weigth)
        {
            Name = name;
            
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            Protein = protein;
        }
        public override string ToString()
        {
            return $"{Name}, {Price} Euro, barcode - {Barcode}, {Weigth} grams, protein amount - {Protein} grams";
        }
    }
}
