using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ground = double.Parse(Console.ReadLine());



            double price = 7.61;
            double procent = 0.18;



            double finalPrice = ground * price;

            double discount = procent * finalPrice;

            double discountPrice = finalPrice - discount;

            Console.WriteLine("The final price is: " + discountPrice + " lv.");
            Console.WriteLine("The discount is:" + discount + " lv.");
        }
    }
}
