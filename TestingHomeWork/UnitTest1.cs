using System;
using Xunit;
using Jan27;
using System.Linq;
using System.Collections.Generic;

namespace TestingHomeWork
{
    public class HomeWorkTests
    {
        CandyRepository CandyRep = new CandyRepository();
        MeniuService Meniutest = new MeniuService();
        DrinksRepository DrinkRep = new DrinksRepository();
        VariousServices Services = new VariousServices();
        MeatRepository MeatRep = new MeatRepository();
        VeggieRepository VeggieRep = new VeggieRepository();

        [Fact]
        public void RepositoryFileReadTestCandy()
        {
            //Assign
            CandyRep.ReadCandies();
           
            var expect = VariousServices.SweetList;
            
            //Act
            var result = CandyRep.GetList();
            //Assert
            Assert.Equal(expect, result);
        }
        [Fact]
        public void RepostoryFileReadTestMeat()
        {
            //Assign
            MeatRep.ReadMeat();
            var expect = VariousServices.Meats;
            //Act
            var result = MeatRep.GetList();
            //Assert
            Assert.Equal(expect, result);
        }
        [Fact]
        public void RepositoryFileReadTestDrinks()
        {
            //Assign
            DrinkRep.ReadDrnks();
            var expect = VariousServices.Drink;
            //Act
            var result = DrinkRep.GetList();

            //Assert
            Assert.Equal(expect, result);
        }
        [Fact]
        public void RepositoryFfileReadVeggies()
        {
            //Assign
            VeggieRep.ReadVeg();
            var expect = VariousServices.Vegg;
            //Act
            var result = VeggieRep.GetList();
            //Assert
            Assert.Equal(expect, result);
        }
        [Fact]
        public void MeniuListSumTest()
        {
            //Assign
            DrinkRep.ReadDrnks();
            CandyRep.ReadCandies();
            //Act
            MeniuService.MeniuList.AddRange(CandyRep.GetList());
            MeniuService.MeniuList.AddRange(DrinkRep.GetList());
            var result = MeniuService.MeniuList.Sum(d => Convert.ToDecimal(d.Price));
            //Assert
            Assert.Equal(Convert.ToDecimal(54.30), result);

        }

        [Fact]
        public void DoesMakeInvoiceTurnGoodsListToString()
        {

            //Assign
            List<Goods> MockList = new List<Goods>();
            Goods MockItem = new Goods("Shalom",10, "a5r68g46", 89);

            //Act
            MockList.Add(MockItem);
            var Result = VariousServices.MakeInvoice(MockList);
            // Assert
            Assert.Contains(MockItem.Barcode, Result);

        }
        [Fact]
        public void CheckIfShoppingCartEmpty()
        {
            //Assign
            DrinkRep.ReadDrnks();
            //Act
            MeniuService.MeniuList.AddRange(DrinkRep.GetList());
            //Assert
            Assert.NotEmpty(MeniuService.MeniuList);
        }
   

      
        [Fact]
        public void TestIfSelectionAddsToListOption1()
        {
            //Asign
            string Option = "1";
            string Selection = "Rududu";
            //Act
            CandyRep.ReadCandies();
            MeniuHelper.SelectAndAdd(Selection, Option);
            string Basket = String.Join(System.Environment.NewLine, MeniuService.MeniuList).ToString();

            //Assert
            Assert.StartsWith(Selection, Basket);
        }
        [Fact]
        public void TestifSelectionAddsToListOption2()
        {
            //Asign
            string Option = "2";
            string Selection = "Beef";
            //Act
            MeatRep.ReadMeat();
            MeniuHelper.SelectAndAdd(Selection, Option);
            string Basket = String.Join(System.Environment.NewLine, MeniuService.MeniuList).ToString();

            //Assert
            Assert.StartsWith(Selection, Basket);
        }
        [Fact]
        public void TestIfSelectionAddsToListOption3()
        {
            //Asign
            string Option = "3";
            string Selection = "Sambuca";
            //Act
            DrinkRep.ReadDrnks();
            MeniuHelper.SelectAndAdd(Selection, Option);
            string Basket = String.Join(System.Environment.NewLine, MeniuService.MeniuList).ToString();

            //Assert
            Assert.StartsWith(Selection, Basket);
        }
        [Fact]
        public void TestIfSelectionAddsToListOption4()
        {
            //Asign
            string Option = "4";
            string Selection = "Raddish";
            //Act
            VeggieRep.ReadVeg();
            MeniuHelper.SelectAndAdd(Selection, Option);
            string Basket = String.Join(System.Environment.NewLine, MeniuService.MeniuList).ToString();

            //Assert
            Assert.StartsWith(Selection, Basket);
        }
        [Fact]
        public void  TestIFoptionisnotinoptionList()
        {
            //Asign
            string Option = "0";
            string Selection = "Rududu";
            //Act
            CandyRep.ReadCandies();
            MeniuHelper.SelectAndAdd(Selection, Option);
            string Basket = String.Join(System.Environment.NewLine, MeniuService.MeniuList).ToString();

            //Assert
            Assert.StartsWith(Selection, Basket);
        }
        [Fact]
        public void ToStringTest()
        {
            //Assign
            Goods Good = new Goods("string", 10, "a47599", 50);
            Candy Candid = new Candy("new", 1, "2124hg", 40, "string");
            Meat Pork = new Meat("sd", 4, "fgwr123", 40, 60);
            Drinks Drink1 = new Drinks("sd", 4, "fgwr123", 40, 60);
            Veggie Veg1 = new Veggie ("sd", 4, "fgwr123", 40, 1);
            string Expected = $"{Good.Name}, {Good.Price} Euro,barcode - {Good.Barcode},  {Good.Weigth} grams";
            string Expected2 = $"{Candid.Name}, {Candid.Price} Euro, Barcode - {Candid.Barcode}, {Candid.Weigth} grams, sugar type - {Candid.Sugar}";
            string Expected3 = $"{Pork.Name}, {Pork.Price} Euro, barcode - {Pork.Barcode}, {Pork.Weigth} grams, protein amount - {Pork.Protein} grams";
            string Expected4 = $"{Drink1.Name}, {Drink1.Price} Euro, bardcode - {Drink1.Barcode}, {Drink1.Weigth} grams, {Drink1.Litre} litres";
            string Expected5 = $"{Veg1.Name}, {Veg1.Price} Euro, Barcode -  {Veg1.Barcode}, {Veg1.Weigth} grams, contains {Veg1.Fiber} grams of fiber";
            //Act
            string Result = Good.ToString();
            string Result2 = Candid.ToString();
            string Result3 = Pork.ToString();
            string Result4 = Drink1.ToString();
            string Result5 = Veg1.ToString();
            //Assert
        

            Assert.Equal(Expected, Result);
            Assert.Equal(Expected2, Result2);
            Assert.Equal(Expected3, Result3);
            Assert.Equal(Expected4, Result4);
            Assert.Equal(Expected5, Result5);
        }


    }
}

    

 