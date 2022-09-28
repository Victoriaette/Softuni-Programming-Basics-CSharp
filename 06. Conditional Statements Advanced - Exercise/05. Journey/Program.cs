using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = null;
            double price = 0;
            string place = null;

            if (budget <= 100 )
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    price = budget * 0.30;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.70;
                    place = "Hotel";
                }
            }
            else if ( budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
               
                if (season == "summer")
                {
                    price = budget * 0.40;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    price = budget * 0.80;
                }

            }
            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {price:f2}");
        }
    }
}
