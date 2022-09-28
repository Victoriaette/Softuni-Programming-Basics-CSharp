using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string bestPlayer = null;
            int goalsCounter = 0;

            while (name != "END")
            {
                
                int goals = int.Parse(Console.ReadLine());

                if (goals >= 10)
                {
                    bestPlayer = name;
                    goalsCounter = goals;
                    break;
                }

                if (goals > goalsCounter)
                {
                    bestPlayer = name;
                    goalsCounter = goals;
                   
                }

                name = Console.ReadLine();
            }

            

            if ( goalsCounter >= 3 )
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {goalsCounter} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {goalsCounter} goals.");
            }
                

        }
    }
}
