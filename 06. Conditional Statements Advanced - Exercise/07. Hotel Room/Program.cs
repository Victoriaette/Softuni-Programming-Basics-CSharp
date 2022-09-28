using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            decimal priceStudio = 0;
            decimal priceApartment = 0;
            
            if (month == "May" || month == "October")
            {
                priceStudio = days * 50;
                priceApartment = days * 65;

                if (days > 7 && days <= 14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.05m);                    
                }
                else if (days > 14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.30m);
                    priceApartment = priceApartment - (priceApartment * 0.10m);
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = days * 75.20m;
                priceApartment = days * 68.70m;

                if (days > 14)
                {
                    priceStudio = priceStudio - (priceStudio * 0.20m);
                    priceApartment = priceApartment - (priceApartment * 0.10m);
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = days * 76;
                priceApartment = days * 77;
                    
                if (days > 14)
                {
                    priceApartment = priceApartment - (priceApartment * 0.10m);
                }
            }

            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");

        }
    }
}
