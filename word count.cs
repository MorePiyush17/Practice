using System;

namespace Assignments
{
    public class Wordcount
    {
        public static void Main()
        {

            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            // Sentence split into words
            string[] words = input.Split(' ');

            // Count the non-empty words

            int wordCount = 0;
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))  //empty spaces ignore
                {
                    wordCount++;
                }
            }

            // Output 
            Console.WriteLine("Number of words: " + wordCount);
        }
    }
}
