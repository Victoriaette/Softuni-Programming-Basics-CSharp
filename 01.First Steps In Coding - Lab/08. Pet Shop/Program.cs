using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogBox = int.Parse(Console.ReadLine());

            int catBox = int.Parse(Console.ReadLine());

            double dogprice = 2.5;
            int catprice = 4;

           Console.WriteLine(dogBox * dogprice + catBox * catprice + " lv.");
        }
    }
}
