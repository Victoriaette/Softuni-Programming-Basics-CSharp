using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(command);
            }
        }
    }
}
