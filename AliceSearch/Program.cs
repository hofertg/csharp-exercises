using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceSearch
{
    class Program
    {
        public static void Main(string[] args)
        {
            string story = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string userSearch;
            string message;

            Console.Write("What are you looking for?");
            userSearch = Console.ReadLine();

            if (story.ToLower().Contains(userSearch))
            {
                message = "{0} found in the story";
            }
            else
            {
                message = "Not found was {0}";
            }

            Console.WriteLine(string.Format(message, userSearch));
            Console.Read();
        }
    }
}
