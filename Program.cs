using System;
using System.ComponentModel.Design;

namespace Calculator
{
    class Calculator
    {
        static void Main(String[] args)
        {

            //Declaration of Variables

            int choice;
            double num1 = 0;
            double num2 = 0;

            CalcFunction calc = new CalcFunction();


            //loop using do-while

            do
            {
                calc.menu();
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    calc.calcBody(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (choice == 2)
                {
                    calc.calcBody(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (choice == 3)
                {
                    calc.calcBody(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (choice == 4)
                {
                    calc.calcBody(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

                else if (choice == 5)
                {
                    calc.calcFunction(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    calc.calcFunction(num1, num2, choice);
                    Console.ReadKey();
                    Console.Clear();
                }

            }

            while (choice != 5);
           
        }
        
    }
}   
