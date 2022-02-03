using System;
using System.Collections.Generic;
using System.Linq;

namespace Jan27
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VeggieRepository VeggieRep = new VeggieRepository();
            CandyRepository CandyRep = new CandyRepository();
            MeatRepository MeatRep = new MeatRepository();
            DrinksRepository DrinkRep = new DrinksRepository();
            MeniuService Application = new MeniuService();
            CandyRep.ReadCandies();
            MeatRep.ReadMeat();
            DrinkRep.ReadDrnks();
            VeggieRep.ReadVeg();
            Console.WriteLine("Enter money amount");
            Decimal Money;
            bool success = Decimal.TryParse(Console.ReadLine(), out Money);
            if (!success)
            {
                Console.WriteLine("Retry the amount");
                success = Decimal.TryParse(Console.ReadLine(), out Money);
            }
            Application.Meniu(Money);

           




        }
    }
}
