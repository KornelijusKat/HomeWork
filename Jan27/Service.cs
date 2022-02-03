using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Jan27
{
    public class VariousServices
    {
        public static List<Candy> SweetList { get; set; }
        public static List<Meat> Meats{ get; set; }
        public static List<Drinks> Drink{ get; set; }
        public static List<Veggie> Vegg { get; set; }
        public List<Goods> MeniuList { get; set; }
      

        public VariousServices()
        {
           
            MeniuList = new List<Goods>();
        }

        public static void FileReaderService(int x,string Path )
        {

            Drink = new List<Drinks>();
            Vegg = new List<Veggie>();
            Meats = new List<Meat>();
            SweetList = new List<Candy>();

            string line;
            
           
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path);
            if (x == 1)
            {
                while ((line = file.ReadLine()) != null)
                {

                    string[] words = line.Split(',');
                    SweetList.Add(new Candy(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), words[4]));

                }

            }
            
            else if (x == 2)
            {
                while ((line = file.ReadLine()) != null)
                {

                    string[] words = line.Split(',');
                    Meats.Add(new Meat(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), Convert.ToDouble(words[4])));

                }

            }
            else if (x == 3)
                while ((line = file.ReadLine()) != null)
                {

                    string[] words = line.Split(',');
                    Vegg.Add(new Veggie(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), Convert.ToDouble(words[4])));

                }
           
            else if (x == 4)
                while ((line = file.ReadLine()) != null)
                {

                    string[] words = line.Split(',');
                    Drink.Add(new Drinks(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), Convert.ToDouble(words[4])));

                }

        }
        public void Sendmail(string invoice)
        {
            Console.WriteLine(invoice);

            var smtpClient = new SmtpClient("smtp.gmail.com");


            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Port = 587;

            smtpClient.Credentials = new NetworkCredential { UserName = "codeacadtest@gmail.com", Password = "Xoworeu17" };
            smtpClient.EnableSsl = true;


            smtpClient.Send(from: "codeacadtest@gmail.com", "katinaskornelijus@gmail.com", "subjectb", invoice);


        }
        public static string MakeInvoice(List<Goods> MeniuList)
        {
             
            string Basket = String.Join(System.Environment.NewLine, MeniuList).ToString();
            string InvoicePrice = Convert.ToString(MeniuList.Sum(d => Convert.ToDecimal(d.Price)));
            string invoice =
            "Your cart" + System.Environment.NewLine +
            Basket + System.Environment.NewLine +
            "Final price: " + InvoicePrice + "Euro"+ System.Environment.NewLine + DateTime.Now;
            return invoice;
        }
       

    }
}
