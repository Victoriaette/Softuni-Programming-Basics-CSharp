using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double allPoints = pointsAcademy;

            string name = null;

            for (int i = 1; i <= judges; i++)
            {
                 name = Console.ReadLine();
                double currentPoints = double.Parse(Console.ReadLine());

                allPoints += ((name.Length * currentPoints) / 2);

                if (allPoints > 1250.5)
                {
                    break;
                }
            }
            

            if(allPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {allPoints:f1}!");
            }
            else
            {
                allPoints = 1250.5 - allPoints;
                Console.WriteLine($"Sorry, {actor} you need {allPoints:f1} more!");
            }
        }
    }
}
