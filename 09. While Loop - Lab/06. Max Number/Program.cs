using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int maxValue = int.MinValue;

            while ( n != "Stop")
            {
                
                
                if( int.Parse(n) > maxValue)
                {
                    maxValue = int.Parse(n);
                }

                n = Console.ReadLine();
            }

            Console.WriteLine(maxValue);


        }
    }
}
