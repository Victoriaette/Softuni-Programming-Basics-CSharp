using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());

            double distantInMeter = double.Parse(Console.ReadLine());   
            double timeForMeter = double.Parse(Console.ReadLine());



            double IvanTime = distantInMeter * timeForMeter;

            double waterResistentTime = Math.Floor((distantInMeter / 15)) * 12.5;

            IvanTime = IvanTime + waterResistentTime;

            double ivanResult = Math.Abs(recordInSeconds - IvanTime);

            if (recordInSeconds > IvanTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivanResult:f2} seconds slower.");
            }
        }
    }
}
