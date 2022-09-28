using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            double pointsFromGames = 0;
            int winRate = 0;

            for (int i = 1; i <= games; i++)
            {
                string result = Console.ReadLine();

                if (result == "W")
                {
                    winRate++;
                    pointsFromGames += 2000;
                }
                else if (result == "F")
                {
                    pointsFromGames += 1200;
                }
                else if (result == "SF")
                {
                    pointsFromGames += 720;
                }

            }

            double finalPoints = startPoints + pointsFromGames;
            double averagePoints = Math.Floor(pointsFromGames / games);
            
            double winPercentage = ((double)winRate / games) * 100;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winPercentage:f2}%");

        }
    }
}
