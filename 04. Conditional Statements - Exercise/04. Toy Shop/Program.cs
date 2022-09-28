using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double vacationPrice = double.Parse(Console.ReadLine());

            int puzzelNum = int.Parse(Console.ReadLine());  
            int dollNum = int.Parse(Console.ReadLine());  
            int bearNum = int.Parse(Console.ReadLine());  
            int minNum = int.Parse(Console.ReadLine());   
            int truckNum = int.Parse(Console.ReadLine());

            int fullToyNum = puzzelNum + dollNum + bearNum + minNum + truckNum;

            double puzzelPrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minPrice = 8.20;
            double truckPrice = 2.00;

            double finalIncome = (puzzelNum * puzzelPrice) + (dollNum * dollPrice) + (bearNum * bearPrice) + (minNum * minPrice) + (truckNum * truckPrice);

            
            if (fullToyNum >= 50)
            {
                // Discounted Price 
                finalIncome = finalIncome - finalIncome * 0.25; 
            }

            // Rent Payment
            finalIncome = finalIncome - finalIncome * 0.10;   

            if (finalIncome >= vacationPrice)
            {
                double leftMoney = finalIncome - vacationPrice;
                Console.WriteLine($"Yes! {leftMoney:F2} lv left.");
            }
            else
            {
                double leftMoney = Math.Abs(finalIncome - vacationPrice);
                Console.WriteLine($"Not enough money! {leftMoney:F2} lv needed.");
            }

           
        }
    }
}
