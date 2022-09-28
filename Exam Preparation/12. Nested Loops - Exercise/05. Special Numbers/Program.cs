using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());



            for (int i = 1111; i <= 9999; i++)
            {
                bool isSpecialNumber = true;

                for (int j = 0; j <= 3; j++)
                {


                    int currIndex = (int)Char.GetNumericValue(i.ToString()[j]);


                    if (currIndex == 0 || number % currIndex != 0)
                    {
                        isSpecialNumber = false;
                        break;
                    }

                }

                if (isSpecialNumber == true)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}