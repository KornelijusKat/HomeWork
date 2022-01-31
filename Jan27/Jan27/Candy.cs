using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class Candy : Goods
    {
    
        public string Name { get; set; }
        public string Sugar { get; set; }
        public Candy(string name, decimal price, string barcode, double weigth, string sugar) : base(price, barcode, weigth)
        {
            Name = name;
            Price = price;
            Barcode = barcode;
            Weigth = weigth;
            Sugar = sugar;

        }
        public override string ToString()
        {
            return $"{Name} {Price} {Barcode} {Weigth} {Sugar}";
        }
    }
}
