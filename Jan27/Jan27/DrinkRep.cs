using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jan27
{
    public class DrinksRepository
    {
        public List<Drinks> DrinkList{ get; set; }
        //public List<Meat> Meats { get; set; }
        //public List <Veggie> Veggies { get; set; }
        //public List <Drinks> DrinkList { get; set; }

        public DrinksRepository(/*List<Candy> candies*//* List<Meat> meats, List<Veggie> veggies, List<Drinks> drinkList*/)
        {
            DrinkList = new List<Drinks>();
            //Meats = meats;
            //Veggies = veggies;
            //DrinkList = drinkList;
        }



        public void ReadDrnks()
        {
            VariousServices Bob = new VariousServices();


            Drinks myobj = new Drinks(" ", 4, "589", 45, 6);
            String Path = @"C:\Users\Kornelijus\Desktop\HomeWork\Drinks.CSV.txt";
            string line;
            VariousServices.FileReaderServiceD(myobj, Path);

            List<Drinks> DrinkList = new List<Drinks>();
            DrinkList.AddRange(VariousServices.Drink);

            DrinkList.ForEach(Console.WriteLine);


        }

    }
}