using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grade = double.Parse(Console.ReadLine());

            int currClass = 0;
            int failClass = 0;

            double allGrades = 0;
            int gradesCount = 1;


            while(currClass <= 12)
            {
                allGrades += grade;
               

                if ( grade >= 4)
                {
                    currClass++;
                }
                else if( grade < 4)
                {
                    failClass++;


                    if ( failClass == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {++currClass} grade");
                        break;
                    }
                }

                if ( currClass == 12)
                {
                    double avrageGrade = allGrades / gradesCount;
                    Console.WriteLine($"{name} graduated. Average grade: {avrageGrade:f2}");
                    break;
                }

               grade = double.Parse(Console.ReadLine());
                gradesCount++;
            }


        }
    }
}
