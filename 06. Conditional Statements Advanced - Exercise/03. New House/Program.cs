using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());  
            double budget = int.Parse(Console.ReadLine());

            double price = quantity * 0;
            

            if (typeFlower == "Roses")
            {
                price = quantity * 5;

                if (quantity > 80)
                {
                    price = price - (price * 0.10);
                }
            }
            else if (typeFlower == "Dahlias")
            {
                price = quantity * 3.80;

                if (quantity > 90)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (typeFlower == "Tulips")
            {
                price = quantity * 2.80;

                if (quantity > 80)
                {
                    price = price - (price * 0.15);
                }
            }
            else if (typeFlower == "Narcissus")
            {
                price = quantity * 3;

                if (quantity < 120)
                {
                    price = price + (price * 0.15);
                }
            }
            else if (typeFlower == "Gladiolus")
            {
                price = quantity * 2.50;
                if (quantity < 80)
                {
                    price = price + (price * 0.20);
                }
            }

            budget = budget - price;

            if (budget >= 0 )
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeFlower} and {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget):f2} leva more.");
            }


        }
    }
}
