using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string snacks = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (movie == "John Wick")
            {
                switch (snacks)
                {
                    case "Drink":
                        price = 12;
                        break;
                    case "Popcorn":
                        price = 15;
                        break;
                    case "Menu":
                        price = 19;
                        break;

                }


            }
            else if (movie == "Star Wars")
            {
                switch (snacks)
                {
                    case "Drink":
                        price = 18;
                        break;
                    case "Popcorn":
                        price = 25;
                        break;
                    case "Menu":
                        price = 30;
                        break;

                }

                if (tickets >= 4)
                {
                    price = price - (price * 0.30);
                }
            }
            else if (movie == "Jumanji")
            {
                switch (snacks)
                {
                    case "Drink":
                        price = 9;
                        break;
                    case "Popcorn":
                        price = 11;
                        break;
                    case "Menu":
                        price = 14;
                        break;

                }

                if (tickets == 2)
                {
                    price = price - (price * 0.15);
                }
            }

            price = price * tickets;

            Console.WriteLine($"Your bill is {price:f2} leva.");

            
        }
    }
}
