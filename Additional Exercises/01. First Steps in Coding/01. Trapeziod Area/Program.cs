﻿using System;

namespace _01._Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double face = (a + b) * h / 2;

            Console.WriteLine($"{face:f2}");
        }
    }
}
