using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class VeggieRepository
    {
        
        
        public static List <Veggie> Veggies { get; set; }
       

        public VeggieRepository()
        {
            Veggies = new List<Veggie>();
            
        }
        public List<Veggie> GetList()
        {
            return Veggies;
        }


        public void ReadVeg()
        {
        
            

            
            String Path = @"C:\Users\Kornelijus\source\repos\Jan27\Jan27\Resources\Veggies.CSV.txt";
         
            VariousServices.FileReaderService(3,Path);

          

           
            Veggies.AddRange(VariousServices.Vegg);
            
           


        }
    }
}
