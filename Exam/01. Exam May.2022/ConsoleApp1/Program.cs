using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precentFat = double.Parse(Console.ReadLine());
            double precentProtein = double.Parse(Console.ReadLine());
            double precentCarb = double.Parse(Console.ReadLine());
            double fullCountCal = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double countFat = (fullCountCal * precentFat / 100) / 9;
            double countProtein = (fullCountCal * precentProtein / 100) / 4;
            double countCarb = (fullCountCal * precentCarb / 100) / 4;

            double food = countFat + countProtein + countCarb;
            double calories = fullCountCal / food;

            water = 100 - water;

            double caloriesInGram = calories * water / 100;

            Console.WriteLine($"{caloriesInGram:f4}");
        }
    }
}
