using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningProduct = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pencilsPrice = pencils * 5.80;
            double markersPrice = markers * 7.20;
            double cleaningProductPrice = cleaningProduct * 1.20;

            double totalPrice = pencilsPrice + markersPrice + cleaningProductPrice;
            totalPrice = totalPrice - (totalPrice * discount / 100);

            Console.WriteLine(totalPrice);
        }
    }
}
