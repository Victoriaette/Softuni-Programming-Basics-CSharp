using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());

            string question = Console.ReadLine();
            int grade = int.Parse(Console.ReadLine());

            int badGradesCounter = 0;
            int gradesCounter = 0;
            double averageGrade = 0;
            string lastQuestion = null;

            while (true)
            {
                gradesCounter++;

                if (grade <= 4)
                {
                    badGradesCounter++;

                    if (badGradesCounter == badGrade)
                    {
                        Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                        break;
                    }
                }
                
                averageGrade += grade;
                lastQuestion = question;

                question = Console.ReadLine();

                if (question == "Enough")
                {
                    averageGrade = averageGrade / gradesCounter;

                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {gradesCounter}");
                    Console.WriteLine($"Last problem: {lastQuestion}");
                    break;
                }

                grade = int.Parse(Console.ReadLine());

            }
        }
    }
}
