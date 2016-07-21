using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumEvenNumbersNotOver4Mil()
        {
            //Arrange
            AppLogic a = new AppLogic();

            //Act
            var answer = a.getEvenFibNumbers(4000000);

            //Assert
            Assert.AreEqual(4613732, answer); 
        }
    }
}
