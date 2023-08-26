﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Calc
{
    public class CalculatorFunctions
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Ділення на нуль неможливе.");
            }
        }

    }
}
