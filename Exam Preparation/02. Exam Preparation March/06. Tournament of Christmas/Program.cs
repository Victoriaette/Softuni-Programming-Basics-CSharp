using System;

namespace _06._Tournament_of_Christmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            int winCount = 0;
            int lostCount = 0;
            

            for (int i = 1; i <= tournamentDays; i++)
            {
                double dailyMoney = 0;
                int dailyWins = 0;
                int dailyLosses = 0;

                while (true)
                {
                    
                    string games = Console.ReadLine();

                    if ( games == "Finish")
                    {
                        break;
                    }

                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                       
                        dailyMoney += 20;
                        dailyWins++;
                    }
                    else
                    {
                        dailyLosses++;
                    }


                }

                if(dailyWins> dailyLosses)
                {
                    dailyMoney = dailyMoney + (dailyMoney * 0.10);
                    winCount++;
                }
                else
                {
                    lostCount++;
                }

                totalMoney += dailyMoney;
            }

            if (winCount > lostCount)
            {
                totalMoney = totalMoney + (totalMoney * 0.20);
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
