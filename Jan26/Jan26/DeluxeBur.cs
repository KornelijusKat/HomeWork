using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan26
{
    public class DeluxeBurger : Hamburger 
    {
        public  DeluxeBurger(string name, string meat, decimal price, string breadRollType) :base(name, meat, price, breadRollType)
        {
            Price = 19.10M;
        }
        public override void AddHamburgerAddition1()
        {
            Console.WriteLine("Cannot add to DeluxBurgerino");
            Console.WriteLine("Added chips for 2.75");
            Console.WriteLine("Added Drink for an extra 1.81");
        }
        public override void AddHamburgerAddition2()
        {
            Console.WriteLine("Cannot add to DeluxBurgerino");
            Console.WriteLine("Added chips for 2.75");
            Console.WriteLine("Added Drink for an extra 1.81");
        }
        public override void AddHamburgerAddition3()
        {
            Console.WriteLine("Cannot add to DeluxBurgerino");
            Console.WriteLine("Added chips for 2.75");
            Console.WriteLine("Added Drink for an extra 1.81");
        }
        public override void AddHamburgerAddition4(string ker, decimal huh)
        {
            Console.WriteLine("Cannot add to DeluxBurgerino");
            Console.WriteLine("Added chips for 2.75");
            Console.WriteLine("Added Drink for an extra 1.81");
        }
    }




}
