using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vacationSea = int.Parse(Console.ReadLine());
            int vacationMountin = int.Parse(Console.ReadLine());
            

            int income = 0;

            while (true)
            {
                string typeVacation = Console.ReadLine();

                if (typeVacation == "Stop")
                {
                    break;
                }


                if (vacationSea == 0 && vacationMountin == 0)
                {
                    Console.WriteLine(" Good job! Everything is sold.");
                    Console.WriteLine($"Profit: {income} leva.");
                    return;
                }

                if (typeVacation == "sea")
                {
                    if (vacationSea == 0)
                    {
                        continue;
                    }
                    vacationSea--;
                    income += 680;
                }
                else if (typeVacation == "mountain")
                {
                    if (vacationMountin == 0)
                    {
                        continue;
                    }
                    vacationMountin--;
                    income += 499;
                }

                
            }

            Console.WriteLine($"Profit: {income} leva.");
        }
    }
}
