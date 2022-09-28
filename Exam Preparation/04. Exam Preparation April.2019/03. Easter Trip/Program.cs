using System;

namespace _03._Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double price = 30;

            if (date == "21-23")
            {
                switch (destination)
                {
                    case "France":
                        price = 30;
                        break;
                    case "Italy":
                        price = 28;
                        break;
                    case "Germany":
                        price = 32;
                        break;
                }
            }
            else if (date == "24-27")
            {
                switch (destination)
                {
                    case "France":
                        price = 35;
                        break;
                    case "Italy":
                        price = 32;
                        break;
                    case "Germany":
                        price = 37;
                        break;
                }
            }
            else if (date == "28-31")
            {
                switch (destination)
                {
                    case "France":
                        price = 40;
                        break;
                    case "Italy":
                        price = 39;
                        break;
                    case "Germany":
                        price = 43;
                        break;
                }
            }

            price = price * nights;

            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");

        }
    }
}
