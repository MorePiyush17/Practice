using System;

namespace Palindrome
{
   public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); //used to convert string input to integer

            int original = number;
            int remainder, reverse = 0;

		// reverse the number
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number /= 10;
            }

            if (original == reverse)
            {
                Console.WriteLine(original + " is a palindrome number.");
            }
            else
            {
                Console.WriteLine(original + " is not a palindrome.");
            }
        }
    }
}
