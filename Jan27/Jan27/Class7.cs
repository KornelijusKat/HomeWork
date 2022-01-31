using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jan27
{
    class programServices
    {
        private readonly string _path = @"C:\Users\Kornelijus\Desktop\HomeWork\Candies.csv.txt";
            public List<string> GetAllLines()
            {
                var Lines = File.ReadAllLines(_path);
                return Lines.ToList();
            }
        
    }
}
