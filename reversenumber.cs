using System;

namespace reversenumber
{
   public class Program
	{
       static void Main()
	{
	  Console.WriteLine("Enter a number: ");	
          int number = int.Parse(Console.ReadLine());
	  int reminder, reverse = 0;

	  while (number > 0)
	  {
		reminder = number % 10 ;
	       
		reverse = (reverse * 10) + reminder;
		
		number = number / 10;
		}
	      Console.WriteLine(" The Reverse order is " + reverse ); 
		
		
	}
    }
}