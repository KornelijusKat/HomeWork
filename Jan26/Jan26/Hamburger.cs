using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan26
{
    public class Hamburger
    {
        public string Name { get; set; }
        public string Meat { get; set; }
        public decimal  Price { get; set; }
        public string BreadRollType { get; set; }
        public string addition1Name;
        public string addition2Name;
        public string addition3Name;
        public string addition4Name;
        public decimal addition1Price;
        public decimal addition2Price;
        public decimal addition3Price;
        public decimal addition4Price;
        public Hamburger(string name, string meat, decimal price, string breadRollType)
        {
            Name = name;
            Meat = meat;
           
            Price = price;
            BreadRollType = breadRollType;
        }

        protected Hamburger(string meat, decimal price)
        {

            Meat = meat;
            Price = price;
        }

        public virtual void AddHamburgerAddition1()
        {
            addition1Name = "Tomato";
            addition1Price = 0.27M;
            Console.WriteLine($"Added {addition1Name} for {addition1Price}");
          
        }
        public virtual void AddHamburgerAddition2()
        {
            addition2Price =  0.75M;
            addition2Name = "Lettuce";
            Console.WriteLine($"Added {addition2Name} for {addition2Price}");
        }
        public virtual void AddHamburgerAddition3()
        {
            addition3Price = 1.13M;
            addition3Name = "cheese";
            Console.WriteLine($"Added {addition3Name} for {addition3Price}");
        }
        public virtual void AddHamburgerAddition4(string phame, decimal strike)
        {
            addition4Price = strike;
            addition4Name = phame;
            Console.WriteLine($"Added {addition4Name} for {addition4Price}");
        }
        public virtual decimal ItemizeHamburger()
        {
            Console.WriteLine($"{Name} burger on a {BreadRollType} roll with {Meat}");
           

            return Price + addition1Price + addition2Price + addition3Price + addition4Price;
        }

    }
}
