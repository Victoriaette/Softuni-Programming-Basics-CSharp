using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget = double.Parse(Console.ReadLine());
           double numberOfExtras = double.Parse(Console.ReadLine());    
           double clothingPrice = double.Parse(Console.ReadLine());

            //decor price
            budget = budget - budget * 0.1; 

            clothingPrice = clothingPrice * numberOfExtras; 

            if (numberOfExtras > 150)
            {
                clothingPrice = clothingPrice - clothingPrice * 0.1;
            }

            budget = budget - clothingPrice;

            

            if(budget < 0)
            {
                budget = Math.Abs(budget);

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");

            }
        }
    }
}
