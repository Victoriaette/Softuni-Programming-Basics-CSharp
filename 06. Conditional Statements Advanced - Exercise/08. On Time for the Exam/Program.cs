using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHour * 60 + examMinute;
            int arriveTotalMinutes = arriveHour * 60 + arriveMinute;

            int minutesDifference = examTotalMinutes - arriveTotalMinutes;

            if ( minutesDifference == 0)
            {
                Console.WriteLine("On time");
            }
            else if (minutesDifference >0 && minutesDifference <= 30)
            {
                Console.WriteLine($"on time {minutesDifference} minutes before the start");
            }

            else if (minutesDifference > 30)
            {
                int hours = minutesDifference / 60;
                int minutes = minutesDifference % 60;

                if (hours > 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes.ToString("00")} hours before the start");
                }
                else if ( hours == 0 )
                {

                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (minutesDifference < 0 )
            {
                minutesDifference = Math.Abs(minutesDifference);
                int hours = minutesDifference / 60;
                int minutes = minutesDifference % 60;

                if (hours > 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{minutes.ToString("00")} hours after the start");
                }
                else if (hours == 0)
                {

                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
