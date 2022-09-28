using System;

namespace _10._Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (degree >= 5 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (degree >= 12 && degree <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 15 && degree <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 20.1 && degree <= 25.9)
            {
                System.Console.WriteLine("Warm");
            }
            else if (degree >= 26 && degree <= 35)
            {
                Console.WriteLine("Hot");
            }   
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
