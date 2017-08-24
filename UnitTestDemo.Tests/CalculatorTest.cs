using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSumMethod()
        {
            Calculator Calculator = new Calculator();
            int Sum = Calculator.Sum(10, 33);
            Assert.AreEqual(3, Sum);
        }
    }
}
