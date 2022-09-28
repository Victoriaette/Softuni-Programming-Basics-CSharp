using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            

            if (people <= 5)
            {
                switch (season)
                {
                    case "spring":
                        price = 50;
                        break;
                    case "summer":
                        price = 48.50;
                        break;
                    case "autumn":
                        price = 60;
                        break;
                    case "winter":
                        price = 86;
                        break;
                }
            }
            else if (people > 5)
            {
                switch (season)
                {
                    case "spring":
                        price = 48;
                        break;
                    case "summer":
                        price = 45;
                        break;
                    case "autumn":
                        price = 49.50;
                        break;
                    case "winter":
                        price = 85;
                        break;
                }
            }

            price = price * people;
            
            if (season == "summer")
            {
                price = price - (price * 0.15); 
            }
            else if (season == "winter")
            {
                price = price + (price * 0.08);
            }

            Console.WriteLine($"{price:f2} leva.");
        }
    }
}
