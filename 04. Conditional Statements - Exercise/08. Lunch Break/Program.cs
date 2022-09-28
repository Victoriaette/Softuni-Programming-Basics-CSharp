using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            double episode = double.Parse(Console.ReadLine());
            double breakTime = double.Parse(Console.ReadLine());

            double lunch = breakTime / 8;
            double chillTime = breakTime / 4;

            double leftTime = breakTime - lunch - chillTime;

            double freeTime = Math.Ceiling(Math.Abs(leftTime - episode));


            if (leftTime >= episode)
            {

                Console.WriteLine($"You have enough time to watch {title} and left with {freeTime} minutes free time.");
            }
            else
            {
                Console.Write($"You don't have enough time to watch {title}, you need {freeTime} more minutes.");
            }
        }
    }
}
