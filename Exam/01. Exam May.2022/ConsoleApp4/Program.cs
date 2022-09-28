using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int students = int.Parse(Console.ReadLine());
           

            double avrageGrade = 0;
            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5)
                {
                    group1++;
                    avrageGrade += grade;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    group2++;
                    avrageGrade += grade;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    group3++;
                    avrageGrade += grade;
                }
                else if (grade < 3)
                {
                    group4++;
                    avrageGrade += grade;
                }

                

            }

            double topStudents = group1 / students * 100;
            double goodStudents = group2 / students * 100;
            double poorStudents = group3 / students * 100;
            double failStudents = group4 / students * 100;

            double avrage = avrageGrade / students;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudents:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {poorStudents:f2}%");
            Console.WriteLine($"Fail: {failStudents:f2}%");
            Console.WriteLine($"Average: {avrage:f2}");

        }
    }
}
