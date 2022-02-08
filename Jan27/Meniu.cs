using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Jan27
{
    public class MeniuService
    {


         public static List<Goods> MeniuList;
         VeggieRepository VegRep = new VeggieRepository();
         MeatRepository MeatRep = new MeatRepository();
         DrinksRepository DrinkRep = new DrinksRepository();
         CandyRepository CandyRep = new CandyRepository();
        

        public MeniuService()
        {
            MeniuList = new List<Goods>();
        }
        public void Meniu(decimal Money)
        {        
            while (true)
                {
                    Console.WriteLine("Choose selection");
                    Console.WriteLine("1.Open Candy meniu");
                    Console.WriteLine("2.Open Meat meniu");
                    Console.WriteLine("3.Open Drink meniu");
                    Console.WriteLine("4.Open Veggie meniu");
                    Console.WriteLine("5.Open pending order");
                    Console.WriteLine("6.Buy order");
                    Console.WriteLine("7.Exit app");
                    string Selection = Console.ReadLine();
                    
                if (Selection == "1")
                    {

                        CandyRep.GetList().ForEach(Console.WriteLine);
                        if (Money > 0)
                        {
                            Console.WriteLine("Do you wish to buy? y/n");
                            string candyInput = Console.ReadLine().ToLower();
                            if (candyInput == "y")
                            {
                                Console.WriteLine("Type product name you wish to buy");

                                string answer = Console.ReadLine();

                                if (CandyRep.GetList().Any(x => x.Name == answer))
                                {
                                
                                MeniuHelper.SelectAndAdd(answer, Selection);
                                
                              
                                }
                                 else
                                {
                                Console.WriteLine("item not found,returning to selection list");
                                continue;
                                 }
                            }
                            else
                            {
                                
                                continue;
                            }
                        }
                    }
                    else if (Selection == "2")
                    {
                        MeatRep.GetList().ForEach(Console.WriteLine);
                        if (Money > 0)
                        {
                            Console.WriteLine("Do you wish to buy? y/n");
                            string MeatInput = Console.ReadLine().ToLower();

                            if (MeatInput == "y")
                            {
                                Console.WriteLine("Type product name you wish to buy");

                                string answer = Console.ReadLine();
                                if (MeatRep.GetList().Any(x => x.Name == answer))
                            {
                                MeniuHelper.SelectAndAdd(answer, Selection);
                              
                            }
                                else
                                {
                                Console.WriteLine("item not found,returning to selection list");
                                continue;
                                }

                            }
                            else
                            {
                                continue;
                            }
                        }
                    }

                    else if (Selection == "3")
                    {
                        DrinkRep.GetList().ForEach(Console.WriteLine);
                        if (Money > 0)
                        {
                            Console.WriteLine("Do you wish to buy? y/n");
                            string DrinkINput = Console.ReadLine().ToLower();
                            if (DrinkINput == "y")
                            {
                                Console.WriteLine("Type product name you wish to buy");

                                string answer = Console.ReadLine();
                                if (DrinkRep.GetList().Any(x => x.Name == answer))
                                {
                                MeniuHelper.SelectAndAdd(answer, Selection);
                              
                                }
                                else
                                {
                                Console.WriteLine("item not found,returning to selection list");
                                continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (Selection == "4")
                    {



                        VegRep.GetList().ForEach(Console.WriteLine);
                        if (Money > 0)
                        {
                            Console.WriteLine("Do you wish to buy? y/n");
                            string VegInput = Console.ReadLine().ToLower();
                            if (VegInput == "y")
                            {
                                Console.WriteLine("Type product name you wish to buy");

                                string answer = Console.ReadLine();
                                if (VegRep.GetList().Any(x => x.Name == answer))
                                {
                                MeniuHelper.SelectAndAdd(answer, Selection);
                             
                                }
                            else
                            {
                                Console.WriteLine("item not found,returning to selection list");
                                continue;
                            }

                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (Selection == "5")
                    {
                        if (Money > 0)
                        {
                            Console.WriteLine($"Your entered amount: {Money} euro");
                            MeniuList.ForEach(Console.WriteLine);
                            Console.WriteLine(MeniuList.Sum(d => Convert.ToDecimal(d.Price)));
                        }

                    }
                    else if (Selection == "6")
                    {
                    if (Money > MeniuList.Sum(d => Convert.ToDecimal(d.Price)))
                    {
                        if (Money > MeniuList.Sum(d => Convert.ToDecimal(d.Price)))
                        {

                            VariousServices MailingList = new VariousServices();
                            VariousServices.MakeInvoice(MeniuList);
                            MailingList.Sendmail(VariousServices.MakeInvoice(MeniuList));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough money");
                        Console.WriteLine("Do you wish to add more Money and go back to the meniu? y/n");
                        string AddMore = Console.ReadLine().ToLower();
                        if (AddMore == "y")
                        { 
                            Money = Convert.ToDecimal(Console.ReadLine());
                        continue;
                          }
                        else
                        {
                            Console.WriteLine("Thank you for your time");
                            Environment.Exit(0);
                        }
                        }
                    }
                    else if (Selection == "7")
                    {
                        Environment.Exit(0);
              
                    }
                    else
                    {
                        Console.Write("Unrecognized input, please input number");
                        continue;

                    }                  
                }
              
            }
           
        }

    }


    

