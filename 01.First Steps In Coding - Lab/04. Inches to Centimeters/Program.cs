﻿using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 2.54;

            a = a * b;

            Console.WriteLine(a);
        }
    }
}
