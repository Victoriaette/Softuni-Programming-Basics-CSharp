using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int cake = a * b;

            string piece = Console.ReadLine();

            while (true)
            {

                if (piece == "STOP" )
                {
                    if (cake >=  0)
                    {
                        Console.WriteLine($"{cake} pieces are left.");
                        break;
                    }

                }

                cake -= int.Parse(piece);

                if (cake < 0)
                {
                    
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");

                    break;
                }

                piece = Console.ReadLine();
            }
        }
    }
}
