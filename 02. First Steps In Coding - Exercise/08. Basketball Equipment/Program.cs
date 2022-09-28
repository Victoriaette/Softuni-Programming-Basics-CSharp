using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basketbollTax = int.Parse(Console.ReadLine());

            double shoes = basketbollTax - (basketbollTax * 0.40);
            double clothes = shoes - (shoes * 0.20);
            double ball = clothes / 4;
            double accessories = ball / 5;

            double fullPrice = basketbollTax + shoes + clothes + ball + accessories;

            Console.WriteLine(fullPrice);
        }
    }
}
