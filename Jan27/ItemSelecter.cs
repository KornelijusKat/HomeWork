using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan27
{
    public class MeniuHelper
    {
        public MeniuHelper()
        {
         
            
        }
        public static void SelectAndAdd(string answer, string Selection)
        {

            if (Selection == "1")
            {
                var item = CandyRepository.Candies.SingleOrDefault(x => x.Name == answer);
                Candy Selected = new(item.Name, item.Price, item.Barcode, item.Weigth, item.Sugar);
                MeniuService.MeniuList.Add(Selected);
            }
            else if (Selection == "2")
            {
                var item2 = MeatRepository.MeatList.SingleOrDefault(x => x.Name == answer);
                Meat Selected = new Meat(item2.Name, item2.Price, item2.Barcode, item2.Weigth, item2.Protein);
                MeniuService.MeniuList.Add(Selected);
            }
            else if (Selection == "3")
            {
                var item3 = DrinksRepository.DrinkList.SingleOrDefault(x => x.Name == answer);
                Drinks Selected = new Drinks(item3.Name, item3.Price, item3.Barcode, item3.Weigth, item3.Litre);
                MeniuService.MeniuList.Add(Selected);
            }
            else if (Selection == "4")
            {
                var item4 = VeggieRepository.Veggies.SingleOrDefault(x => x.Name == answer);
                Veggie Selected = new Veggie(item4.Name, item4.Price, item4.Barcode, item4.Weigth, item4.Fiber);
                MeniuService.MeniuList.Add(Selected);
            }

        }
     
    }
}
