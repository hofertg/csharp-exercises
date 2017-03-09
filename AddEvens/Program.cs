using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddEvens
{
    public class Program
    {
        public static int AddTheEvens(List<int> list)
        {
            int sum = 0;
            foreach(int number in list)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            int randomNum;

            Console.Write("Creating numbers");
            for (int i = 0; i < 10; i++)
            {
                randomNum = rnd.Next(1, 50);
                numbers.Add(randomNum);
                Console.Write(string.Format("{0} ", randomNum));
            }

            Console.WriteLine(string.Format("\nWe have added the even numbers up to: {0}", AddTheEvens(numbers)));
            Console.Read();

        }
    }
}
