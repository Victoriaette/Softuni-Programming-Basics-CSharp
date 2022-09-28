using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWash = double.Parse(Console.ReadLine());
            int priceForToy = int.Parse(Console.ReadLine());

            int money = 0;
            int toy = 0;

            int giftMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if( i % 2 == 0)
                {
                    giftMoney = giftMoney + 10;
                    money = money + giftMoney;
                    money--;
                }
                else if ( i % 2 != 0)
                {
                    toy++;
                }
            }

            
            double moneyFromToy = toy * priceForToy;

            double allMoney = money + moneyFromToy;

            allMoney = allMoney - priceWash;

            if (allMoney >= 0) 
            {
                Console.WriteLine($"Yes! {allMoney:f2}");
            }
            else
            {
                allMoney = Math.Abs(allMoney);

                Console.WriteLine($"No! {allMoney:f2}");
            }

        }
    }
}
