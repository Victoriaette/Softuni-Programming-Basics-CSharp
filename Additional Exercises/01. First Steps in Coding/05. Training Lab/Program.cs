using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            w = w * 100 ;
            h = h * 100 - 100;

            double deskSpaceH = Math.Floor(h / 70);
            double deskSpaceW =Math.Floor(w / 120);

            double desk = deskSpaceW * deskSpaceH - 3;

            Console.WriteLine($"{desk:f2}");
                 

        }
    }
}
