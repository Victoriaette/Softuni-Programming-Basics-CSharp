using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());

            decimal side = x * y; 
            decimal window = 1.5m * 1.5m; 
            decimal bothSides = 2 * side - 2 * window; 
            decimal back = x * x;
            decimal door = 1.2m * 2;
            decimal frontAndBack = 2 * back - door;

            decimal sidesSum = bothSides + frontAndBack;
            decimal greenPaint = sidesSum / 3.4m;


            decimal roofSides = 2 * (x * y); // 120
            decimal roofFrontAndBack = (x * h / 2) * 2; // 31.2

            decimal roofSum = roofSides + roofFrontAndBack;  // 151.2
            decimal redPaint = roofSum / 4.3m;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");


        }
    }
}
