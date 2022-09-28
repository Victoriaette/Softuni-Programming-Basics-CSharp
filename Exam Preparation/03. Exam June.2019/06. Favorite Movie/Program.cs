using System;

namespace _06._Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bestValue = int.MinValue;
            string bestMovie = "";

            for (int i = 0; i < 7 ; i++)
            {
                string title = Console.ReadLine();
                
                if (title == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {bestMovie} with {bestValue} ASCII sum.");
                    return;
                }

                int sum = 0;

                for (int j = 0; j < title.Length ; j++)
                {
                    int ascii = (int)title[j];

                    if ( ascii >= 97 && ascii <= 122)
                    {
                        sum += ascii - 2 * title.Length;
                    }
                    else if ( ascii >= 65 && ascii <= 90 )
                    {
                        sum += ascii - title.Length;
                    }
                    else
                    {
                        sum += ascii;
                    }
                }

                if (sum > bestValue)
                {
                    bestValue = sum;
                    bestMovie = title;
                }

            }

            Console.WriteLine("The limit is reached.");
            Console.WriteLine($"The best movie for you is {bestMovie} with {bestValue} ASCII sum.");
        }
    }
}
