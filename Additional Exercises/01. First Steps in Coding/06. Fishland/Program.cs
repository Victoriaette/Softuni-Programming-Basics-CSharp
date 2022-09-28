using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal mackerelPriceKg = decimal.Parse(Console.ReadLine());
            decimal spratPriceKg = decimal.Parse(Console.ReadLine());

            decimal bonitoKg = decimal.Parse(Console.ReadLine());
            decimal scadKg = decimal.Parse(Console.ReadLine());
            decimal musselsKg = decimal.Parse(Console.ReadLine());

            decimal bonitoPrice = (mackerelPriceKg + (mackerelPriceKg * 0.60m)) * bonitoKg; 
            decimal scadPrice = (spratPriceKg + (spratPriceKg * 0.80m)) * scadKg; 
            decimal musselsPrice = musselsKg * 7.50m; 

            decimal totalSum = bonitoPrice + scadPrice + musselsPrice;

            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
