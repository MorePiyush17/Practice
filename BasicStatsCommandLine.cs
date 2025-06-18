using System;

namespace BasicStatsCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter numbers: ");
                return;
            }
                   //converts arguments which are strings into integers
              int[] numbers = new int[args.Length];
              for (int i = 0; i < args.Length; i++)
              {
                numbers[i] = int.Parse(args[i]);// Converts each string to int
          }

             int count = numbers.Length;
             int sum = 0;
             int max = numbers[0];
             int min = numbers[0];

      //calculate sum,array, max, min
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];  

                 if (numbers[i] > max)
                    max = numbers[i];

                 if (numbers[i] < min)
                    min = numbers[i];
            }
           // calculate avg
            double average = (double)sum / count;

            Console.WriteLine("Count: " + count);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
        }
    }
}

//output
// C:\Users\piyush.more\Desktop\Programs>CommandLineApp.exe 10 20 30 40
// Count: 4
// Sum: 100
// Average: 25
// Maximum: 40
// Minimum: 10

// C:\Users\piyush.more\Desktop\Programs>
