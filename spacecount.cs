using System;

namespace CountSpaces
{

	public class Program
	{
	   public static void Main()
	   {
	      Console.Write("Enter a sentence : ");
	      String sentence = Console.ReadLine();
		
	      int spaceCount = 0;
	      
              for(int i = 0; i < sentence.Length; i++)
	      {
		if (sentence[i] == ' ')
		{
			spaceCount++;

                   }
		}
		Console.WriteLine("Total spaces: " + spaceCount);

		
		}
       }
}