using System;

namespace _02._Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guest = int.Parse(Console.ReadLine());
            double priceForGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;
            

            if (guest >= 10 && guest <= 15)
            {
                priceForGuest = priceForGuest - (priceForGuest * 0.15);
                
            }
            else if (guest > 15 && guest <= 20)
            {
                priceForGuest = priceForGuest - (priceForGuest * 0.20);
            }
            else if (guest > 20)
            {
                priceForGuest = priceForGuest - (priceForGuest * 0.25);
            }
            

            double cake = budget * 0.10;

            price = guest * priceForGuest + cake;

            budget = budget - price;


            if (budget >= 0)
            {
                
                Console.WriteLine($"It is party time! {budget:f2} leva left.");
            }
            else
            {
                
                Console.WriteLine($"No party! {Math.Abs(budget):f2} leva needed.");
            }

        }
    }
}
