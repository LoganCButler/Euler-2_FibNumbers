using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            AppLogic a = new AppLogic();

            //Act
            var answer = a.getEvenFibNumbers();

            //Assert
            Assert.AreEqual(4613732, answer);
        }
    }
}
