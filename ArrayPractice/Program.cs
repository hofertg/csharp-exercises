using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };
            foreach (int number in array) {
                Console.WriteLine(number);
            }
            Console.Read();
        }
    }
}
