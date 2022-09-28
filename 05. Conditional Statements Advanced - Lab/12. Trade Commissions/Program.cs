using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sum = double.Parse(Console.ReadLine());

            decimal procent = 0;

            if (sum < 0)
            {
                Console.WriteLine("error");
            }
            else if (town == "Sofia")
            {
                if (sum >= 0 && sum <= 500)
                {
                    procent = 0.05m;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    procent = 0.07m;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    procent = 0.08m;
                }
                else if (sum > 1000 )
                {
                    procent = 0.12m;
                }
                Console.WriteLine($"{((decimal)sum * procent):f2}");                            
            }
            else if (town == "Varna")
            {
                if (sum >= 0 && sum <= 500)
                {
                    procent = 0.045m;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    procent = 0.075m;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    procent = 0.10m;
                }
                else if (sum > 1000)
                {
                    procent = 0.13m;
                }
                Console.WriteLine($"{((decimal)sum * procent):f2}");
            }
            else if (town == "Plovdiv")
            {
                if (sum >= 0 && sum <= 500)
                {
                    procent = 0.055m;
                }
                else if (sum > 500 && sum <= 1000)
                {
                    procent = 0.08m;
                }
                else if (sum > 1000 && sum <= 10000)
                {
                    procent = 0.12m;
                }
                else if (sum > 1000)
                {
                    procent = 0.145m;
                }
                Console.WriteLine($"{((decimal)sum * procent):f2}");
            }          
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}