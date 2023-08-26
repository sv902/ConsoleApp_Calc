using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Введіть перше число: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Виберіть операцію (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            if (operation == '+')
            {
                result = CalculatorFunctions.Add(num1, num2);
            }

            else if (operation == '-')
            {
                result = CalculatorFunctions.Subtract(num1, num2);
            }
            else if (operation == '*')
            {
                result = CalculatorFunctions.Multiply(num1, num2);
            }
            else if (operation == '/')
            {
                try
                {
                    result = CalculatorFunctions.Divide(num1, num2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                    return;
                }
            }
            else
            {
                Console.WriteLine("Невідома операція.");
                return;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
