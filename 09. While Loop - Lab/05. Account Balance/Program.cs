using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string i = Console.ReadLine();

            double allMoney = 0;

            while (i != "NoMoreMoney")
            {
                if ( double.Parse(i) < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                allMoney += double.Parse(i);

                Console.WriteLine($"Increase: {double.Parse(i):f2}");

                 i = Console.ReadLine();

            }

            Console.WriteLine($"Total: {allMoney:f2}");
        }
    }
}
