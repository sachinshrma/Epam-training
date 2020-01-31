using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
namespace MathOperationsTest
{
    [TestClass]
    public class MathOperationsTest
    {
        [TestMethod]
        public void AddNumbersTest()
        {
            #region "Arrange"
            int number1 = 2, number2 = 4;
            #endregion

            #region "Act"
            double responseResult = Calculator.AddNumbers(number1, number2);
            #endregion

            #region "Assert"
            Assert.AreEqual(6, responseResult);
            #endregion
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            #region "Arrange"
            int number1 = 2, number2 = 4;
            #endregion

            #region "Act"
            double responseResult = Calculator.SubtractNumbers(number1, number2);
            #endregion

            #region "Assert"
            Assert.AreEqual(-2, responseResult);
            #endregion
        }

        [TestMethod]
        public void MultiplyNumbersTest()
        {
            #region "Arrange"
            int number1 = 2, number2 = 4;
            #endregion

            #region "Act"
            double responseResult = Calculator.MultiplyNumbers(number1, number2);
            #endregion

            #region "Assert"
            Assert.AreEqual(8, responseResult);
            #endregion
        }

        [TestMethod]
        
        public void DivideNumbersTest()
        {
            #region "Arrange"
            int number1 = 2, number2 = 4, number3=0;
            #endregion

            #region "Act"
            double responseResult = Calculator.DivideNumbers(number1, number2);            
            #endregion

            #region "Assert"
            Assert.AreEqual(0.5, responseResult);
            Assert.ThrowsException<NegativeNumberDivisionException>(() => Calculator.DivideNumbers(number1, number3));
            #endregion
        }
    }
}
