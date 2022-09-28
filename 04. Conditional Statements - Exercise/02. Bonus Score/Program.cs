using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonus = score * 20 / 100;
            }
            else if (score > 1000)
            {
                bonus = score * 10 / 100;
            }


            if (score % 2 == 0)
            {
                bonus = (bonus + 1);
            }
            else if (score % 5 == 0)
            {
                bonus = bonus + 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    }
}
