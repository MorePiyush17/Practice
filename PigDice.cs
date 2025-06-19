using System;

namespace PigDice
{
    internal class Program
     {
        static void Main(string[] args)
         {
            Random random = new Random();
            int totalScore = 0;
            int numberofturns = 0;

            while (totalScore < 20)
             {
                numberofturns++;
                int turnScore = 0;
                Console.WriteLine();
                Console.WriteLine($"Turn {numberofturns}");

                while (true)
	         {
                    Console.Write("Roll or Hold? (r/h): ");
                    string choice = Console.ReadLine();

                    if (choice == "r")
                    {
                        int roll = random.Next(1, 7);  
                        Console.WriteLine($"Die: {roll}");

                        if (roll == 1)
                        {
                            Console.WriteLine("Turn over! No points this turn.");
                            turnScore = 0;
                            break;
                          }
                        else
                        {
                            turnScore += roll;
                            Console.WriteLine($"Turn Score: {turnScore}");
                          }
                   }
                    else if (choice == "h")
                    {
                        totalScore += turnScore;
                        Console.WriteLine($"Total Score: {totalScore}");
                        break;
                    }
                    else
                    {
                  Console.WriteLine("Invalid input. Enter 'r' to roll or 'h' to hold.");
                    }
                }
            }

            Console.WriteLine($"You finished the game in {numberofturns} turns!");
        }
    }
}
