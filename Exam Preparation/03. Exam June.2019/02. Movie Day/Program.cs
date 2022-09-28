using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForPictures = int.Parse(Console.ReadLine());
            int numOfScenеs = int.Parse(Console.ReadLine());
            int timeOfScenе = int.Parse(Console.ReadLine());

            double preparation = timeForPictures * 0.15;
            double shootingScene = numOfScenеs * timeOfScenе;

            double timeNeded = Math.Round(preparation + shootingScene);

            if (timeForPictures >= timeNeded)
            {
                timeNeded = timeForPictures - timeNeded;
                Console.WriteLine($"You managed to finish the movie on time! You have {timeNeded} minutes left!");
            }
            else
            {
                timeNeded = Math.Abs(timeForPictures - timeNeded);
                Console.WriteLine($"Time is up! To complete the movie you need {timeNeded} minutes.");
            }
        }
    }
}
