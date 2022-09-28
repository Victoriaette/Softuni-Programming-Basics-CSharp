using System;

namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitCoin = int.Parse(Console.ReadLine());
            double yuna = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            bitCoin = bitCoin * 1168;
            yuna = yuna * 0.15;
            double leva = yuna * 1.76;

            leva = bitCoin + leva;

            double euro = leva / 1.95;

            commision = euro * commision / 100;
            euro = euro - commision;

            Console.WriteLine($"{euro:f2}");

        }
    }
}
