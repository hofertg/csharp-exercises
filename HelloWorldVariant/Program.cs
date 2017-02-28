using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldVariant
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("What is your name?");
            name = Console.ReadLine();

            Console.Write(string.Format("Hello, {0}", name));

            Console.Read();
        }
    }
}
