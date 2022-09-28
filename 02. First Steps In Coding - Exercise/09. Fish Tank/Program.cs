using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double precent = double.Parse(Console.ReadLine());

            int mass = a * b * c;
            double liter = mass * 0.001;
            precent = precent / 100;

            double result = liter * (1 - precent);

            Console.WriteLine(result);
        }
    }
}
