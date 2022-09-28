using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int tabFacebook = 0;
            int tabInstagram = 0;
            int tabReddit = 0;

            for (int i = 1; i<=n; i++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        tabFacebook++;
                        break;
                    case "Instagram":
                        tabInstagram++;
                        break;
                    case "Reddit":
                        tabReddit++;
                        break;
                }
            }

            salary = salary - ((tabFacebook * 150) + (tabInstagram * 100) + (tabReddit * 50));

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }

        }
    }
}
