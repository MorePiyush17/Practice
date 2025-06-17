//Factorial
using System;
namespace assignments
{
	public class Factorial
	{
		static void Main(String[] args)
		{
  		    Console.WriteLine("Enter a number: ");

			//convert from string to int
		    int num = int.Parse(Console.ReadLine());
	
	            int factorial = 1;
		    for(int i = 1; i<=num; i++);
	        {
		factorial = factorial*i;
	        }
	
	        Console.WriteLine($"Factorial of {num} is:{factorial}");
		    Console.ReadLine();
}

}

