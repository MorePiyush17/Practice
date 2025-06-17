using System;
namespace Assigments
{
    public class Currency_Calculator
    {
        static void Main(String[] args)
        {
            // Factorial of Number
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //long factorial = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine($"Factorial of {number} is : {factorial}");


            // Currency Calculator
            Console.Write("Enter a amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            //validation
            if (amount % 100 != 0)
            {
                Console.WriteLine("Amount should be in multiples of 100");
            }
            else if (amount > 5000)
            {
                Console.WriteLine("Amount exceeds withdrawal limit");
            }
            else
            {
                //note denominations

                int twoThousands = amount / 2000;
                amount %= 2000;

                int fiveHundred = amount / 500;
                amount %= 500;

                int twoHundred = amount / 200;
                amount %= 200;

                int Hundred = amount / 100;
                amount %= 100;

                //output

                if (twoThousands > 0)
                    Console.WriteLine($"Two thousands: {twoThousands}");

                if (fiveHundred > 0)
                    Console.WriteLine($"fiveHundred: {fiveHundred}");

                if (twoHundred > 0)
                    Console.WriteLine($"twoHundred: {twoHundred}");

                if (Hundred > 0)
                    Console.WriteLine($"Hundred: {Hundred}");

            }
        }

    }
}