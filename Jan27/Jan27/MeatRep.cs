using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class MeatRepository
    {
        public List<Meat> Meata { get; set; }
        //public List<Meat> Meats { get; set; }
        //public List <Veggie> Veggies { get; set; }
        //public List <Drinks> DrinkList { get; set; }

        public MeatRepository(/*List<Candy> candies*//* List<Meat> meats, List<Veggie> veggies, List<Drinks> drinkList*/)
        {
            Meata = new List<Meat>();
            //Meats = meats;
            //Veggies = veggies;
            //DrinkList = drinkList;
        }



        public void ReadMeat()
        {
            VariousServices Bob = new VariousServices();


            Meat myobj = new Meat(" ", 4, "589", 45, " ");
            String Path = @"C:\Users\Kornelijus\Desktop\HomeWork\Meat.CSV.txt";
            string line;
            VariousServices.FileReaderServiceM(myobj, Path);

            List<Meat> Meata = new List<Meat>();
            Meata.AddRange(VariousServices.Meats);

            Meata.ForEach(Console.WriteLine);
            

        }

    }
}
