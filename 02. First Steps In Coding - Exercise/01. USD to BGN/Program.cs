using System;

namespace _01._USD_to_BGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double exchangeRate = 1.79549;

            double bgn = usd * exchangeRate;

            Console.WriteLine(bgn);
        }
    }
}
