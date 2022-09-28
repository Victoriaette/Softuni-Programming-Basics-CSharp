using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOver20Kg = double.Parse(Console.ReadLine());
            double kgLuggage = double.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int luggageCount = int.Parse(Console.ReadLine());


            double luggagePrice = 0;

            if (kgLuggage < 10 )
            {
                luggagePrice = priceOver20Kg * 0.20;
            }
            else if (kgLuggage >= 10 && kgLuggage <= 20 )
            {
                luggagePrice = priceOver20Kg * 0.50;
            }
            else if (kgLuggage > 20)
            {
                luggagePrice = priceOver20Kg;
            }


            if (daysLeft > 30 )
            {
                luggagePrice = luggagePrice + (luggagePrice * 0.10);
            }
            else if (daysLeft >= 7 && daysLeft <=30)
            {
                luggagePrice = luggagePrice + (luggagePrice * 0.15);
            }
            else if (daysLeft < 7)
            {
                luggagePrice = luggagePrice + (luggagePrice * 0.40);
            }

            luggagePrice = luggagePrice * luggageCount;

            Console.WriteLine($" The total price of bags is: {luggagePrice:f2} lv.");
        }
    }
}