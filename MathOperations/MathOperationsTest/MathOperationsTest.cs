using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            MathOperations.MathOperations objMathOperation = new MathOperations.MathOperations(number1, number2);
            #endregion

            #region "Act"
            double responseResult = objMathOperation.AddNumbers();
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
            MathOperations.MathOperations objMathOperation = new MathOperations.MathOperations(number1, number2);
            #endregion

            #region "Act"
            double responseResult = objMathOperation.SubtractNumbers();
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
            MathOperations.MathOperations objMathOperation = new MathOperations.MathOperations(number1, number2);
            #endregion

            #region "Act"
            double responseResult = objMathOperation.MultiplyNumbers();
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
            MathOperations.MathOperations objMathOperation = new MathOperations.MathOperations(number1, number2);
            MathOperations.MathOperations objMathOperation2 = new MathOperations.MathOperations(number1, number3);
            #endregion

            #region "Act"
            double responseResult = objMathOperation.DivideNumbers();            
            #endregion

            #region "Assert"
            Assert.AreEqual(0.5, responseResult);
            Assert.ThrowsException<DivideByZeroException>(()=> objMathOperation2.DivideNumbers());            
            #endregion
        }
    }
}
