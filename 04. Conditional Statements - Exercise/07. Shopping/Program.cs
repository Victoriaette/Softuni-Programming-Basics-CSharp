using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); 
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());  
            int ram = int.Parse(Console.ReadLine());

            double gpuPrice = gpu * 250;
            double cpuPrice = cpu * (gpuPrice * 0.35);
            double ramPrice = ram * (gpuPrice * 0.1);   

            double fullPrice = gpuPrice + cpuPrice + ramPrice;
            

            if (gpu > cpu)
            {
                fullPrice = fullPrice - fullPrice * 0.15;
            }

            double finalPrice = Math.Abs(budget - fullPrice);

            if (fullPrice <= budget)
            {
                Console.WriteLine($"You have {finalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice:f2} leva more!");
            }
            
        }
    }
}
