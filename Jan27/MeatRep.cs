using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class MeatRepository
    {
        public static List<Meat> MeatList { get; set; }
        

        public MeatRepository()
        {
            MeatList = new List<Meat>();
           
        }

        public List<Meat> GetList()
        {
            return MeatList;
        }

        public void ReadMeat()
        {
              
            String Path = @"C:\Users\Kornelijus\source\repos\Jan27\Jan27\Resources\Meat.CSV.txt";
            VariousServices.FileReaderService(2,Path);
            MeatList.AddRange(VariousServices.Meats);

           
            

        }

    }
}
