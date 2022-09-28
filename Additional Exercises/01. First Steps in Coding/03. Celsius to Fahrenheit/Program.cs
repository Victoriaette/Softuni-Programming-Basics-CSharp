using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Celsius to Fahrenheit formula
            //°F =°C * 1.8000 + 32.00

            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = celsius * 1.8000 + 32.00;

            Console.WriteLine($"{fahrenheit:f2}");
            
        }
    }
}
