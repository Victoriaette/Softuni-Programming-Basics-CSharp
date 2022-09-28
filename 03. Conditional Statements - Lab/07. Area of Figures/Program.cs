﻿using System;

namespace _07._Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                 area = a * a;
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                 area = a * b;

            }
            else if (shape == "circle")

            {
                double r = double.Parse(Console.ReadLine());
                 area = Math.PI * r * r;
            }
            else if  (shape == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                 area = (c * hc) / 2;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
