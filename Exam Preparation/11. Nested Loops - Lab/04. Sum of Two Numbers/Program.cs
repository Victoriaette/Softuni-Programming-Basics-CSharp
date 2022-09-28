using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine()); 
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            int result = 0;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    
                    result = num1 + num2;

                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {magicNumber})");
                        return;
                    }
                }
            }

                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}