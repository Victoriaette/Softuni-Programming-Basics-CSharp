using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();

            int adultTickets = int.Parse(Console.ReadLine());
            int childTickets = int.Parse(Console.ReadLine());

            double netoTaxAdult = double.Parse(Console.ReadLine());

            double tax = double.Parse(Console.ReadLine());


            double childSum = (netoTaxAdult - ( netoTaxAdult * 0.70)) + tax;
            double adultSum = netoTaxAdult + tax;

            double sum = ( childSum * childTickets) + ( adultSum * adultTickets);

            double profit = sum * 0.20;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");
        }
    }
}
