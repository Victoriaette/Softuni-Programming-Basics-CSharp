﻿using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            double result = 0;          

            if (symbol == '+')
            {
               result = n1 + n2;
                if(result % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else if (result % 2 != 0 )
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
            }
            else if (symbol == '-')
            {               
                 result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }
            else if (symbol == '*')
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }
            else if (symbol == '/')
            {

                if (n2 == 0 || n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }              
                else
                {
                    result = (double)n1 / (double)n2;

                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
            }
            else if (symbol == '%')
            {
                
                if (n2 == 0 || n1 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;

                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
            }                    
            
        }
    }
}
