using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            double mpg;

            Console.WriteLine("We shall compute the miles-per-gallon of a trip");

            Console.Write("What is the number of miles traveled?");
            miles = double.Parse(Console.ReadLine());

            Console.Write("What is the number of gallons of gas used?");
            gas = double.Parse(Console.ReadLine());

            mpg = miles / gas;
            Console.WriteLine(string.Format("Your trip was {0} miles, using {1} gallons of gas, resulting in {2} mpg", miles, gas, mpg));

            Console.Read();
        }
    }
}
