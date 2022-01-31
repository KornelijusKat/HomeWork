using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jan27
{
    public class SugarRepository
    {
        public List<Candy> Candies { get; set; }
        //public List<Meat> Meats { get; set; }
        //public List <Veggie> Veggies { get; set; }
        //public List <Drinks> DrinkList { get; set; }

        public SugarRepository(/*List<Candy> candies*//* List<Meat> meats, List<Veggie> veggies, List<Drinks> drinkList*/)
        {
            this.Candies = new List<Candy>();
            //Meats = meats;
            //Veggies = veggies;
            //DrinkList = drinkList;
        }

       

        public  void ReadCandies()
        {
           
            VariousServices Bob = new VariousServices();
            
          
            Candy myobj = new Candy(" ", 4, "589", 45, " ");
            String Path = @"C:\Users\Kornelijus\Desktop\HomeWork\Candies.CSV";
            string line;
            VariousServices.FileReaderService(myobj, Path);
       



            VariousServices.YourList.ForEach(Console.WriteLine);

        }

    }
}
