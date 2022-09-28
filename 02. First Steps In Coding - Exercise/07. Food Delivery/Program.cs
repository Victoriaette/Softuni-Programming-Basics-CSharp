using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double fullPrice = (chicken * 10.35) + (fish * 12.40) + (vegan * 8.15);

            double dessert = fullPrice * 0.20;

            fullPrice = fullPrice + dessert + 2.50;

            Console.WriteLine(fullPrice);
            


        }
    }
}
