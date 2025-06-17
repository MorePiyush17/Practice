//word count

using System;
namespace assignments;

	public class Wordcount

{
	static void Main(string[] args)
	{
	Console.WriteLine("Enter a sentence: ");
	String input = Console.ReadLine();
	
//split sentence into words

	String[] words = input.Split(' ');

	int wordcount = 0;
	
// non empty words are count

	foreach(String word in words)
	{
		wordsCount++;
	}
    }
	Console.WriteLine("Number of words: " + wordcount);
	}
}
 


