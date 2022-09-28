using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theBook = Console.ReadLine();

            string book = Console.ReadLine();

            int booksCounter = 0;

            while (book != "No More Books")
            {
               

                if (book == theBook)
                {
                    Console.WriteLine($"You checked {booksCounter} books and found it.");
                    break;
                }
                else
                {
                    booksCounter++;
                    book = Console.ReadLine();
                }           
               
            }

            if ( book == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");

                Console.WriteLine($"You checked {booksCounter} books."); 
            }

           
        }
    }
}
