using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            double musala = 0;
            double montblanc = 0;
            double kalimanjaro = 0;
            double k2 = 0;
            double everest = 0;

            int numberOfPeople = 0;

            for (int i = 1; i <= n; i++)
            {
                int group = int.Parse(Console.ReadLine());

                 numberOfPeople = numberOfPeople + group;

                if(group <= 5)
                {
                    musala = musala + group;
                }
                else if ( group >=6 && group <= 12)
                {
                    montblanc = montblanc + group;
                }
                else if ( group >= 13 && group <= 25)
                {
                    kalimanjaro = kalimanjaro + group;
                } 
                else if ( group >= 26 && group <= 40)
                {
                    k2 = k2 + group;
                }
                else if ( group >= 41)
                {
                    everest = everest + group;
                }
                                  
            }

            musala = musala / numberOfPeople * 100;
            montblanc = montblanc / numberOfPeople * 100;
            kalimanjaro = kalimanjaro / numberOfPeople * 100;
            k2 = k2 / numberOfPeople * 100;
            everest = everest / numberOfPeople * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{montblanc:f2}%");
            Console.WriteLine($"{kalimanjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");

        }
    }
}

