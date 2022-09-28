using System;

namespace _01._Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bread = int.Parse(Console.ReadLine());
            int boxOfEggs = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double priceBread = bread * 3.20;
            double priceEggs = boxOfEggs * 4.35;
            double priceCookies = cookiesKg * 5.40;
            double pricePaintForEggs = boxOfEggs * 12 * 0.15;

            double moneyForLunch = priceBread + priceEggs + priceCookies + pricePaintForEggs;

            Console.WriteLine($"{moneyForLunch:f2}");



        }
    }
}
