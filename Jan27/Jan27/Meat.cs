using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class Meat : Goods
    {
        public string Protein { get; set; }
        public string Name { get; set; }
        public Meat(string name,  decimal price, string barcode, double weigth, string protein) : base(price, barcode, weigth)
        {
            Name = name;
            
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            Protein = protein;
        }
        public override string ToString()
        {
            return $"{Name} {Price} {Barcode} {Weigth} {Protein}";
        }
    }
}
