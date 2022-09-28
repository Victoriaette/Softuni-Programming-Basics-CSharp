using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money =  decimal.Parse(Console.ReadLine());

            int coinCounter = 0;

            decimal twolev = 2;
            decimal lev = 1;
            decimal p50 = 0.50m;
            decimal p20 = 0.20m;
            decimal p10 = 0.10m;
            decimal p5 = 0.05m;
            decimal p2 = 0.02m;
            decimal p1 = 0.01m;

            
            
                
                while (money >= twolev)
                {
                    money -= twolev;

                    coinCounter++;
                }

                while (money >= lev)
                {
                    money -= lev;

                    coinCounter++;
                }

                while (money >= p50)
                {
                    money -= p50;

                    coinCounter++;
                }

                while (money >= p20)
                {
                    money -= p20;

                    coinCounter++;
                }

                while (money >= p10 )
                {
                    money -= p10;

                    coinCounter++;
                }

                while (money >= p5 )
                {
                    money -= p5;

                    coinCounter++;
                }

                while (money >= p2 )
                {
                    money -= p2;

                    coinCounter++;
                }

                while (money >= p1)
                {
                    money -= p1;

                    coinCounter++;
                }

            Console.WriteLine(coinCounter);
        }
    }
}
