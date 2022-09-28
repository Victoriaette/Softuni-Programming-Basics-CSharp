using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());

            int bestGrade = 0; ;
            string bestName = "";

            for (int i = 1; i <= easterBreads; i++)
            {
                string cheff = Console.ReadLine();
                string score = Console.ReadLine();

                int grade = 0;
                

                while (score != "Stop")
                {

                    grade += int.Parse(score);

                    score = Console.ReadLine();

                }

                Console.WriteLine($"{cheff} has {grade} points.");

                if (grade > bestGrade)
                {
                    Console.WriteLine($"{cheff} is the new number 1!");
                    bestGrade = grade;
                    bestName = cheff;

                }

                
            }

            Console.WriteLine($"{bestName} won competition with {bestGrade} points!");

        }
    }
}
