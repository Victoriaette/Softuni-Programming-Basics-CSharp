using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                

                for (int j = 2; j <= n2; j++)
                {
                    bool flag = false;
                    int m = j / 2;

                    for (int l = 2; l <= m; l++)
                    {
                        if (j % l == 0)
                        {
                            flag = true;
                            break;
                        }

                    }

                    if (flag == true)
                    {
                        continue;
                    }

                    

                    for (int k = 1; k <= n3; k++)
                    {
                        if (k % 2 != 0)
                        {
                            continue;
                        }

                        
                        Console.WriteLine($"{i} {j} {k}");

                    }


                }


            }
        } 
    }
}
