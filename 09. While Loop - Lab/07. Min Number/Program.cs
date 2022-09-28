using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int minValue = int.MaxValue;

            while (n != "Stop")
            {


                if (int.Parse(n) < minValue)
                {
                    minValue = int.Parse(n);
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(minValue);
        }
    }
}
