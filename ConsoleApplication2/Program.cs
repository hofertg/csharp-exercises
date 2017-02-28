using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double area;

            Console.WriteLine("We shall compute the area of a rectangle");

            Console.Write("What is the width?");
            width = double.Parse(Console.ReadLine());

            Console.Write("What is the height?");
            height = double.Parse(Console.ReadLine());

            area = width * height;
            Console.WriteLine(string.Format("Your rectangle has a width of {0}, height of {1}, and area of {2}", width, height, area));

            Console.Read();
        }
    }
}
