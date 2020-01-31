using System;

namespace MathOperations
{
    public class Calculator
    {
        #region "Member Functions" 
        /// <summary>
        ///  Performs Add Operation on Number1 and Number2
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Returns the addition of the numbers</returns>
        public static double AddNumbers(double number1,double number2) => number1 + number2;

        /// <summary>
        ///  Performs Subtract Operation on Number1 and Number2
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Returns the Subtraction of the numbers</returns>
        public static double SubtractNumbers(double number1, double number2) =>  number1 - number2;

        /// <summary>
        ///  Performs Multiply Operation on Number1 and Number2
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Returns the Multiplication of the numbers</returns>
        public static double MultiplyNumbers(double number1, double number2) => number1 * number2;

        /// <summary>
        ///  Performs Division on Number1 and Number2
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <exception cref="DivideByZeroException">Throw DivideByZeroException when second Number is Zero</exception>
        /// <returns>Returns the Division of the numbers</returns>
        public static double? DivideNumbers(double number1, double number2)
        {
            double? result=null;
            try
            {
                if (number1 < 0 || number2 < 0)
                    throw new NegativeNumberDivisionException();
                result = number1 / number2;
            }
            catch (NegativeNumberDivisionException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        #endregion

    }

    public class NegativeNumberDivisionException : ApplicationException
    {
        public override string Message 
        {
            get { return "Cannot divide negative number"; }
        }
    }
}
