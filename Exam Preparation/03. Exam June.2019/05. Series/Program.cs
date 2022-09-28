using System;

namespace _05._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfSeries = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= numOfSeries; i++)
            {
                string series = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                switch (series)
                {
                    case "Thrones":
                        price = price - (price * 0.50);
                        break;
                    case "Lucifer":
                        price = price - (price * 0.40);
                            break;
                    case "Protector":
                        price = price - (price * 0.30);
                        break;
                    case "TotalDrama":
                        price = price - (price * 0.20);
                        break;
                    case "Area":
                        price = price - (price * 0.10);
                        break;
                }

                totalPrice += price;
            }

            if (budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"You bought all the series and left with {leftMoney:f2} lv.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"You need {moneyNeeded:f2} lv. more to buy the series!");

            }
        }
    }
}
