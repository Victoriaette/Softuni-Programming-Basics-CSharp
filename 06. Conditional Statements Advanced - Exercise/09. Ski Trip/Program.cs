using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            double price = 0;

            if (typeRoom == "room for one person")
            {
                price = (days - 1) * 18;

                if (grade == "positive")
                {
                    price = price + (price * 0.25);
                }
                else if (grade == "negative")
                {
                    price = price - (price * 0.10);
                }    
            }
            else if (typeRoom == "apartment")
            {
                price = (days - 1) * 25;  

                if (days < 10)
                {
                    price = price - (price * 0.30);
                }
                else if (days == 10 || days <= 15 )
                {
                    price = price - (price * 0.35); 
                }
                else if (days > 15)
                {
                    price = price - (price * 0.50);
                }

                if (grade == "positive")
                {
                    price = price + (price * 0.25); 
                }
                else if (grade == "negative")
                {
                    price = price - (price * 0.10);
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = (days - 1) * 35; 

                if (days < 10)
                {
                    price = price - (price * 0.10);
                }
                else if (days == 10 || days <= 15)
                {
                    price = price - (price * 0.15);
                }
                else if (days > 15)
                {
                    price = price - (price * 0.20); 
                }

                if (grade == "positive")
                {
                    price = price + (price * 0.25);
                }
                else if (grade == "negative")
                {
                    price = price - (price * 0.10);
                }
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
