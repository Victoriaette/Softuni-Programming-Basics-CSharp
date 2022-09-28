using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine(); 
            string day = Console.ReadLine();    
            double quantity = double.Parse(Console.ReadLine());

            decimal price = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                
                switch (fruit)
                {
                    case "banana":
                        price = 2.50m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "apple":
                        price = 1.20m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "orange":
                        price = 0.85m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "grapefruit":
                        price = 1.45m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "kiwi":
                        price = 2.70m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "pineapple":
                        price = 5.50m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "grapes":
                        price = 3.85m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                
            }
            else if (day == "Sunday" || day == "Saturday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "apple":
                        price = 1.25m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "orange":
                        price = 0.90m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "grapefruit":
                        price = 1.60m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "kiwi":
                        price = 3.00m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "pineapple":
                        price = 5.60m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    case "grapes":
                        price = 4.20m;
                        Console.WriteLine($"{((decimal)quantity * price):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }              
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
