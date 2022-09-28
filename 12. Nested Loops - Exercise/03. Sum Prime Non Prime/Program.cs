using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            bool flag = false;
            
           while (num != "stop")
           {
                flag = false;
                int m = int.Parse(num) / 2 ;
                
                if (int.Parse(num) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;

                }

                for (int i = 2; i <= m; i++)
                {
                    


                    if (int.Parse(num) % i == 0)
                    {

                        nonPrimeSum += int.Parse(num);
                        flag = true;
                        break;
                        
                    }
                }
                

                if (flag)
                {
                    primeSum += int.Parse(num);

                }

                num = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
