using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace CountingCharacters
{
    public class Program
    {
        public static Dictionary<char, int> CharacterCount(string text)
        {
            Dictionary<char, int> characterBreakdown = new Dictionary<char, int>();

            foreach(char character in text)
            {
                if (characterBreakdown.ContainsKey(character))
                {
                    characterBreakdown[character] += 1;
                }
                else
                {
                    characterBreakdown[character] = 1;
                }
            }

            return characterBreakdown;

        }

        public static void PrintCharacterCount(Dictionary<char, int> characterCount)
        {
            Console.WriteLine("Basic character counts:");
            foreach(KeyValuePair<char, int> character in characterCount)
            {
                Console.WriteLine("{0}: {1}", character.Key, character.Value);
            }
        }

        public static void PrintSortedCharacterCount(Dictionary<char, int> characterCount)
        {
            Console.WriteLine("Sorted character counts:");
            List<string> characterList = new List<string>();
            foreach (KeyValuePair<char, int> character in characterCount)
            {
                characterList.Add(string.Format("{0}: {1}", character.Key, character.Value));
            }
            characterList.Sort();
            foreach (string character in characterList)
            {
                Console.WriteLine(character);
            }
        }

        public static Dictionary<char, int> CharacterCountInsensitive(string text)
        {
            return CharacterCount(text.ToUpper());
        }

        public static Dictionary<char, int> CharacterCountAlphabetic(string text)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            text = rgx.Replace(text, "");
            return CharacterCount(text);
        }

        public static Dictionary<char, int> CharacterCountInsensitiveAlphabetic(string text)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            text = rgx.Replace(text, "");
            return CharacterCount(text.ToUpper());
        }

        public static void Main(string[] args)
        {
            //string tester = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //Console.Write("What string would you like counted? ");
            //string tester = Console.ReadLine();
            string tester = System.IO.File.ReadAllText(@"C:\Users\hofer\code\csharp-exercises\CountingCharacters\TestingText.txt");


            Dictionary<char, int> breakdown = CharacterCountInsensitiveAlphabetic(tester);
            PrintCharacterCount(breakdown);
            PrintSortedCharacterCount(breakdown);
            Console.Read();
        }
    }
}
