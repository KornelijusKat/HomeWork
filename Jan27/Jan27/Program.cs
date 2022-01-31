using System;
using System.Collections.Generic;
using System.Linq;

namespace Jan27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Candy derp = new Candy("st",1, "456", 89,"Candy");
            //List<Candy> placeholder = new List<Candy>();
            //programServices Reader = new programServices();
            SugarRepository GoodsList = new SugarRepository();
            MeatRepository Meats = new MeatRepository();
            DrinksRepository Drinks = new DrinksRepository();
            VeggieRepository Vegatables = new VeggieRepository();
            VariousServices Service = new VariousServices();
            GoodsList.ReadCandies();
            Meats.ReadMeat();
            Drinks.ReadDrnks();
            Vegatables.ReadVeg();






            //Console.WriteLine("Enter Euro amount you wish to spend");
            //decimal input = Convert.ToDecimal(Console.ReadLine());
            
            //bool check = input > 0 == true;
            //while (check)
            //{
                
                Service.Meniu();
            //}
           
           
            //GoodsList.Candies = Reader.GetAllLines()


            //var list = new List<string>();

            //list = Reader.GetAllLines();

            //GoodsList.Candies = list.Select(s => new Candy(,s,s )).ToList();
            //GoodsList.Candies = list.Cast<Candy>().ToList();






            ////GoodsList.ReadCandies();
            //Meats.ReadMeat();
            //Drinks.ReadDrnks();
            //Vegatables.ReadVeg();

        }
    }
}
