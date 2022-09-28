using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double dog = 0;
            double cat = 0;

            double cookies = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double CatFood = double.Parse(Console.ReadLine());

                dog += dogFood;
                cat += CatFood;

                if (i % 3 == 0)
                {
                    cookies += (dogFood + CatFood) * 0.10;
                }

            }

            double allFood = cat + dog;

            double percentFood = allFood / food * 100; 
            double precentDog = dog / allFood * 100;
            double precentCat = cat / allFood * 100;


            Console.WriteLine($"Total eaten biscuits: {Math.Round(cookies)}gr.");
            Console.WriteLine($"{percentFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{precentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{precentCat:f2}% eaten from the cat.");
        }
    }
}
