using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentIDDict
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's id num
                    Console.Write("student id num: ");
                    int newID = int.Parse(Console.ReadLine());

                    students.Add(newID, newStudent);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine("Student ID:" + student.Key + " is " + student.Value );
            }


            Console.ReadLine();
        }
    }
}
