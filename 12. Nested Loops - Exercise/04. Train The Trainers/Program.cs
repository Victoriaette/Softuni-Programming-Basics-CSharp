using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double finalScore = 0;
            double averageScore = 0;
            int gradeCount = 0;

            while (presentation != "Finish")
            {
                double averageGrade = 0; 

                for (int i = 1; i <= jury; i++)
                {

                        double grade = double.Parse(Console.ReadLine());

                    gradeCount++;
                        averageGrade += grade;
                        finalScore += grade;

                }

                averageScore = averageGrade / jury;

                Console.WriteLine($"{presentation} - {averageScore:f2}.");

                presentation = Console.ReadLine();
            }

            finalScore = finalScore / gradeCount;
            Console.WriteLine($"Student's final assessment is {finalScore:f2}.");


        }
    }
}
