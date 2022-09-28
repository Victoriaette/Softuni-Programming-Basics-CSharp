using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesOfBook = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeNeeded = pagesOfBook / pagesForHour;
            timeNeeded = timeNeeded / days;

            Console.WriteLine(timeNeeded);
        }
    }
}
