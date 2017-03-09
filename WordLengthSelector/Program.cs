using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordLengthSelector
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Which length of word would you like to see? ");

            int wordLength = int.Parse(Console.ReadLine());

            List<string> words = new List<string>
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten"
            };

            Program.PrintWordsWithCount(words, wordLength);

            Console.Read();
        }

        public static void PrintWordsWithCount(List<string> words, int count)
        {
            int wordCount = 0;

            foreach(string word in words)
            {
                if (word.Length == count)
                {
                    Console.WriteLine(word);
                    wordCount++;
                }
            }
        }
    }
}
