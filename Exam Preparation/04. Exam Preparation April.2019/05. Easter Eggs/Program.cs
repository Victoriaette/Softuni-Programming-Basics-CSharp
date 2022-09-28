using System;

namespace _05._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            int maxEggs = int.MinValue;
            string bestColor = "";

            for (int i = 1; i <= paintedEggs; i++)
            {
                if (color == "red")
                {
                    red++;
                    if (red > maxEggs)
                    {
                        maxEggs = red;
                        bestColor = "red";
                    }
                }
                else if (color == "orange")
                {
                    orange++;
                    if (orange > maxEggs)
                    {
                        maxEggs = orange;
                        bestColor = "orange";
                    }
                }
                else if (color == "blue")
                {
                    blue++;
                    if (blue > maxEggs)
                    {
                        maxEggs = blue;
                        bestColor = "blue";
                    }
                }
                else if (color == "green")
                {
                    green++;
                    if (green > maxEggs)
                    {
                        maxEggs = green;
                        bestColor = "green";
                    }

                }

                color = Console.ReadLine();
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {bestColor}");
        }
    }
}
