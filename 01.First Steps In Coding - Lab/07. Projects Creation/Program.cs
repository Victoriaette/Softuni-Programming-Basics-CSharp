using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();

            int project = int.Parse(Console.ReadLine());

            int hours = project * 3;


            Console.WriteLine("The architect " + name + " will need " + hours + " hours to complete " + project + " project/s.");



        }
    }
}