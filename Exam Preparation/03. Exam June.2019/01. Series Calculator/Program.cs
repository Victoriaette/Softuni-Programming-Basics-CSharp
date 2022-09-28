using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            int lenghtOfEpisode = int.Parse(Console.ReadLine());

            double addTime = lenghtOfEpisode * 0.20;
            double episodeWithAdd = lenghtOfEpisode + addTime;
            double extraTimeSpecial = seasons * 10;


            double timeNeeded = Math.Floor(episodeWithAdd * episodes * seasons + extraTimeSpecial);

            Console.WriteLine($"Total time needed to watch the {series} series is {timeNeeded} minutes.");
        }
    }
}
