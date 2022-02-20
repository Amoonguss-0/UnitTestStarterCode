using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedReturn = num1 + num2;
            double actualReturn = SimpleMath.Add(num1, num2);
            // Use the DataRow values to test the Add method
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(8, 5)]
        [DataRow(9, 5)]
        [DataRow(0, 999999)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expectedReturn = num1 * num2;
            double actualReturn = SimpleMath.Multiply(num1, num2);
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(expectedReturn, actualReturn);
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            int num = 10;
            int den = 0;
            if (den == 0)
            {
                Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num, den));
            }
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        public void Divide_TwoNumbers_ReturnsProduct()
        {
            int num = 45;
            int den = 5;
            int expectedReturn = 9;
            double actualReturn = SimpleMath.Divide(num, den);

            Assert.AreEqual(expectedReturn, actualReturn);
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsProduct()
        {
            int num = 100;
            int den = 50;
            int expectedReturn = 50;
            double actualReturn = SimpleMath.Subtract(num, den);

            Assert.AreEqual(expectedReturn, actualReturn);
        }
    }
}