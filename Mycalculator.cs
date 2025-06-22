using System;

namespace MyCalculatorApp
{
    class Calculator
    {
        // Method 1: Add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 2: Add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method 3: Add array of integers
        public int Add(int[] numbers)
        {
            if (numbers == null)
            {
                Console.WriteLine("Warning: array is null.");
                return 0;
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("Warning: array is empty.");
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Integer input
            Console.WriteLine("Adding two integers: ");
            Console.Write("Enter first number: ");
            int int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int int2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: " + calc.Add(int1, int2));

            // Double input
            Console.WriteLine("\nAdding two doubles: ");
            Console.Write("Enter first double: ");
            double d1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second double: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + calc.Add(d1, d2));

            // Array input
            Console.WriteLine("\nAdding an array of integers:");
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Result: " + calc.Add(numbers));

            // Invalid inputs
            Console.WriteLine("\nInvalid input: array is null or empty.");
            Console.WriteLine("Result (should be 0): " + calc.Add(null));
            Console.WriteLine("Result (should be 0): " + calc.Add(new int[0]));

    
        }
    }
}
