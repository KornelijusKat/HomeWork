using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan26
{
    public class HealthyBurger : Hamburger
    {
        public string HealthyExtra1Name;
        public string HealthyExtra2Name;
        public decimal HealthyExtra1Price;
        public decimal HealthyExtra2Price;


        public HealthyBurger(string meat, decimal price) : base(meat, price)
        {
            Name = "Healthy";
            Meat = meat;

            Price = price;
            BreadRollType = "Whole grain";
        }
        public void AddHealthyAddition1()
            {
            HealthyExtra1Name = "Egg";
            HealthyExtra1Price = 4.27M;
            Console.WriteLine($"Added {HealthyExtra1Name} for {HealthyExtra1Price}");
        }
        public void AddHealthyAddition2()
        {
            HealthyExtra2Name = "Lentils";
            HealthyExtra2Price = 5;
            Console.WriteLine($"Added {HealthyExtra2Name} for {HealthyExtra2Price}");
        }
        public override Decimal ItemizeHamburger()
        {
            Console.WriteLine($"{Name} burger on a {BreadRollType} roll with {Meat}");
            return Price + HealthyExtra1Price + HealthyExtra2Price;
        }
    }

}
