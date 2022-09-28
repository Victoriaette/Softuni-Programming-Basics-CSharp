using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double space = double.Parse(Console.ReadLine());
            string suitCases = Console.ReadLine();

            int suitcase = 0;

            double caseVolume = 0;

            while (suitCases != "End")
            {

                suitcase++;

                if (suitcase % 3 == 0)
                {
                    caseVolume = double.Parse(suitCases) + double.Parse(suitCases) * 0.10;
                }
                else
                {
                    caseVolume = double.Parse(suitCases);
                }


                if (space < caseVolume)
                {
                    suitcase--;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcase} suitcases loaded.");
                    return;
                }

                space -= caseVolume;

                suitCases = Console.ReadLine();

            }

            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitcase} suitcases loaded.");
        }
    }
}
