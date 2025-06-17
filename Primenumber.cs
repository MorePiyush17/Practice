using system;
namespace Assignments
{
	public class checkprime
	{
		Static void Main()
		{

			Console.write("Enter a number: ");

			//convert from string to integer
			int number = int.Parse(Console.ReadLine());
			bool is Prime = true;

			for (int i = 2; i < number / 2; i++)
			{
				if (number % i == 0)
				{
					IsPrime = false;
					break;
				}
			}
			if (IsPrime)
			{
				Console.Write("It is a Prime number");
			}
			else
			{
				Console.Write("It is not a Prime number");
			}
		}
	}


