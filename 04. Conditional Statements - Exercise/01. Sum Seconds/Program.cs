using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minute = totalTime / 60;
            int second = totalTime % 60; 
            
            if ( second < 10 )
            {
                Console.WriteLine($"{minute}:0{second}");
            }
            else
            {
                Console.WriteLine($"{minute}:{second}");
            }
        }
    }
}
