using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sheet = int.Parse(Console.ReadLine());
            int paint =  int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            double sheetPrice = (sheet + 2) * 1.50;
            double paintPraice = (paint + (paint * 0.10)) * 14.50;
            double thinnerPrice = thinner * 5;

            double fullPrice = sheetPrice + paintPraice + thinnerPrice + 0.40;
            double hours = fullPrice * 0.30 * people;
            fullPrice = fullPrice + hours;


            Console.WriteLine(fullPrice);
        }

    }
}
