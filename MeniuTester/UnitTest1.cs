using System;
using Xunit;
using Jan27;
using System.Collections.Generic;

namespace TesterOfHomework
{
    public class UnitTest1
    {
        [Fact]
        public void TestFileReader()
        {
            //Assign
            var TestReading = new VariousServices();
            CandyRepository.Candies = new List<Candy>();

            //Act
         VariousServices.FileReaderService(1, "");

            Assert.Empty(CandyRepository.Candies);
        }
    }
}
