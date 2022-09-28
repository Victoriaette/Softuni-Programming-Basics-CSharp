using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositeSum = double.Parse(Console.ReadLine());
            double depositeTime = double.Parse(Console.ReadLine());
            double taxProcent = double.Parse(Console.ReadLine());
            taxProcent = taxProcent / 100;

            double sum = depositeSum + depositeTime * ((depositeSum * taxProcent) / 12.0);

            Console.WriteLine(sum);

        }
    }
}
