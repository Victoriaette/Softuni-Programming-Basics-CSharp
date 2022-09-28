using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Spain
            string destination = Console.ReadLine();

            while ( destination != "End")
            {
                double price = double.Parse(Console.ReadLine());


                for (double budget = 0; budget < price;)
                {

                    string savedMoney = Console.ReadLine();
                    
                      budget += double.Parse(savedMoney);
                    
                }


                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
                
            }
        }
    }
}
