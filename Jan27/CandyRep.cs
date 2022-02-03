using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jan27
{
    public class CandyRepository
    {
        public static List <Candy> Candies { get; set; }
        

        public CandyRepository()
        {
            Candies = new List<Candy>();
          
        }

        public  List<Candy> GetList()
        {
            return Candies;
        }


        public void ReadCandies()
        {
           
          
            String Path = @"C:\Users\Kornelijus\source\repos\Jan27\Jan27\Resources\Candies.CSV.txt";      
            VariousServices.FileReaderService( 1,Path);
            Candies.AddRange(VariousServices.SweetList);

        }

    }
}
