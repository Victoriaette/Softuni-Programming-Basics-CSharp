﻿using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;

            if (minutes > 59)
            {
                hours = hours + 1;
                minutes = minutes - 60;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            { 
                Console.WriteLine($"{hours}:{minutes}");
            }
               

        }
    }
}
