using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting;

namespace CalculatorTestingProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange :-
            Calculator obj = new Calculator();

            // Act :-
            int expected = 20;
            int actual = obj.Addition(10, 10);

            //Assert :-
            Assert.AreEqual(expected, actual);


        }
    }
}
