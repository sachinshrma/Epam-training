using System;

namespace MathOperations
{
    public class MathOperations
    {
        #region "Data members"
        double firstNumber;
        double secondNumber;
        #endregion

        #region "Constructor"
        /// <summary>
        /// To Create the object of MathOperation
        /// </summary>
        /// <param name="firstNumber">First Numbers</param>
        /// <param name="secondNumber">Second Numbers</param>
        ///<return> Return the instance of the MatheOperation class</return>
        public MathOperations(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        #endregion

        #region "Member Functions" 
        /// <summary>
        /// To Perform Add Operation on firstNumber and SecondNumber
        /// </summary>
        /// <returns> Returns the addition of the numbers</returns>
        public double AddNumbers() => this._AddNumbers(this.firstNumber, this.secondNumber);
        private double _AddNumbers(double num1, double num2) => num1 + num2;

        /// <summary>
        /// To Perform Subtraction on first Number and Second Number
        /// </summary>
        /// <returns>Returns the subtraction of the numbers</returns>
        public double SubtractNumbers() => this._SubtractNumbers(this.firstNumber, this.secondNumber);
        private double _SubtractNumbers(double num1, double num2) => num1 - num2;

        /// <summary>
        /// To Perform Multiplication on first Number and Second Number
        /// </summary>
        /// <returns>Returns the multiplication of the numbers</returns>
        public double MultiplyNumbers() => this._MultiplyNumbers(this.firstNumber, this.secondNumber);
        private double _MultiplyNumbers(double num1, double num2) => num1 * num2;

        /// <summary>
        /// To Perform Division on first Number and Second Number
        /// </summary>
        /// <exception cref="DivideByZeroException">Throw DivideByZeroException when second Number is Zero</exception>
        /// <returns>Returns the division of the numbers</returns>
        public double DivideNumbers() => this._DivideNumbers(this.firstNumber, this.secondNumber);

        private double _DivideNumbers(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Can't divide by 0");
            return num1 / num2;
        }
        #endregion

    }
}
