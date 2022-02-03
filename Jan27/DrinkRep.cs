using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Jan27
{
    public class DrinksRepository
    {
        public static List<Drinks> DrinkList{ get; set; }
       

        public DrinksRepository()
        {
            DrinkList = new List<Drinks>();
       
        }
        public List <Drinks> GetList()
        {
            return DrinkList;
        }


        public void ReadDrnks()
        {
           
            String Path = @"C:\Users\Kornelijus\source\repos\Jan27\Jan27\Resources\Drinks.CSV.txt";
            
            VariousServices.FileReaderService(4, Path);

            

            DrinkList.AddRange(VariousServices.Drink);

            


        }

    }
}