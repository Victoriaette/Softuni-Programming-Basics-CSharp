using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = (Console.ReadLine());

            int stepGoal = 10000;
            int stepCount = 0;

            while (true)
            {

                if (steps == "Going home")
                {
                    steps = (Console.ReadLine());
                    stepCount += int.Parse(steps);
                    

                    if (stepCount >= stepGoal)
                    {
                        stepGoal = Math.Abs(stepGoal - stepCount);

                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepGoal} steps over the goal!");
                        break;
                    }

                    if (stepCount < stepGoal)

                    {
                        stepGoal = Math.Abs(stepGoal - stepCount);

                        Console.WriteLine($"{stepGoal} more steps to reach goal.");

                        break;
                    }
                        
                }

                stepCount += int.Parse(steps);

                if (stepCount >= stepGoal)
                {
                    stepGoal = Math.Abs(stepGoal - stepCount);

                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepGoal} steps over the goal!");

                    break;
                }

                 steps = (Console.ReadLine());

            }
        }
    }
}
