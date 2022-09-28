using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double priceVegitable = double.Parse(Console.ReadLine());
            double priceFruit = double.Parse(Console.ReadLine());
            double totalVegitableKgs = double.Parse(Console.ReadLine());
            double totalFruitKgs = double.Parse(Console.ReadLine());

            double leva = (priceVegitable * totalVegitableKgs) + (priceFruit * totalFruitKgs);
            double euro = leva / 1.94;

            Console.WriteLine($"{euro:f2}");


        }
    }
}
