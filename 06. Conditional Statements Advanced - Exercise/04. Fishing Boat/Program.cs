using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double num = double.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;

            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }



            if (num <= 6)
            {
                price = price - (price * 0.10);
            }
            else if (num >= 7 && num <= 11)
            {
                price = price - (price * 0.15);
            }
            else if (num >= 12)
            {
                price = price - (price * 0.25);
            }



            if( num  % 2 == 0 && season != "Autumn")
            {
                price = price - (price * 0.05);
            }

            budget = budget - price;
            
            if (budget < 0)
            {
                budget = Math.Abs(budget);
                Console.WriteLine($"Not enough money! You need {budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget:f2} leva left.");
            }
        }
    }
}
