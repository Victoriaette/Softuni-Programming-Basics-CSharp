using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int loft = a * b * c;

            string box = Console.ReadLine();

            while (true)
            {

                if (box == "Done")
                {
                    if (loft >= 0)
                    {
                        Console.WriteLine($"{loft} Cubic meters left.");
                        break;
                    }

                }

                loft -= int.Parse(box);

                if (loft < 0)
                {

                    Console.WriteLine($"No more free space! You need {Math.Abs(loft)} Cubic meters more.");

                    break;
                }

                box = Console.ReadLine();
            }
        }
    }
}
