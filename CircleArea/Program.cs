using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius;
            double area;
            string input = "";

            Console.WriteLine("We shall compute the area of a circle");

            
            while (! double.TryParse(input, out radius) || double.Parse(input) < 0)
            {
                Console.Write("What is the radius?");
                input = Console.ReadLine();
            }

            area = Math.PI * radius * radius;

            Console.WriteLine(string.Format("The area of a circle of radius {0} is: {1}", radius, area));

            Console.Read();
        }
    }
}
