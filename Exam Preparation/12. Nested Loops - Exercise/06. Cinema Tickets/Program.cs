using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double totalStudentTickets = 0;
            double totalStandardTickets = 0;
            double totalKidTickets = 0;
            

            while (movie != "Finish")
            {
                
                double allTickets = 0;

                int freeSeats = int.Parse(Console.ReadLine());

                for (int i = 1; i <= freeSeats; i++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    if (ticketType == "student")
                    {
                        totalStudentTickets++;
                       
                        allTickets++; 
                    }
                    else if (ticketType == "standard")
                    {
                        totalStandardTickets++;
                        
                        allTickets++;

                    }
                    else if (ticketType == "kid")
                    {
                        totalKidTickets++;
                        
                        allTickets++;
                    }

                }

                double precentSeatForMovie = (allTickets / freeSeats ) * 100;

                Console.WriteLine($"{movie} - {precentSeatForMovie:f2}% full.");

                movie = Console.ReadLine();
                
            }

            double totalTickets = totalStandardTickets + totalStudentTickets + totalKidTickets;

            double precentStudent = totalStudentTickets / totalTickets * 100;
            double precentStandard = totalStandardTickets / totalTickets * 100;
            double precentKid = totalKidTickets / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{precentStudent:f2}% student tickets.");
            Console.WriteLine($"{precentStandard:f2}% standard tickets.");
            Console.WriteLine($"{precentKid:f2}% kids tickets.");
        }
    }
}