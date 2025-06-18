using System;
namespace Fibonacci
{
	public class Program
	{
	     public static void Main()
	     {
		int firstnum = 0, secondnum = 1, nextnum, numofelements, sum;
		Console.Write("Enter the number of elements: ");
		numofelements = Convert.ToInt32(Console.ReadLine()); //to convert string to integer
		if (numofelements < 2)
		{ 
		     Console.Write("Enter a number greater than two");

		}
		else{
		Console.Write(firstnum + " " + secondnum + " ");
                sum = firstnum + secondnum;
		
		for(int i =2; i < numofelements; i++)
		{
			nextnum = firstnum + secondnum;
			Console.Write(nextnum + " ");
                       
			sum += nextnum;    // for getting sum of the series 
			firstnum = secondnum;
			secondnum = nextnum;

		}
			Console.WriteLine(); // moving on nextline
			Console.WriteLine("Sum of the Fibonacci series is: " + sum);
                     }

		}

	}
}
