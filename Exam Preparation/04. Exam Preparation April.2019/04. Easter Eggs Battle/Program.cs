using System;

namespace _04._Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOneEggs = int.Parse(Console.ReadLine());
            int playerTwoEggs = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End")
            {
                if (playerOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                    return;
                }
                else if (playerTwoEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                    return;
                }

                if( winner == "one")
                {
                    playerTwoEggs--;
                }
                else if (winner == "two")
                {
                    playerOneEggs--;
                }

                winner = Console.ReadLine();
            }

            Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
            Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
        }
    }
}
