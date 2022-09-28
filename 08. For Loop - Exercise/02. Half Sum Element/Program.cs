using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;

            int sum = 0;

            for (int i = 1; i<=n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum = sum + number;
                
                if (number > maxValue)
                {
                    maxValue = number;
                }            
            }

            sum = sum - maxValue;

            if (sum == maxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxValue);
            }
            else
            { 
                int diff = Math.Abs(sum - maxValue);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
