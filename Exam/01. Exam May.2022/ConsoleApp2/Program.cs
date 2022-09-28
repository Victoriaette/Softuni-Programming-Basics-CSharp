using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveLetter = int.Parse(Console.ReadLine());
            int waxRose = int.Parse(Console.ReadLine());
            int keyholder = int.Parse(Console.ReadLine());
            int sketch = int.Parse(Console.ReadLine());
            int surpriseBox = int.Parse(Console.ReadLine());

            double loveLetterPrice = 0.60;
            double waxRosePrice = 7.20;
            double keyholderPrice = 3.60;
            double sketchPrice = 18.20;
            double surpriseBoxPrice = 22;

            int orderCount = loveLetter + waxRose + keyholder + sketch + surpriseBox;
            double fullPrice = (loveLetter * loveLetterPrice) + (waxRose * waxRosePrice) + (keyholder * keyholderPrice) + (sketch * sketchPrice) + (surpriseBox * surpriseBoxPrice);

            if (orderCount > 25)
            {
                fullPrice = fullPrice - (fullPrice * 0.35);

            }

            fullPrice = fullPrice - (fullPrice * 0.10);

            if (partyPrice <= fullPrice)
            {
                fullPrice = fullPrice - partyPrice;
                Console.WriteLine($"Yes! {fullPrice:f2} lv left.");
            }
            else
            {
                fullPrice = partyPrice - fullPrice;
                Console.WriteLine($"Not enough money! {fullPrice:f2} lv needed.");
            }
        }
    }
}
