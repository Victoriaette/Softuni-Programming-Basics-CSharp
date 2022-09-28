using System;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int room = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();

            double price = 5;
            double income = 0;

            while (true)
            {
                if (people == "Movie time!")
                {
                    break;
                }

                if (room < int.Parse(people))
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {income} lv.");
                    return;
                }

                room -= int.Parse(people);
                price = int.Parse(people) * 5;

                if ( int.Parse(people) % 3 == 0)
                {
                    income += price - 5;
                }
                else
                {
                    income += price;
                }

                people = Console.ReadLine();

            }

            Console.WriteLine($"There are {room} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {income} lv.");
        }
    }
}
