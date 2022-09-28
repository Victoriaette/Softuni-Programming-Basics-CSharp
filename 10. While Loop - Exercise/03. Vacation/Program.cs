using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            string action = Console.ReadLine();
            double actionMoney = double.Parse(Console.ReadLine());

            int spendMoney = 0;           
            int days = 0;
            double savedMoney = ownedMoney;

            while (true)
            {

                days++;

                if (action == "spend")
                {
                    spendMoney++;

                    savedMoney -= actionMoney;

                    if (savedMoney < 0)
                    {
                        savedMoney = 0;

                    }

                    if (spendMoney == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }

                }

                if (action == "save")
                {
                    spendMoney = 0;
                        
                    savedMoney += actionMoney;

                    if(savedMoney >= vacation)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }

                }
                
                action = Console.ReadLine();
                actionMoney = double.Parse(Console.ReadLine());
            }
        }
    }
}
