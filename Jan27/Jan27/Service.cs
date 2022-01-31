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
        public static List<Candy> YourList;
        public static List<Meat> Meats;
        public static List<Drinks> Drink;
        public static List<Veggie> Vegg;
        public List<Goods> Listas;
        public System.IO.StreamReader file;

        public VariousServices()
        {
            MeatRepository E = new MeatRepository();
            DrinksRepository K = new DrinksRepository();
            SugarRepository D = new SugarRepository();
            VeggieRepository C = new VeggieRepository();
            Listas = new List<Goods>();
        }

        public static void FileReaderService<T>(T myobj, string Path)
        {
           

            
            SugarRepository D = new SugarRepository();
            YourList = new List<Candy>();
            string line;
            List<Candy> derp = new List<Candy>();
            List<Candy> Listas = D.Candies;
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split(',');
             

               YourList.Add(new Candy(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), words[4]));
               
            }
            
            //Listas.ForEach(Console.WriteLine);
            file.Close();
           
        
        }
        public static void FileReaderServiceM<T>(T myobj, string Path)
        {



            
            Meats = new List<Meat>();
            string line;
            
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split(',');


                Meats.Add(new Meat(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), words[4]));

            }

            //Listas.ForEach(Console.WriteLine);
            file.Close();


        }
        public static void FileReaderServiceV<T>(T myobj, string Path)
        {



           
            Vegg = new List<Veggie>();
            string line;
           
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split(',');


                Vegg.Add(new Veggie(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]), words[4]));

            }

            //Listas.ForEach(Console.WriteLine);
            file.Close();


        }
        public static void FileReaderServiceD<T>(T myobj, string Path)
        {



            
            Drink = new List<Drinks>();
            string line;
          
            System.IO.StreamReader file =
                new System.IO.StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split(',');


                Drink.Add(new Drinks(words[0], Convert.ToDecimal(words[1]), words[2], Convert.ToDouble(words[3]),Convert.ToDouble(words[4])));

            }

            //Listas.ForEach(Console.WriteLine);
            file.Close();


        }
        public bool Meniu()
        {
            Console.WriteLine("Enter Euro amount you wish to spend");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            decimal Money = input;
            
            bool check = input > 0 == true;
          
            while (check)
            {
                
                Console.WriteLine("Choose selection");

                Console.WriteLine("Open Candy meniu");
                Console.WriteLine("Open Meat meniu");
                Console.WriteLine("Open Drink meniu");
                Console.WriteLine("Open Veggie meniu");
                Console.WriteLine("Open pending order");
                Console.WriteLine("Buy order");

                int newput = Convert.ToInt32(Console.ReadLine());

                if (newput == 1)
                {
                    YourList.ForEach(Console.WriteLine);
                    Console.WriteLine("Do you wish to buy? y/n");
                    string candyInput = Console.ReadLine();
                    if (candyInput == "y")
                    {
                        Console.WriteLine("Type product name you wish to buy");

                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        //YourList '' = YourList.Single(a => a.Price == answer);
                        var item = YourList.SingleOrDefault(x => x.Price == answer);
                        Candy d = new Candy(item.Name, item.Price, item.Barcode, item.Weigth, item.Sugar);
                        if (Money > item.Price)
                        {
                            Listas.Add(d);
                            Money = Money - item.Price;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
                else if (newput == 2)
                {
                    Meats.ForEach(Console.WriteLine);
                    Console.WriteLine("Do you wish to buy? y/n");
                    string candyInput = Console.ReadLine();
                    if (candyInput == "y")
                    {
                        Console.WriteLine("Type product name you wish to buy");

                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        //YourList '' = YourList.Single(a => a.Price == answer);
                        var item = Meats.SingleOrDefault(x => x.Price == answer);
                        Meat d = new Meat(item.Name, item.Price, item.Barcode, item.Weigth, item.Protein);
                        if (Money > item.Price)
                        {
                            Listas.Add(d);
                            Money = Money - item.Price;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
                else if (newput == 3)
                {
                    Drink.ForEach(Console.WriteLine);
                    Console.WriteLine("Do you wish to buy? y/n");
                    string candyInput = Console.ReadLine();
                    if (candyInput == "y")
                    {
                        Console.WriteLine("Type product name you wish to buy");

                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        //YourList '' = YourList.Single(a => a.Price == answer);
                        var item = Drink.SingleOrDefault(x => x.Price == answer);
                        Drinks d = new Drinks (item.Name, item.Price, item.Barcode, item.Weigth, item.Litre);
                        if (Money > item.Price)
                        {
                            Listas.Add(d);
                            Money = Money - item.Price;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
                else if (newput == 4)
                {
                    Vegg.ForEach(Console.WriteLine);
                    Console.WriteLine("Do you wish to buy? y/n");
                    string candyInput = Console.ReadLine();
                    if (candyInput == "y")
                    {
                        Console.WriteLine("Type product name you wish to buy");

                        decimal answer = Convert.ToDecimal(Console.ReadLine());
                        //YourList '' = YourList.Single(a => a.Price == answer);
                        var item = Vegg.SingleOrDefault(x => x.Price == answer);
                        Veggie d = new Veggie(item.Name, item.Price, item.Barcode, item.Weigth, item.Fiber);
                        if (Money > item.Price)
                        {
                            Listas.Add(d);
                            Money = Money - item.Price;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }
                else if (newput == 5)
                {

                    Listas.ForEach(Console.WriteLine);
                    Console.WriteLine(Listas.Sum(d => Convert.ToDecimal(d.Price)));
                    

                }
                else if (newput == 6)
                {
                 
                    if (Money > Listas.Sum(d => Convert.ToDecimal(d.Price)))
                    {
                        string Basket = String.Join(System.Environment.NewLine, Listas);
                        string InvoicePrice = Convert.ToString(Listas.Sum(d => Convert.ToDecimal(d.Price)));
                         
                        string invoice =
                        "Jusu krepselis" + System.Environment.NewLine +
                        Basket + System.Environment.NewLine +
                        "Galutine kaina: " +
                            InvoicePrice;
                        string finale = invoice.Replace("@", "@" + System.Environment.NewLine);
                        var smtpClient = new SmtpClient("smtp.gmail.com")
                        {

                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            Port = 587,
                            Credentials = new NetworkCredential { UserName = "codeacadtest@gmail.com", Password = "Xoworeu17" },
                            EnableSsl = true,
                        };

                        smtpClient.Send(from: "codeacadtest@gmail.com", "katinaskornelijus@gmail.com", "subject", finale);

                    }
                }
                else
                {
                    Environment.Exit(0);
                }

            }
            return true;
        }
        
    }
}
