using System;

namespace Jan26
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburger Basic = new Hamburger("Basic", "Sausage", 3.56M, "White");
            Basic.AddHamburgerAddition1();
            Basic.AddHamburgerAddition2();
            Basic.AddHamburgerAddition3();
            Basic.AddHamburgerAddition4("Fork", 8M);
            Console.WriteLine($"total burger price {Basic.ItemizeHamburger()} ");
            DeluxeBurger old = new DeluxeBurger("Delux", "Sausage", 19.00M, "White");
            old.AddHamburgerAddition1();
            Console.WriteLine(old.ItemizeHamburger());
            HealthyBurger good = new HealthyBurger("Bean patty", 6.00M);
            good.AddHealthyAddition1();
            good.AddHealthyAddition2();
            Console.WriteLine($"total burger price {good.ItemizeHamburger()}");
            Console.WriteLine("Github test");

        }
    }
}
