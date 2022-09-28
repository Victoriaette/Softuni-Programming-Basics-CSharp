using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            string outfit = null;
            string shoes = null;

            if (degree >= 10 && degree <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";                     
                        break;
                    case "Afternoon":                      
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degree > 18 && degree <= 24)
            {
                switch (time)
                {
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Morning":
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degree >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
