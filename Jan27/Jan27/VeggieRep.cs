using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class VeggieRepository
    {
        
        //public List<Meat> Meats { get; set; }
        public List <Veggie> Veggies { get; set; }
        //public List <Drinks> DrinkList { get; set; }

        public VeggieRepository(/*List<Candy> candies*//* List<Meat> meats, List<Veggie> veggies, List<Drinks> drinkList*/)
        {
           Veggies = new List<Veggie>();
            //Meats = meats;
            //Veggies = veggies;
            //DrinkList = drinkList;
        }



        public void ReadVeg()
        {
            VariousServices Bob = new VariousServices();


            Veggie myobj = new Veggie(" ", 4, "589", 45, " ");
            String Path = @"C:\Users\Kornelijus\Desktop\HomeWork\Veggies.CSV.txt";
            string line;
            VariousServices.FileReaderServiceV(myobj, Path);

            List<Veggie> Veggies = new List<Veggie>();
            Veggies.AddRange(VariousServices.Vegg);

            Veggies.ForEach(Console.WriteLine);


        }
    }
}
