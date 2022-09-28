using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            while ( sum < n)
            {
               int num = int.Parse(Console.ReadLine());

                sum = sum + num;
            }

            Console.WriteLine(sum);
                          
        }
    }
}
