using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string type = Console.ReadLine();

            int row = int.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());

            double price = 0;

            switch (type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;

            }
            double income = (row * line) * price;
            Console.WriteLine($"{income}");
        }
    }
}
