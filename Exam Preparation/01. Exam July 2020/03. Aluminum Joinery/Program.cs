using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int frameCount = int.Parse(Console.ReadLine());
            string typeFrame = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            
            
            if (typeFrame == "90X130" )
            {
                price = 110 * frameCount;

                if (frameCount > 30 && frameCount <= 60)
                {
                    price = price - (price * 0.05);
                }
                else if (frameCount > 60 )
                {
                    price =price - (price * 0.08);
                }
            }
            else if (typeFrame == "100X150")
            {
                price = 140 * frameCount;

                if (frameCount > 40 && frameCount <= 80)
                {
                    price = price - (price * 0.06);
                }
                else if (frameCount > 80)
                {
                    price = price - (price * 0.10);
                }
            }
            else if (typeFrame == "130X180")
            {
                price = 190 * frameCount;

                if (frameCount > 20 && frameCount <= 50)
                {
                    price = price - (price * 0.07);
                }
                else if (frameCount > 50)
                {
                    price = price - (price * 0.12);
                }
            }
            else if (typeFrame == "200X300")
            {
                price = 250 * frameCount;

                if (frameCount > 25 && frameCount <= 50)
                {
                    price =  price - (price * 0.09);
                }
                else if (frameCount > 50)
                {
                    price = price - (price * 0.14);
                }
            }



            if (delivery == "With delivery")
            {
                price += 60;
                
            }
            


            if (frameCount >= 100)
            {
                price = price - (price * 0.04);
            }


            if (frameCount < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else if (frameCount == 10)
            {
                price = price * frameCount;
            }
            else
            {
                Console.WriteLine($"{price:f2} BGN");
            }
        }
    }
}