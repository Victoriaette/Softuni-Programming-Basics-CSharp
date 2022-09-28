using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            decimal price = 0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.50m;
                        break;
                    case "water":
                        price = 0.80m;
                        break;
                    case "beer":
                        price = 1.20m;
                        break;
                    case "sweets":
                        price = 1.45m;
                        break;
                    case "peanuts":
                        price = 1.60m;
                        break;
                    default:
                        price = 0;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.40m;
                        break;
                    case "water":
                        price = 0.70m;
                        break;
                    case "beer":
                        price = 1.15m;
                        break;
                    case "sweets":
                        price = 1.30m;
                        break;
                    case "peanuts":
                        price = 1.50m;
                        break;
                    default:
                        price = 0;
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        price = 0.45m;
                        break;
                    case "water":
                        price = 0.70m;
                        break;
                    case "beer":
                        price = 1.10m;
                        break;
                    case "sweets":
                        price = 1.35m;
                        break;
                    case "peanuts":
                        price = 1.55m;
                        break;
                    default:
                        price = 0;
                        break;
                }
            }

            Console.WriteLine((decimal)quantity * price);
        }
    }
}
