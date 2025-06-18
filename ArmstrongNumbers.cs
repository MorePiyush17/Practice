using System;

namespace ArmstrongNumbers
{
	public class Program
	{
       	   public static void Main(String[] args)
	    {
	      int number, rem, temp, sum = 0;
     	      Console.WriteLine("Enter a number : ");
	      number = Convert.ToInt32(Console.ReadLine());
	      
              temp = number;

	      int digits = number.ToString().Length;
	      while(number > 0)
		{
		rem = number % 10;
		sum += (int)Math.Pow(rem, digits);// it raise the power of digits. using instead of rem*rem*rem.
		number = number/10;
        }
		
	   if(temp == sum)
		Console.WriteLine(temp + " is a Armstrong number");
	   else
                Console.WriteLine(temp + " is not an Armstrong number");

		}
    }
}