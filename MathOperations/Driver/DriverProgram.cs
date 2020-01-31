using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;
namespace Driver
{
    class DriverProgram
    {
        static void Main(string[] args)
        {

            double number1, number2;
            double? result = null;
            bool flag = true;
            int operation=0;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Enter number 1");
                    number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number 2");
                    number2 = double.Parse(Console.ReadLine());
                
                    Console.WriteLine("Enter operation no. :\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Exit");
                    operation = int.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            result = Calculator.AddNumbers(number1, number2);
                            break;
                        case 2:
                            result = Calculator.SubtractNumbers(number1, number2);
                            break;
                        case 3:
                            result = Calculator.MultiplyNumbers(number1, number2);
                            break;
                        case 4:
                            result = Calculator.DivideNumbers(number1, number2);
                            break;
                        case 5:
                            flag = false;
                        break;
                        default:
                            Console.WriteLine("Invalid operation number!!");
                            break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid numbers");
                }
                if(result!=null||operation==5)
                    Console.WriteLine($"Result is : {result}");
            }

           
            
        }
    }
}
