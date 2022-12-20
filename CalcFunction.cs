using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalcFunction
    {
        public double calcFunction(double num1, double num2, int op)
        {
            double result = 0.0;

            switch (op)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                case 5:
                    Console.WriteLine("Calculator is closing...");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again!");
                    break;
            }

            return result;
        }

        public void menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Please input the number of your answer: ");
        }

        public double calcBody(double num1, double num2, int choice1)
        {
            double result = 0.0;
            Console.Write("Enter your first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + calcFunction(num1, num2, choice1));
            Console.WriteLine();
            return result;

        }
    }
}
